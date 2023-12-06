using Domain.Entities;
using Domain.Interfaces.Repository;
using Infrastructure.Interfaces.DataConnector;

namespace Infrastructure.Repository
{
    public class FinanciamentoRepository : BaseRepository<FinanciamentoEntity>, IFinanciamentoRepository
    {
        protected override string _database => "dbo.Financiamento";

        protected override string _selectCollumns => "Id, TipoFinanciamento, ValorTotal, DataUltimoVencimento, ClienteId";

        public FinanciamentoRepository(IDbConnector connector) : base(connector)
        {
        }
    }
}