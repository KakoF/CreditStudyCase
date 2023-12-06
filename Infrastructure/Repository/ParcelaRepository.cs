using Domain.Entities;
using Domain.Interfaces.Repository;
using Infrastructure.Interfaces.DataConnector;

namespace Infrastructure.Repository
{
    public class ParcelaRepository : BaseRepository<ParcelaEntity>, IParcelaRepository
    {
        protected override string _database => "dbo.Parcela";

        protected override string _selectCollumns => "Id, NumeroParcela, ValorParcela, DataVencimento, DataPagamento, FinanciamentoId";

        public ParcelaRepository(IDbConnector connector) : base(connector)
        {
        }
    }
}