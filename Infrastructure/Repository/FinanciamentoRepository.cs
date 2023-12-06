using Dapper;
using Domain.Entities;
using Domain.Interfaces.Repository;
using Infrastructure.Interfaces.DataConnector;

namespace Infrastructure.Repository
{
    public class FinanciamentoRepository : BaseRepository<FinanciamentoEntity>, IFinanciamentoRepository
    {
        private readonly IDbConnector _connector;
        protected override string _database => "dbo.Financiamento";

        protected override string _selectCollumns => "Id, TipoFinanciamento, ValorTotal, DataUltimoVencimento, ClienteId";

        public FinanciamentoRepository(IDbConnector connector) : base(connector)
        {
            _connector = connector;
        }

        public async Task<FinanciamentoEntity> CreateAsync(FinanciamentoEntity financiamento)
        {
            return await _connector.dbConnection.QuerySingleAsync<FinanciamentoEntity>($"INSERT INTO {_database} (TipoFinanciamento, ValorTotal, DataUltimoVencimento, ClienteId) values (@TipoFinanciamento, @ValorTotal, @DataUltimoVencimento, @ClienteId) RETURNING *", new { financiamento.TipoFinanciamento, financiamento.ValorTotal, financiamento.DataUltimoVencimento, financiamento.ClienteId }, _connector.dbTransaction);
        }
    }
}