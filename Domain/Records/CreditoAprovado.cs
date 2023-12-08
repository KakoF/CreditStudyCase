using Newtonsoft.Json;

namespace Domain.Records
{
    public record CreditoAprovado([property: JsonProperty("status_credito")] StatusCredito statusCredito, [property: JsonProperty("valor_total_com_juros")] decimal valorTotalComJuros, [property: JsonProperty("valor_juros")] decimal valorJuros)
    {
    }
}
