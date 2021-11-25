namespace Andromeda.Adapters.DAL.Settings
{
    public class DatabaseSettings : IDataBaseSettings
    {
        private string _connectionString;

        public string DefaultConnection { get => _connectionString; }

        public DatabaseSettings(string connectionString)
        {
            _connectionString = connectionString;
        }

    }
}
