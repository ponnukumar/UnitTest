using Microsoft.Extensions.DependencyInjection;
using TECHIES.Core.Interfaces.Infrastructure;
using TECHIES.Repositories.Infrastructure;

namespace TECHIES.API.Extensions.Services
{
    public static class RepositoryExtensions
    {
        /// <summary>
        /// Adds the repositories.
        /// </summary>
        /// <param name="service">The service.</param>
        /// <returns></returns>
        public static IServiceCollection AddRepositories (this IServiceCollection service)
        {
            var config = service
                .BuildServiceProvider()
                .GetRequiredService<IEnvironmentConfig>();
            service.AddScoped<IDbConnectionFactory>(s=> { return new DbConnectionFactory(config.ConnectionString); });
            return service;
        }
    }
}
