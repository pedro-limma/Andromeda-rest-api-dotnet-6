using Andromeda.Adapters.DAL.Connection.Factory;
using Andromeda.Domain.Application.Interfaces;
using Andromeda.Domain.Core.Models;
using Dapper;

namespace Andromeda.Adapters.DAL.Repository
{
    public class TodoRepository : BaseRepository, ITodoRepository
    {
        protected TodoRepository(IDatabaseFactory connection) : base(connection)
        {
        }

        public async Task<Todo> CreateTodo(Todo todo)
        {
            try
            {
                using (var connection = _connection.GetDbConnection)
                {
                    string query = $"INSERT INTO Todos OUTPUT Inserted.* VALUES(" +
                                $"'{todo.Name}'," +
                                $"{todo.Done}," +
                                $"{todo.UpdatedAt}";

                    connection.Open();
                    await connection.ExecuteAsync(query);

                    return todo; 

                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public Task DeleteById(string name)
        {
            throw new NotImplementedException();
        }

        public Task<List<Todo>> GetAllTodos()
        {
            throw new NotImplementedException();
        }

        public Task<Todo> GetById(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<Todo> UpdateTodo(Todo todo)
        {
            throw new NotImplementedException();
        }
    }
}
