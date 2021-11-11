namespace Andromeda.Adapters.DAL.Connection
{
    public class DBConnParameterModel
    {

        public DBConnParameterModel(string url, string database, string username, string password)
        {
            Url = url;
            Database = database;
            Username = username;
            Password = password;
        }

        public string Url { get; private set; }
        public string Database { get; private set; }
        public string Username { get; private set; }
        public string Password { get; private set; }

    }
}
