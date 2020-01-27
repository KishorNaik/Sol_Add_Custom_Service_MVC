using Microsoft.Extensions.DependencyInjection;
using Sol_Demo.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sol_Demo.AddServices
{
    public static class RepositoryServicesExtensions
    {
        public static void AddRepository(this IServiceCollection services)
        {
            services.AddTransient<IUserRepository, UserRepository>();
        }
    }
}
