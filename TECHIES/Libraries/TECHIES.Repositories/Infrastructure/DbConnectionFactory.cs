using System;
using System.Data;
using System.Data.SqlClient;
using TECHIES.Core.Interfaces.Infrastructure;

namespace TECHIES.Repositories.Infrastructure
{
    public class DbConnectionFactory : IDbConnectionFactory,IDisposable
    {
        /// <summary>
        /// The connection
        /// </summary>
        private readonly SqlConnection _connection;

        #region Ctor
        public DbConnectionFactory(string connectionString)
        {
            _connection = new SqlConnection(connectionString);
            _connection.Open();
        }
        #region

        /// <summary>
        /// Performs application-defined tasks associated with freeing, releasing, or resetting unmanaged resources.
        /// </summary>
        public void Dispose()
        {
            _connection.Dispose();
        }

        /// <summary>
        /// Gets the connection.
        /// </summary>
        /// <returns></returns>
        public IDbConnection GetConnection()
        {
            return _connection;
        }
    }
}
