using TECHIES.Core.Interfaces.Repositories;
namespace TECHIES.Core.Interfaces.Infrastructure
{
    public interface IUnitOfWork
    {
        /// <summary>
        /// Gets the order repository.
        /// </summary>
        /// <value>
        /// The order repository.
        /// </value>
        IOrderRepository OrderRepository { get; }
    }
}
