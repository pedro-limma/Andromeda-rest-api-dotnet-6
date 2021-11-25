using System.Data;

namespace Andromeda.Adapters.DAL.Connection.Factory
{
    public interface IDatabaseFactory
    {
        public IDbConnection GetDbConnection { get; }
    }
}
