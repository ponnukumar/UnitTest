using System.Data;
using TECHIES.Core.Interfaces.Infrastructure;

namespace TECHIES.Repositories
{
    public class BaseRepository
    {
        /// <summary>
        /// The database connection factory
        /// </summary>
        private IDbConnectionFactory _dbConnectionFactory;

        #region Ctor
        public BaseRepository(IDbConnectionFactory dbConnectionFactory)
        {
            _dbConnectionFactory = dbConnectionFactory;
        }
        #endregion

        /// <summary>
        /// Gets the connection.
        /// </summary>
        /// <value>
        /// The connection.
        /// </value>
        public IDbConnection connection
        {
            get
            {
              return  _dbConnectionFactory.GetConnection();
            }
        }
    }
}
