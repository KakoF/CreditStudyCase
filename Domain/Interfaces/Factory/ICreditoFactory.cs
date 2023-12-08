using Domain.Abstractions;
using Domain.Records;

namespace Domain.Interfaces.Factory
{
    public interface ICreditoFactory
    {
        CreditoAbstract Create(PropostaCredito credito);
    }
}
