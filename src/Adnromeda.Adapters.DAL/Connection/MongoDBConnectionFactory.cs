using MongoDB.Driver;

namespace Andromeda.Adapters.DAL.Connection
{
    public class MongoDBConnectionFactory : IMongoDBConnectionFactory
    {
        private readonly DBConnParameterModel _model;
        private readonly MongoClient _session;

        public MongoDBConnectionFactory(DBConnParameterModel model)
        {
            _model = model;
            _session = new MongoClient(GetConnectionString());
        }

        public IMongoDatabase Connection()
        {
            return _session.GetDatabase(_model.Database);
        }

        public MongoClient Client()
        {
            return _session;
        }

        private string GetConnectionString()
        {
            return $"mongodb://{_model.Url}/?authSource=admin";
        }
    }
}
