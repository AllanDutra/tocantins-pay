using Microsoft.Extensions.DependencyInjection;
using TocantinsPay.Application.Applications;
using TocantinsPay.Core.Interfaces.Applications;

namespace TocantinsPay.Application
{
    public static class ApplicationModule
    {
        public static IServiceCollection AddApplication(this IServiceCollection services)
        {
            services.AddScoped<ICadastrarClienteApplication, CadastrarClienteApplication>();
            services.AddScoped<IBuscarClientesApplication, BuscarClientesApplication>();
            services.AddScoped<IBuscarClientePorIdApplication, BuscarClientePorIdApplication>();

            return services;
        }
    }
}
