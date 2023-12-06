using Domain.Enums;

namespace Domain.Records
{
    public record PropostaCredito(string Cpf, string Nome, string UF, string Celular, eTipoCredito TipoCredito, decimal ValorCredito, int QuantidadeParcelas, DateTime DataPrimeiroVencimento)
    {
    }
}
