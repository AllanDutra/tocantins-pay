using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace TocantinsPay.Infrastructure
{
    public static class InfrastructureModule
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services)
        {
            services.AddDbContext<TocantinsPayContext>(p => p.UseNpgsql("Server=localhost;Port=5490;Database=tocantinspay;User Id=admin;Password=admin;"));

            return services;
        }
    }
}
