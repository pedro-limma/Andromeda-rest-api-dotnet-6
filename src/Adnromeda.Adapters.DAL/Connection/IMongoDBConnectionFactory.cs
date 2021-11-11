using MongoDB.Driver;

namespace Andromeda.Adapters.DAL.Connection
{
    public interface IMongoDBConnectionFactory
    {
        public IMongoDatabase Connection();
        public MongoClient Client();
    }
}
