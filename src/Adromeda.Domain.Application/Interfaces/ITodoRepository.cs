using Andromeda.Domain.Core.Models;

namespace Andromeda.Domain.Application.Interfaces
{
    public interface ITodoRepository
    {
        Todo CreateTodo(Todo todo);
        string GetAllTodos();
        Todo UpdateTodo(Todo todo);
        void DeleteTodo(Todo todo);
    }
}
