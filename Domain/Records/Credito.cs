using Domain.Entities;

namespace Domain.Records
{
    public record Credito(ClienteEntity cliente, FinanciamentoEntity financiamento, IEnumerable<ParcelaEntity> parcelas)
    {
    }
}
