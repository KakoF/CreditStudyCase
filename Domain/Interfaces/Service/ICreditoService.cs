using Domain.Records;

namespace Domain.Interfaces.Service
{
    public interface ICreditoService
    {
        public Task<CreditoAprovado> LiberarCredito(PropostaCredito propostaCredito);
    }
}
