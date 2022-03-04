using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Andromeda.Adapters.DAL.SQLContext
{
    public class SQLConnectionFactory : ISQLConnectionFactory
    {
        public Dictionary<string, Connection> Clusts { get; set; }
        public IDbConnection Connection => new SqlConnection(_connectionString);

        private readonly string _connectionString;

        public SQLConnectionFactory(string connectionString)
        {
            _connectionString = connectionString;
        }


    }

    public class Connection
    {
        public string Server { get; set; }
        public string Database { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }

        public string ConnectionString
        {
            get
            {
                return $"Data Source={Server};Initial Catalog={Database};Persist Security Info=True;User ID={Username};Password={Password}";
            }
        }
    }

}
