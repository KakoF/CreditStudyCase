using Domain.Abstractions;
using Domain.Enums;

namespace Domain.Models
{
    public class CreditoPessoaFisica : CreditoAbstract
    {
        protected override int Taxa => 3;
        public CreditoPessoaFisica(decimal valorCredito, int quantidadeParcelas, DateTime dataPrimeiroVencimento) : base(eTipoCredito.PessoaFisica, valorCredito, quantidadeParcelas, dataPrimeiroVencimento)
        {
        }
    }
}
