using Andromeda.Adapters.DAL.SQLContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Andromeda.Adapters.DAL.Repository
{
    public abstract class BaseRepository
    {

        protected readonly ISQLConnectionFactory _connection;

        public BaseRepository(ISQLConnectionFactory connection)
        {
            _connection =  connection;
        }

    }
}
