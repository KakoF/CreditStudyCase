using Domain.Records;

namespace Domain.Interfaces.Service
{
    public interface ILiberarCreditoService
    {
        public Task<CreditoAprovado> LiberarCreditoAsync(PropostaCredito propostaCredito);
    }
}
