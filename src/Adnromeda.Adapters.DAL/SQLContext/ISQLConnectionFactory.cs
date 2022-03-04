using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Andromeda.Adapters.DAL.SQLContext
{
    public interface ISQLConnectionFactory
    {
        IDbConnection Connection { get; }
    }

}
