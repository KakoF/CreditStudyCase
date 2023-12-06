
namespace Domain.Entities
{
    public class ParcelaEntity : BaseEntity
    {
        public ParcelaEntity(long id, int numeroParcela, decimal valorParcela, DateTime dataVencimento, DateTime? dataPagamento, long financiamentoId): base(id)
        {
            NumeroParcela = numeroParcela;
            ValorParcela = valorParcela;
            DataVencimento = dataVencimento;
            DataPagamento = dataPagamento;
            FinanciamentoId = financiamentoId;
        }

        public ParcelaEntity(int numeroParcela, decimal valorParcela, DateTime dataVencimento, DateTime? dataPagamento, long financiamentoId)
        {
            NumeroParcela = numeroParcela;
            ValorParcela = valorParcela;
            DataVencimento = dataVencimento;
            DataPagamento = dataPagamento;
            FinanciamentoId = financiamentoId;
        }

        public int NumeroParcela { get; }
        public decimal ValorParcela { get; }
        public DateTime DataVencimento { get;  }
        public DateTime? DataPagamento { get; }
        public long FinanciamentoId { get; }
    }
}
