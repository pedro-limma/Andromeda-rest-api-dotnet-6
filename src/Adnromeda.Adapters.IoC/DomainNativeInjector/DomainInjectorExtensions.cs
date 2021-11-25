using Andromeda.Domain.Application.Mapping;
using Andromeda.Domain.Application.UseCases.AddTodo;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Andromeda.Adapters.IoC.DomainNativeInjector
{
    public static class DomainInjectorExtensions
    {
        public static IServiceCollection RegisterDomainServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddScoped<IMappingHandler, MappingHandler>();

            services.AddScoped<IUSCAddTodo, USCAddTodo>();

            return services;
        }
    }
}
