using Domain.Entities;
using Domain.Interfaces.Repository;
using Infrastructure.Interfaces.DataConnector;
using static Dapper.SqlMapper;

namespace Infrastructure.Repository
{
    public class ClienteRepository : BaseRepository<ClienteEntity>, IClienteRepository
    {
        private readonly IDbConnector _connector;

        protected override string _database => "dbo.Cliente";

        protected override string _selectCollumns => "Id, CPF, Nome, UF, Celular";

        public ClienteRepository(IDbConnector connector) : base(connector)
        {
            _connector = connector;
        }

        public async Task<ClienteEntity> CreateAsync(ClienteEntity cliente)
        {
            return await _connector.dbConnection.QuerySingleAsync<ClienteEntity>($"INSERT INTO {_database} (CPF, Nome, UF, Celular) values (@CPF, @Nome, @UF, @Celular) RETURNING *", new { cliente.Cpf, cliente.Nome, cliente.UF, cliente.Celular }, _connector.dbTransaction);
        }
    }
}