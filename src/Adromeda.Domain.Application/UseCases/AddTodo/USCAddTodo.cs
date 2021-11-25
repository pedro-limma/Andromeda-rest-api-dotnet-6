using Andromeda.Domain.Application.Interfaces;
using Andromeda.Domain.Application.Mapping;
using Andromeda.Domain.Core.Models;
using Andromeda.Domain.Core.ValueObjects.IO.Input;

namespace Andromeda.Domain.Application.UseCases.AddTodo
{
    public class USCAddTodo: BaseUseCase<USCAddTodo> ,IUSCAddTodo
    {

        private readonly IMappingHandler _mapping;
        public USCAddTodo(ITodoRepository repository, IMappingHandler mapping) : base(repository) 
        {
            _mapping = mapping;
        }

        public Todo AddTodo(TodoReq vm)
        {
            Todo todo = _mapping.HandleTodo(vm);

            var result = _repository.CreateTodo(todo).Result;
            return result;
        }
    }
}
