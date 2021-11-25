using Andromeda.Domain.Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Andromeda.Domain.Application.UseCases
{
    public abstract class BaseUseCase<T> where T : class
    {
        protected readonly ITodoRepository _repository;

        public BaseUseCase(ITodoRepository repository)
        {
            _repository = repository;
        }
    }
}
