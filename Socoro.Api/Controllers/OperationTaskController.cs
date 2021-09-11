using Socoro.API.Controllers;
using Socoro.Application.Features.OperationTasks.Commands;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Cors;
using Socoro.Application.Features.OperationTasks.Queries;

namespace Socoro.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    //NEED TO CHANGE
    public class OperationTaskController : BaseApiController<OperationTaskController>
    {
        [EnableCors("GET")]
        [HttpGet("{pageNo}/{pageSize}")]
        public async Task<IActionResult> GetAllAsync(int pageNo, int pageSize)
        {
            var operation = await _mediator.Send(new GetAllOperationTasks(pageNo, pageSize));
            return Ok(operation);
        }
        [EnableCors("GET")]
        [HttpGet("{operationProcessId}")]
        public async Task<IActionResult> GetAllByIdAsync(int operationProcessId)
        {
            var operation = await _mediator.Send(new GetAllByOperationProcessId() { OperationProcessId = operationProcessId });
            return Ok(operation);
        }
        // POST api/<controller>
        [EnableCors("POST")]
        [HttpPost]
        public async Task<IActionResult> CreateTask([FromBody]CreateOperationTask command)
        {
            return Ok(await _mediator.Send(command));
        }

        // PUT api/<controller>/5
        [EnableCors("PUT")]
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, [FromBody]UpdateOperationTask command)
        {
            if (id != command.Id)
            {
                return BadRequest();
            }
            return Ok(await _mediator.Send(command));
        }
    }
}