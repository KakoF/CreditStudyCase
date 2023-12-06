using Domain.Interfaces.Service;
using Microsoft.Extensions.DependencyInjection;
using Service.Services;

namespace Service
{
    public static class RegisterService
    {
        public static void ConfigureService(this IServiceCollection services)
        {
            services.AddScoped<ICreditoService, CreditoService>();
        }
    }
}