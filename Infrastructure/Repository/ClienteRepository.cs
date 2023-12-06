using Domain.Entities;
using Domain.Interfaces.Repository;
using Infrastructure.Interfaces.DataConnector;

namespace Infrastructure.Repository
{
    public class ClienteRepository : BaseRepository<ClienteEntity>, IClienteRepository
    {
        protected override string _database => "dbo.Cliente";

        protected override string _selectCollumns => "Id, CPF, Nome, UF, Celular";

        public ClienteRepository(IDbConnector connector) : base(connector)
        {
        }
    }
}