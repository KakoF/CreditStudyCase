using Domain.Abstractions;
using Domain.Enums;

namespace Domain.Models
{
    public class CreditoConsignado : CreditoAbstract
    {
        protected override int Taxa => 1;

        public CreditoConsignado(string cpf, string nome, string celular, string uf, decimal valorCredito, int quantidadeParcelas, DateTime dataPrimeiroVencimento) : base(cpf, nome, celular, uf, eTipoCredito.Consignado, valorCredito, quantidadeParcelas, dataPrimeiroVencimento)
        {
        }
       
    }
}
