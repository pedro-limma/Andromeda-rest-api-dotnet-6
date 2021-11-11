using MongoDB.Driver;

namespace Andromeda.Adapters.DAL.Connection
{
    public sealed class DBSession
    {
        public Guid Id { get; set; }
        public IMongoDatabase Connection { get; set; }
        public MongoClient Client { get; set; }

        public DBSession(IMongoDBConnectionFactory connectionFactory)
        {
            Id = Guid.NewGuid();
            Connection = connectionFactory.Connection();
            Client = connectionFactory.Client();
        }
    }
}
