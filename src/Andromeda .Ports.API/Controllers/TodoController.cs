using Andromeda.Domain.Application.UseCases.AddTodo;
using Andromeda.Domain.Core.Models;
using Andromeda.Domain.Core.ValueObjects.IO.Input;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Andromeda_.Ports.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TodoController : ControllerBase
    {
        private readonly IUSCAddTodo _useCaseAddTodo;
        public TodoController(IUSCAddTodo usecaseaddtodo)
        {
            _useCaseAddTodo =  usecaseaddtodo;
        }

        [HttpPost]
        public IActionResult AddTodo([FromBody]TodoReq vm)
        {
            try
            {
                Todo result = _useCaseAddTodo.AddTodo(vm);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }

            
        }
    }
}
