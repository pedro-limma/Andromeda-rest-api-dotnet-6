using Andromeda.Domain.Application.Interfaces;
using Andromeda.Domain.Application.Mapping;
using Andromeda.Domain.Core.Models;
using Andromeda.Domain.Core.ValueObjects.IO.Input;

namespace Andromeda.Domain.Application.UseCases
{
    public class USCTodo : IUSCTodo
    {
        protected readonly ITodoRepository _todoRepo;
        protected readonly IMappingHandler _mapping;

        public USCTodo(ITodoRepository todoRepo, IMappingHandler mapping)
        {
            _todoRepo = todoRepo;
            _mapping = mapping;
        }

        public Todo AddTodo(TodoReq vm) => _todoRepo.CreateTodo(_mapping.HandleTodo(vm));

        public string GetTodos() => _todoRepo.GetAllTodos();

        public Todo UpdateTodo(TodoReq vm) => _todoRepo.UpdateTodo(_mapping.HandleTodo(vm));

        public void DeleteTodo(TodoReq vm) => _todoRepo.DeleteTodo(_mapping.HandleTodo(vm));
    }
}
