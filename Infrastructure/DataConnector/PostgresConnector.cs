using Infrastructure.Interfaces.DataConnector;
using Npgsql;
using System.Data;

namespace Infrastructure.DataConnector
{
    public class PostgresConnector : IDbConnector
    {
        public PostgresConnector(string connectionString)
        {
            dbConnection = new NpgsqlConnection();
            dbConnection.ConnectionString = connectionString;
            dbConnection.Open();
        }

        public IDbConnection dbConnection { get; }

        public IDbTransaction dbTransaction { get; set; }

        public IDbTransaction BeginTransaction(IsolationLevel isolation)
        {
            if (dbTransaction != null)
            {
                return dbTransaction;
            }

            if (dbConnection.State == ConnectionState.Closed)
            {
                dbConnection.Open();
            }

            return (dbTransaction = dbConnection.BeginTransaction(isolation));
        }

        public void Dispose()
        {
            dbTransaction?.Dispose();
            dbConnection?.Dispose();
            GC.SuppressFinalize(this);
        }
    }
}