using Domain.Enums;
using Domain.Interfaces;
using Domain.Records;

namespace Domain.Abstractions
{
    public abstract class CreditoAbstract : IValidarCredito
    {
        protected abstract int Taxa { get; }
        public eTipoCredito TipoCredito { get; }
        public decimal ValorCredito { get; set; }
        public int QuantidadeParcelas { get; set; }
        public DateTime DataPrimeiroVencimento { get; set; }

        protected CreditoAbstract(eTipoCredito tipoCredito, decimal valorCredito, int quantidadeParcelas, DateTime dataPrimeiroVencimento)
        {
            TipoCredito = tipoCredito;
            ValorCredito = valorCredito;
            QuantidadeParcelas = quantidadeParcelas;
            DataPrimeiroVencimento = dataPrimeiroVencimento;
        }

        public virtual void ViabilizarLiberacao()
        {
            ValorCreditoAceitaval();
            QuantidadeParcelasAceitavel();
            DataPrimeiroVencimentoAceitavel();
        }

        public CreditoAprovado CalcularCredito()
        {
            var juros = ValorCredito * (Taxa / 100M);
            var valorTotal = ValorCredito + juros;
            return new CreditoAprovado(new StatusCredito(true, $"Crédito {TipoCredito} Aprovado"), valorTotal, juros);

        }

        private void ValorCreditoAceitaval ()
        {
            if (ValorCredito > 1000000)
                throw new ArgumentException("Valor não aceitavel");
        }

        private void QuantidadeParcelasAceitavel()
        {
            if (QuantidadeParcelas < 5 || QuantidadeParcelas > 72)
                throw new ArgumentException("Quantidade de parcelas não aceitavel");
        }

        private void DataPrimeiroVencimentoAceitavel()
        {
            if (DataPrimeiroVencimento < DateTime.Now.AddDays(15) || DataPrimeiroVencimento > DateTime.Now.AddDays(40))
                throw new ArgumentException("Data de vencimento não aceitavel");
        }
    }
}
