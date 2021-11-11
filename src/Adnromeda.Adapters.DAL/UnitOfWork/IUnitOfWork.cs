using MongoDB.Driver;

namespace Andromeda.Adapters.DAL.UnitOfWork
{
    public interface IUnitOfWork : IDisposable
    {
        IClientSessionHandle SessionManager();
        void Begin();
        void Commit();
        void Rollback();
    }
}
