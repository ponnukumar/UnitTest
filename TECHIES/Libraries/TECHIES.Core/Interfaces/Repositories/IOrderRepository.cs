using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TECHIES.Core.Domain;

namespace TECHIES.Core.Interfaces.Repositories
{
   public interface IOrderRepository
    {
     Task<IEnumerable<Orders>> GetOrderDetailsByCustomerIdAsync(Guid customerId,int orderId);
    }
}
