using Andromeda.Domain.Core.Models;

namespace Andromeda.Domain.Application.Interfaces
{
    public interface ITodoRepository
    {
        Task<Todo> CreateTodo(Todo todo);
        Task<Todo> UpdateTodo(Todo todo);
        Task DeleteById(string name);
        Task<List<Todo>> GetAllTodos();
        Task<Todo> GetById(Guid id);
    }
}
