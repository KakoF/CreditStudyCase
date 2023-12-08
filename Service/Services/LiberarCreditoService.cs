using Domain.Interfaces.Factory;
using Domain.Interfaces.Service;
using Domain.Records;

namespace Service.Services
{
    public class LiberarCreditoService : ILiberarCreditoService
    {
        private readonly ICreditoFactory _factory;
        private readonly ISalvarCreditoService _salvarCreditoService;
        public LiberarCreditoService(ICreditoFactory factory, ISalvarCreditoService salvarCreditoService)
        {
            _factory = factory;
            _salvarCreditoService = salvarCreditoService;

        }
        public async Task<CreditoAprovado> LiberarCredito(PropostaCredito propostaCredito)
        {
            var credito = _factory.Factory(propostaCredito);
            credito.ViabilizarLiberacao();
            var calculo = credito.CalcularCredito();
            await _salvarCreditoService.SalvarAsync(credito);
            return calculo;
        }
    }
}
