using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TECHIES.Core.Interfaces;
using TECHIES.Managers;

namespace TECHIES.API.Extensions.Services
{
    public static class ManagerExtensions
    {
        /// <summary>
        /// Adds the managers.
        /// </summary>
        /// <param name="service">The service.</param>
        /// <returns></returns>
        public static IServiceCollection AddManagers(this IServiceCollection service)
        {
            service.AddTransient<IManageOrders,ManageOrders>();
            return service;
        }
    }
}
