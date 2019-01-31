using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TECHIES.Core.Domain;
using TECHIES.Core.Interfaces.Repositories;


namespace TECHIES.Repositories
{
    public class OrderRepository : IOrderRepository
    {
        public async Task<IEnumerable<Orders>> GetOrderDetailsByCustomerIdAsync(Guid customerId, int orderId)
        {
            return null;
        }
    }
}
