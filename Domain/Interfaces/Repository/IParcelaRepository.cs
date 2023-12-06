using Domain.Entities;

namespace Domain.Interfaces.Repository
{
    public interface IParcelaRepository : IBaseRepository<ParcelaEntity>
    {
        Task<ParcelaEntity> CreateAsync(ParcelaEntity parcela);
    }
}