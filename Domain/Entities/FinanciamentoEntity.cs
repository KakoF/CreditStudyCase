
using Domain.Enums;

namespace Domain.Entities
{
    public class FinanciamentoEntity : BaseEntity
    {
        public FinanciamentoEntity(long id, eTipoCredito tipoFinanciamento, decimal valorTotal, DateTime dataUltimoVencimento, long clienteId): base(id)
        {
            TipoFinanciamento = tipoFinanciamento;
            ValorTotal = valorTotal;
            DataUltimoVencimento = dataUltimoVencimento;
            ClienteId = clienteId;
        }

        public FinanciamentoEntity(eTipoCredito tipoFinanciamento, decimal valorTotal, DateTime dataUltimoVencimento, long clienteId)
        {
            TipoFinanciamento = tipoFinanciamento;
            ValorTotal = valorTotal;
            DataUltimoVencimento = dataUltimoVencimento;
            ClienteId = clienteId;
        }

        public eTipoCredito TipoFinanciamento { get; }
        public decimal ValorTotal { get; }
        public DateTime DataUltimoVencimento { get; }
        public long ClienteId { get; }
    }
}
