using Andromeda.Adapters.DAL.Connection.Factory;
using Andromeda.Adapters.DAL.Repository;
using Andromeda.Domain.Application.Interfaces;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Andromeda.Adapters.IoC.DALNativeInjector
{
    public static class DALInjectorExtensions
    {
        public static IServiceCollection RegisterDALServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddSingleton<IDatabaseFactory, DatabaseFactory>();
            services.AddScoped<ITodoRepository, TodoRepository>();

            return services;
        }
    }
}
