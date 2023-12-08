using Domain.Abstractions;
using Domain.Enums;

namespace Domain.Models
{
    public class CreditoPessoaFisica : CreditoAbstract
    {
        protected override int Taxa => 3;
        public CreditoPessoaFisica(string cpf, string nome, string celular, string uf, decimal valorCredito, int quantidadeParcelas, DateTime dataPrimeiroVencimento) : base(cpf, nome, celular, uf, eTipoCredito.PessoaFisica, valorCredito, quantidadeParcelas, dataPrimeiroVencimento)
        {
        }
    }
}
