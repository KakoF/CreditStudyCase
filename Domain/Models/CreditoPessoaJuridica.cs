using Domain.Abstractions;
using Domain.Enums;

namespace Domain.Models
{
    public class CreditoPessoaJuridica : CreditoAbstract
    {
        protected override int Taxa => 5;
        public CreditoPessoaJuridica(string cpf, string nome, string celular, string uf, decimal valorCredito, int quantidadeParcelas, DateTime dataPrimeiroVencimento) : base(cpf, nome, celular, uf, eTipoCredito.PessoaJuridica, valorCredito, quantidadeParcelas, dataPrimeiroVencimento)
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
