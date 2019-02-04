using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using TECHIES.Core.ViewModels;

namespace TECHIES.Core.Interfaces
{
    public interface IManageOrders
    {
        /// <summary>
        /// Gets the orders by customer identifier asynchronous.
        /// </summary>
        /// <param name="customerId">The customer identifier.</param>
        /// <param name="OrderId">The order identifier.</param>
        /// <returns></returns>
        Task<IList<CustomerOrders>> GetOrdersByCustomerIdAsync(Guid customerId, int OrderId);
    }
}
