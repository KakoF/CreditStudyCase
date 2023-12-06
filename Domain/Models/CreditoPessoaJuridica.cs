using Domain.Abstractions;
using Domain.Enums;

namespace Domain.Models
{
    public class CreditoPessoaJuridica : CreditoAbstract
    {
        protected override int Taxa => 5;
        public CreditoPessoaJuridica(decimal valorCredito, int quantidadeParcelas, DateTime dataPrimeiroVencimento) : base(eTipoCredito.PessoaJuridica, valorCredito, quantidadeParcelas, dataPrimeiroVencimento)
        {
        }

        public override void ViabilizarLiberacao()
        {
            ValorCreditoMinimoAceitavel();
            base.ViabilizarLiberacao();

        }

        private void ValorCreditoMinimoAceitavel()
        {
            if (ValorCredito < 15000)
                throw new ArgumentException("Valor minimo não aceitavel");
        }
    }
}
