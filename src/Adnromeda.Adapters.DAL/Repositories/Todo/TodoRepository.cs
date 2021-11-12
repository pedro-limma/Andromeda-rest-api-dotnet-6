using Andromeda.Adapters.DAL.Connection;
using Andromeda.Adapters.DAL.UnitOfWork;
using Andromeda.Domain.Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Andromeda.Adapters.DAL.Repositories.Todo
{
    public class TodoRepository : ITodoRepository
    {
        private DBSession _dBsession;
        private IUnitOfWork _unit;

        public TodoRepository(DBSession dBSession, IUnitOfWork unit)
        {
            _dBsession = dBSession;
            _unit = unit;
        }


    }
}
