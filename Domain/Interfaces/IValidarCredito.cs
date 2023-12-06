using Domain.Abstractions;
using Domain.Records;

namespace Domain.Interfaces
{
    public interface IValidarCredito
    {
        public void ViabilizarLiberacao();

        public CreditoAprovado CalcularCredito();
    }
}
