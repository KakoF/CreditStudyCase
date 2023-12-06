using Domain.Abstractions;
using Domain.Enums;

namespace Domain.Models
{
    public class CreditoConsignado : CreditoAbstract
    {
        protected override int Taxa => 1;

        public CreditoConsignado(decimal valorCredito, int quantidadeParcelas, DateTime dataPrimeiroVencimento) : base(eTipoCredito.Consignado, valorCredito, quantidadeParcelas, dataPrimeiroVencimento)
        {
        }
       
    }
}
