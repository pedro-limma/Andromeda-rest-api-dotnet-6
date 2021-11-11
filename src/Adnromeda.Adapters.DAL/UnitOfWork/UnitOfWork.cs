using Andromeda.Adapters.DAL.Connection;
using MongoDB.Driver;

namespace Andromeda.Adapters.DAL.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly DBSession _dBSession;
        public IClientSessionHandle _session;

        public UnitOfWork(DBSession dBSession)
        {
            _dBSession = dBSession;
        }
        public IClientSessionHandle SessionManager()
        {
            _session = _dBSession.Client.StartSession();
            return _session;
        }

        public void Begin()
        {
            _session.StartTransaction();
        }

        public void Commit()
        {
            _session.CommitTransaction();
        }

        public void Rollback()
        {
            _session.AbortTransaction();
        }

        public void Dispose() => _session?.Dispose();

    }
}
