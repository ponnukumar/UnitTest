using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TECHIES.Core.Domain;
using TECHIES.Core.ViewModels;

namespace TECHIES.Core.Extensions
{
    public static class OrdersExtensions
    {
        /// <summary>
        /// Maps the specified orders.
        /// </summary>
        /// <param name="orders">The orders.</param>
        /// <returns></returns>
        public static IEnumerable<CustomerOrders> Map(this IEnumerable<Orders> orders)
        {
            return orders.Select(Map);
        }

        /// <summary>
        /// Maps the specified orders.
        /// </summary>
        /// <param name="orders">The orders.</param>
        /// <returns></returns>
        public static CustomerOrders Map(this Orders orders)
        {
            return new CustomerOrders
            {
                OrderId = orders.OrderId,
                CustomerId = orders.CustomerId,
                Description = orders.Description

            };

        }
    }
}
