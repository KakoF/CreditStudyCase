using Domain.Abstractions;
using Domain.Enums;

namespace Domain.Models
{
    public class CreditoImobiliario : CreditoAbstract
    {
        protected override int Taxa => 9;
        public CreditoImobiliario(decimal valorCredito, int quantidadeParcelas, DateTime dataPrimeiroVencimento) : base(eTipoCredito.Imobiliario, valorCredito, quantidadeParcelas, dataPrimeiroVencimento)
        {
        }
    }
}
