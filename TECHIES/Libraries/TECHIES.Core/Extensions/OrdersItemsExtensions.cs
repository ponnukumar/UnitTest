using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TECHIES.Core.Domain;
using TECHIES.Core.ViewModels;

namespace TECHIES.Core.Extensions
{
   public static class OrdersItemsExtensions
    {
        /// <summary>
        /// Maps the specified order items.
        /// </summary>
        /// <param name="orderItems">The order items.</param>
        /// <returns></returns>
        public static IEnumerable<CustomerOrderItems> Map(this IEnumerable<OrderItems> orderItems)
        {
            return orderItems.Select(Map);
        }

        /// <summary>
        /// Maps the specified order items.
        /// </summary>
        /// <param name="orderItems">The order items.</param>
        /// <returns></returns>
        public static CustomerOrderItems Map(this OrderItems orderItems)
        {
            return new CustomerOrderItems
            {
                OrderItemId=orderItems.OrderItemId,
                OrderId=orderItems.OrderId,
                ProductId=orderItems.Products.ProductId,
                Quantity=orderItems.Quantity

            };

        }
    }
}
