using Domain.Abstractions;
using Domain.Records;

namespace Domain.Interfaces.Service
{
    public interface ISalvarCreditoService
    {
        public Task<Credito> SalvarAsync(CreditoAbstract credito);
    }
}
