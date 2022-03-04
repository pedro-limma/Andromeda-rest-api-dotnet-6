using Andromeda.Domain.Core.Models;
using Andromeda.Domain.Core.ValueObjects.IO.Input;

namespace Andromeda.Domain.Application.UseCases
{
    public interface IUSCTodo
    {
        Todo AddTodo(TodoReq vm);
        Todo UpdateTodo(TodoReq vm);
        string GetTodos();
        void DeleteTodo(TodoReq vm);
    }
}
