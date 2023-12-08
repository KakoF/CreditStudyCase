using Domain.Abstractions;
using Domain.Enums;

namespace Domain.Models
{
    public class CreditoImobiliario : CreditoAbstract
    {
        protected override int Taxa => 9;
        public CreditoImobiliario(string cpf, string nome, string celular, string uf, decimal valorCredito, int quantidadeParcelas, DateTime dataPrimeiroVencimento) : base(cpf, nome, celular, uf, eTipoCredito.Imobiliario, valorCredito, quantidadeParcelas, dataPrimeiroVencimento)
        {
        }
    }
}
