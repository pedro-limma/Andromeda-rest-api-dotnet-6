using Andromeda.Adapters.DAL.Connection;
using Andromeda.Adapters.DAL.UnitOfWork;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Andromeda.Adapters.IoC.DALNativeInjector
{
    public static class DALInjectorExtensions
    {
        public static IServiceCollection RegisterDALServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddSingleton<DBSession>();
            services.AddSingleton<IMongoDBConnectionFactory, MongoDBConnectionFactory>(
                factory => new MongoDBConnectionFactory(
                    new DBConnParameterModel(
                            url: configuration.GetSection("MongoDBConnections")["Url"],
                            database: configuration.GetSection("MongoDBConnections")["Database"],
                            username: configuration.GetSection("MongoDBConnections")["Username"],
                            password: configuration.GetSection("MongoDBConnections")["Password"]
                        )));

            services.AddTransient<IUnitOfWork, UnitOfWork>();

            return services;
        }
    }
}
