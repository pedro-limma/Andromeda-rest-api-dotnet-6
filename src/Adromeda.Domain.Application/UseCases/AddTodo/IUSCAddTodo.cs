using Andromeda.Domain.Core.Models;
using Andromeda.Domain.Core.ValueObjects.IO.Input;

namespace Andromeda.Domain.Application.UseCases.AddTodo
{
    public interface IUSCAddTodo
    {
        Todo AddTodo(TodoReq vm);
    }
}
