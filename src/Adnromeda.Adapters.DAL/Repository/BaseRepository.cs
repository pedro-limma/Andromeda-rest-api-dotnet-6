using Andromeda.Adapters.DAL.Connection.Factory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Andromeda.Adapters.DAL.Repository
{
    public class BaseRepository : IBaseRepository
    {

        protected readonly IDatabaseFactory _connection;

        public BaseRepository(IDatabaseFactory connection)
        {
            _connection =  connection;
        }


        public void Dispose()
        {
            
        }
    }
}
