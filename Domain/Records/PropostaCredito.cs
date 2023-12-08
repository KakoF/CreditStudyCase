using Domain.Enums;
using Newtonsoft.Json;
using System.Text.Json.Serialization;

namespace Domain.Records
{
    public record PropostaCredito(
        string Cpf, 
        string Nome,
        [property: JsonProperty("uf"), JsonPropertyName("uf")] string UF, 
        string Celular,
        [property: JsonProperty("tipo_credito"), JsonPropertyName("tipo_credito")] eTipoCredito TipoCredito,
        [property: JsonProperty("valor_credito"), JsonPropertyName("valor_credito")] decimal ValorCredito,
        [property: JsonProperty("quantidade_parcelas"), JsonPropertyName("quantidade_parcelas")] int QuantidadeParcelas,
        [property: JsonProperty("data_primeiro_vencimento"), JsonPropertyName("data_primeiro_vencimento")] DateTime DataPrimeiroVencimento)
    {
    }
}
