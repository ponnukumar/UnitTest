using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using TECHIES.Core.Domain;

namespace TECHIES.Core.Interfaces.Repositories
{
    public interface IOrderRepository
    {
        /// <summary>
        /// Gets the order details by customer identifier asynchronous.
        /// </summary>
        /// <param name="customerId">The customer identifier.</param>
        /// <param name="orderId">The order identifier.</param>
        /// <returns></returns>
        Task<IEnumerable<Orders>> GetOrderDetailsByCustomerIdAsync(Guid customerId, int orderId);
    }
}
