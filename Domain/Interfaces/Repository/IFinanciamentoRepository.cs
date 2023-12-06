using Domain.Entities;

namespace Domain.Interfaces.Repository
{
    public interface IFinanciamentoRepository : IBaseRepository<FinanciamentoEntity>
    {
        Task<FinanciamentoEntity> CreateAsync(FinanciamentoEntity financiamento);
    }
}