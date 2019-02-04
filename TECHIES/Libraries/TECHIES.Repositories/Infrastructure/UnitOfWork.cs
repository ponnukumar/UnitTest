using System;
using System.Data;
using TECHIES.Core.Interfaces.Infrastructure;
using TECHIES.Core.Interfaces.Repositories;

namespace TECHIES.Repositories.Infrastructure
{
    public class UnitOfWork : IUnitOfWork, IDisposable
    {
        private readonly IDbConnectionFactory _connectionFactor;
        private IDbTransaction _transaction;

        #region Ctor
        public UnitOfWork(IDbConnectionFactory connectionFactory,IOrderRepository orderRepository)
        {
            _connectionFactor = connectionFactory;
            OrderRepository = orderRepository;
        }
        #endregion

        /// <summary>
        /// Gets the order repository.
        /// </summary>
        /// <value>
        /// The order repository.
        /// </value>
        public IOrderRepository OrderRepository { get; }

        /// <summary>
        /// Performs application-defined tasks associated with freeing, releasing, or resetting unmanaged resources.
        /// </summary>
        public void Dispose()
        {
            if (_transaction !=null)
            {
                _transaction.Dispose();
                _transaction = null;
            }
        }
    }
}
