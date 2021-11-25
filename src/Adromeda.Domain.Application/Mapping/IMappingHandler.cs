using Andromeda.Domain.Core.Models;
using Andromeda.Domain.Core.ValueObjects.IO.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Andromeda.Domain.Application.Mapping
{
    public interface IMappingHandler
    {
        public Todo HandleTodo(TodoReq todo);

    }
}
