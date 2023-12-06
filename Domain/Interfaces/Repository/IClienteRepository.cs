using Domain.Entities;

namespace Domain.Interfaces.Repository
{
    public interface IClienteRepository: IBaseRepository<ClienteEntity>
    {
       Task<ClienteEntity> CreateAsync(ClienteEntity cliente);
    }
}