using Andromeda.Adapters.DAL.Settings;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Andromeda.Adapters.DAL.Connection.Factory
{
    public class DatabaseFactory : IDatabaseFactory
    {
        private DatabaseSettings _dataSettings;
        protected string ConnectionString => _dataSettings.DefaultConnection;

        public IDbConnection GetDbConnection => new SqlConnection(ConnectionString);

        public DatabaseFactory(IConfiguration configuration)
        {
            _dataSettings = new DatabaseSettings(configuration.GetConnectionString("DefaultConnection"));
        }

    }
}
