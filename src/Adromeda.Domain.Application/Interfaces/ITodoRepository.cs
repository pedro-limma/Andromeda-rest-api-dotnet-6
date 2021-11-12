using Andromeda.Domain.Core.Models;

namespace Andromeda.Domain.Application.Interfaces
{
    public interface ITodoRepository
    {
        Todo CreateTodo(Todo todo);
        Todo UpdateTodo(Todo todo);
        void DeleteById(int id);
        List<Todo> GetAllTodos();
        Todo GetById(int id);
    }
}
