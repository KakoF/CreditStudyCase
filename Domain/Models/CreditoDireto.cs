using Domain.Abstractions;
using Domain.Enums;

namespace Domain.Models
{
    public class CreditoDireto : CreditoAbstract
    {
        protected override int Taxa => 2;
        public CreditoDireto(string cpf, string nome, string celular, string uf, decimal valorCredito, int quantidadeParcelas, DateTime dataPrimeiroVencimento) : base(cpf, nome, celular, uf, eTipoCredito.Direto, valorCredito, quantidadeParcelas, dataPrimeiroVencimento)
        {
        }
    }
}
