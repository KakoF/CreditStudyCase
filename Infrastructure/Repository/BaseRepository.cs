using Infrastructure.Interfaces.DataConnector;
using Dapper;
using Domain.Entities;
using Domain.Interfaces.Repository;

namespace Infrastructure.Repository
{
    public abstract class BaseRepository<T> : IBaseRepository<T> where T : BaseEntity
    {
        private readonly IDbConnector _connector;
        protected abstract string _database { get; }
        protected abstract string _selectCollumns { get; }
        public BaseRepository(IDbConnector connector)
        {
            _connector = connector;
        }

        public async Task<IEnumerable<T>> GetAsync()
        {
            return await _connector.dbConnection.QueryAsync<T>($"Select {_selectCollumns} from {_database}", _connector.dbTransaction);
        }

        public async Task<T> GetAsync(int id)
        {
            return await _connector.dbConnection.QueryFirstOrDefaultAsync<T>($"Select {_selectCollumns} from {_database} where id = @id", new { id }, _connector.dbTransaction);
        }

    }
}