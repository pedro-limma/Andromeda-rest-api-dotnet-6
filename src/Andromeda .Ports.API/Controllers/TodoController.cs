using Andromeda.Domain.Application.UseCases;
using Andromeda.Domain.Core.Models;
using Andromeda.Domain.Core.ValueObjects.IO.Input;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Andromeda_.Ports.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Produces("application/json")]
    public class TodoController : ControllerBase
    {
        private readonly IUSCTodo _uscTodo;
        public TodoController(IUSCTodo uscTodo)
        {
            _uscTodo = uscTodo;
        }

        [HttpPost("AddTodo")]
        public IActionResult AddTodo([FromBody]TodoReq vm)
        {
            try
            {
                return Ok(_uscTodo.AddTodo(vm));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("GetTodos")]
        public IActionResult GetTodos()
        {
            try
            {
                var result = _uscTodo.GetTodos();

                if (result is null)
                    return NotFound("Nenhum Todo Encontrado");
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut("UpdateTodo")]
        public IActionResult UpdateTodo([FromBody]TodoReq vm)
        {
            try
            {
                return Ok(_uscTodo.UpdateTodo(vm));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpDelete("DeleteTodo")]
        public IActionResult DeleteTodo([FromBody]TodoReq vm)
        {
            try
            {
                _uscTodo.DeleteTodo(vm);
                return Ok($"Todo:{vm.Name}, deletado com sucesso");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
