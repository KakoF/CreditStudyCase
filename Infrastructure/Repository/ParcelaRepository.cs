using Dapper;
using Domain.Entities;
using Domain.Interfaces.Repository;
using Infrastructure.Interfaces.DataConnector;

namespace Infrastructure.Repository
{
    public class ParcelaRepository : BaseRepository<ParcelaEntity>, IParcelaRepository
    {
        private readonly IDbConnector _connector;
        protected override string _database => "dbo.Parcela";

        protected override string _selectCollumns => "Id, NumeroParcela, ValorParcela, DataVencimento, DataPagamento, FinanciamentoId";

        public ParcelaRepository(IDbConnector connector) : base(connector)
        {
            _connector = connector;
        }

        public async Task<ParcelaEntity> CreateAsync(ParcelaEntity parcela)
        {
            return await _connector.dbConnection.QuerySingleAsync<ParcelaEntity>($"INSERT INTO {_database} (NumeroParcela, ValorParcela, DataVencimento, DataPagamento, FinanciamentoId) values (@NumeroParcela, @ValorParcela, @DataVencimento, @DataPagamento, @FinanciamentoId) RETURNING *", new { parcela.NumeroParcela, parcela.ValorParcela, parcela.DataVencimento, parcela.DataPagamento, parcela.FinanciamentoId }, _connector.dbTransaction);
        }
    }
}