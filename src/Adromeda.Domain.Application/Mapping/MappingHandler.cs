using Andromeda.Domain.Core.Models;
using Andromeda.Domain.Core.ValueObjects.IO.Input;

namespace Andromeda.Domain.Application.Mapping
{
    public class MappingHandler : IMappingHandler
    {
        public Todo HandleTodo(TodoReq todo)
        {
            return new Todo(name: todo.Name);
        }
    }
}
