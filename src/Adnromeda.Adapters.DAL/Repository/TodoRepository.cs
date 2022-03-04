using Andromeda.Adapters.DAL.SQLContext;
using Andromeda.Domain.Application.Interfaces;
using Andromeda.Domain.Core.Models;
using Dapper;
using System.Data;
using System.Globalization;
using System.Text.Json;

namespace Andromeda.Adapters.DAL.Repository
{
    public class TodoRepository : BaseRepository, ITodoRepository
    {
        public TodoRepository(ISQLConnectionFactory connection) : base(connection) { }

        public Todo CreateTodo(Todo todo)
        {
            try
            {
                using (IDbConnection connection = _connection.Connection)
                {
                    string query = $"INSERT INTO Todos VALUES('{todo.Name}',{(todo.Done ? 1 : 0)},'{todo.UpdatedAt}')";

                    connection.Open();
                    connection.Execute(query, todo);

                    return todo;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public string GetAllTodos()
        {
            try
            {
                using (IDbConnection connection = _connection.Connection)
                {
                    connection.Open();

                    return JsonSerializer.Serialize(connection.Query("SELECT * FROM Todos"));

                }
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public Todo UpdateTodo(Todo todo)
        {
            try
            {
                using (IDbConnection connection = _connection.Connection)
                {
                    connection.Open();

                    string query = $"UPDATE Todos SET IsDone = {(todo.Done ? 1 : 0)}, UpdatedAt = '{DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")}' WHERE Name='{todo.Name}'";
                    connection.Execute(query, todo);

                    return todo;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }

        public void DeleteTodo(Todo todo)
        {
            try
            {
                using (IDbConnection connection = _connection.Connection)
                {
                    connection.Open();

                    string query = $"DELETE FROM Todos WHERE Name='{todo.Name}'";

                    connection.Execute(query, todo);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
