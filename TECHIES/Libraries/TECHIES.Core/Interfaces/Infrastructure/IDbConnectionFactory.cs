using System.Data;
namespace TECHIES.Core.Interfaces.Infrastructure
{
    /// <summary>
    /// Represents connection factory.
    /// </summary>
    public interface IDbConnectionFactory
    {
        /// <summary>
        /// Gets the connection.
        /// </summary>
        /// <returns></returns>
        IDbConnection GetConnection();
    }
}
