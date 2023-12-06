using Domain.Abstractions;
using Domain.Enums;

namespace Domain.Models
{
    public class CreditoDireto : CreditoAbstract
    {
        protected override int Taxa => 2;
        public CreditoDireto(decimal valorCredito, int quantidadeParcelas, DateTime dataPrimeiroVencimento) : base(eTipoCredito.Direto, valorCredito, quantidadeParcelas, dataPrimeiroVencimento)
        {
        }
    }
}
