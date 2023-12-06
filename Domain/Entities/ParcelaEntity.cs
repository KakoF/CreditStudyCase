
namespace Domain.Entities
{
    public class ParcelaEntity : BaseEntity
    {
        public int NumeroParcela { get; set; }
        public decimal ValorParcela { get; set; }
        public DateTime DataVencimento { get; set; }
        public DateTime DataPagamento { get; set; }
        public int FinanciamentoId { get; set; }
    }
}
