using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TECHIES.Core.Domain;
using TECHIES.Core.Extensions;
using TECHIES.Core.Interfaces;
using TECHIES.Core.Interfaces.Infrastructure;
using TECHIES.Core.Interfaces.Repositories;
using TECHIES.Core.ViewModels;

namespace TECHIES.Managers
{
    public class ManageOrders : IManageOrders
    {
        /// <summary>
        /// The order repository
        /// </summary>
        private readonly IOrderRepository _orderRepository;

        #region Ctor        
        /// <summary>
        /// Initializes a new instance of the <see cref="ManageOrders"/> class.
        /// </summary>
        /// <param name="unitOfWork">The unit of work.</param>
        public ManageOrders(IUnitOfWork unitOfWork)
        {
            _orderRepository = unitOfWork.OrderRepository;
        }
        #endregion    
        
        /// <summary>
        /// Gets the orders by customer identifier asynchronous.
        /// </summary>
        /// <param name="customerId">The customer identifier.</param>
        /// <param name="orderId">The order identifier.</param>
        /// <returns></returns>
        public async Task<IList<CustomerOrders>> GetOrdersByCustomerIdAsync(Guid customerId, int orderId)
        {
           var orders= await _orderRepository.GetOrderDetailsByCustomerIdAsync(customerId, orderId);
            return (orders !=null ? orders.Map() : Enumerable.Empty<CustomerOrders>()).ToList();
        }
       
    }
}
