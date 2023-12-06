
namespace Domain.Entities
{
    public class FinanciamentoEntity : BaseEntity
    {

        public int MyProperty { get; set; }
        public int TipoFinanciamento { get; set; }
        public decimal ValorTotal { get; set; }
        public DateTime DataUltimoVencimento { get; set; }
        public int ClienteId { get; set; }
    }
}
