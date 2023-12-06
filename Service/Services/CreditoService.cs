using Domain.Interfaces.Factory;
using Domain.Interfaces.Repository;
using Domain.Interfaces.Service;
using Domain.Records;

namespace Service.Services
{
    public class CreditoService : ICreditoService
    {
        private readonly ICreditoFactory _factory;
        public CreditoService(ICreditoFactory factory)
        {
            _factory = factory;
        }
        public async Task<CreditoAprovado> LiberarCredito(PropostaCredito propostaCredito)
        {
            var credito = _factory.Factory(propostaCredito);
            credito.ViabilizarLiberacao();
            return credito.CalcularCredito();
        }
    }
}
