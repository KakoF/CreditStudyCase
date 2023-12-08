using Domain.Records;

namespace Domain.Interfaces.Service
{
    public interface ILiberarCreditoService
    {
        public Task<CreditoAprovado> LiberarCredito(PropostaCredito propostaCredito);
    }
}
