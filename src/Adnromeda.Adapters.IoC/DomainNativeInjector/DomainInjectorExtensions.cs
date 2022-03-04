using Andromeda.Domain.Application.Mapping;
using Andromeda.Domain.Application.UseCases;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Andromeda.Adapters.IoC.DomainNativeInjector
{
    public static class DomainInjectorExtensions
    {
        public static IServiceCollection RegisterDomainServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddScoped<IMappingHandler, MappingHandler>();

            services.AddScoped<IUSCTodo, USCTodo>();

            return services;
        }
    }
}
