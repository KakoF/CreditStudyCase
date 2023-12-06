using Domain.Interfaces.Repository;
using Infrastructure.DataConnector;
using Infrastructure.Interfaces.DataConnector;
using Infrastructure.Repository;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Infrastructure
{
    public static class RegisterService
    {
        public static void ConfigureInfraStructure(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddScoped<IDbConnector>(db => new PostgresConnector(configuration.GetConnectionString("Credito")));
            services.AddScoped<IUnitOfWork, UnitOfWork>();
            services.AddScoped<IClienteRepository, ClienteRepository>();
            services.AddScoped<IParcelaRepository, ParcelaRepository>();
            services.AddScoped<IFinanciamentoRepository, FinanciamentoRepository>();
        }
    }
}