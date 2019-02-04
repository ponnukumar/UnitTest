using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Threading.Tasks;
using TECHIES.Core.Domain;
using TECHIES.Core.Interfaces.Infrastructure;
using TECHIES.Core.Interfaces.Repositories;


namespace TECHIES.Repositories
{
    public class OrderRepository : BaseRepository, IOrderRepository
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OrderRepository"/> class.
        /// </summary>
        /// <param name="dbConnectionFactory">The database connection factory.</param>
        public OrderRepository(IDbConnectionFactory dbConnectionFactory) : base(dbConnectionFactory) { }

        /// <summary>
        /// Gets the order details by customer identifier asynchronous.
        /// </summary>
        /// <param name="customerId">The customer identifier.</param>
        /// <param name="orderId">The order identifier.</param>
        /// <returns></returns>
        public async Task<IEnumerable<Orders>> GetOrderDetailsByCustomerIdAsync(Guid customerId, int orderId)
        {
            var orderDetailsDic = new Dictionary<long, Orders>();
            await connection.QueryAsync<Orders, OrderItems, Products, Orders>("",
                (orders, orderItems, products) =>
                {
                    if (!orderDetailsDic.TryGetValue(orders.OrderId, out Orders orderDetails))
                    {
                        orders = orderDetails;
                        orderDetailsDic.Add(orderDetails.OrderId, orderDetails);
                    }
                    orderDetails.OrderItems.Add(new OrderItems
                    {
                        OrderId = orderItems.OrderId,
                        OrderItemId = orderItems.OrderItemId,
                        ProductId = orderItems.ProductId,
                        Quantity = orderItems.Quantity,
                        Products = new Products()
                        {
                            ProductId = products.ProductId,
                            ProductName = products.ProductName
                        }
                    });
                    return orderDetails;
                }, 
                new { customerId, orderId },
                commandType: CommandType.StoredProcedure,
                splitOn: "ProductId,ProductName");
            return orderDetailsDic.Values;
        }
    }
}
