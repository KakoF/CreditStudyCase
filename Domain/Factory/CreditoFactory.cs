using Domain.Abstractions;
using Domain.Enums;
using Domain.Interfaces.Factory;
using Domain.Models;
using Domain.Records;

namespace Domain.Factory
{
    public class CreditoFactory : ICreditoFactory
    {
        public CreditoAbstract Factory(PropostaCredito credito)
        {
            switch (credito.TipoCredito)
            {
                case eTipoCredito.Direto:
                    return new CreditoDireto(credito.Cpf, credito.Nome, credito.Celular, credito.UF, credito.ValorCredito, credito.QuantidadeParcelas, credito.DataPrimeiroVencimento);
                case eTipoCredito.Consignado:
                    return new CreditoConsignado(credito.Cpf, credito.Nome, credito.Celular, credito.UF, credito.ValorCredito, credito.QuantidadeParcelas, credito.DataPrimeiroVencimento);
                case eTipoCredito.PessoaJuridica:
                    return new CreditoPessoaJuridica(credito.Cpf, credito.Nome, credito.Celular, credito.UF, credito.ValorCredito, credito.QuantidadeParcelas, credito.DataPrimeiroVencimento);
                case eTipoCredito.PessoaFisica:
                    return new CreditoPessoaFisica(credito.Cpf, credito.Nome, credito.Celular, credito.UF, credito.ValorCredito, credito.QuantidadeParcelas, credito.DataPrimeiroVencimento);
                case eTipoCredito.Imobiliario:
                    return new CreditoImobiliario(credito.Cpf, credito.Nome, credito.Celular, credito.UF, credito.ValorCredito, credito.QuantidadeParcelas, credito.DataPrimeiroVencimento);
                default:
                    throw new InvalidOperationException("Tipo de crédito inválido.");
            }


        }
    }
}
