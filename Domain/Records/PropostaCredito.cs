using Domain.Enums;

namespace Domain.Records
{
    public record PropostaCredito(eTipoCredito TipoCredito, decimal ValorCredito, int QuantidadeParcelas, DateTime DataPrimeiroVencimento)
    {
    }
}
