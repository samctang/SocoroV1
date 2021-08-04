using Socoro.API.Controllers;
using Socoro.Application.Features.OperationContainers.Commands;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Cors;

namespace Socoro.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OperationContainerController : BaseApiController<OperationContainerController>
    {
        /*[EnableCors("GET")]
        [HttpGet("{operationId}")]
        public async Task<IActionResult> GetByOperationId(int operationContainerId)
        {
            var operation = await _mediator.Send(new GetOperationContainerByOperationId() { Id = operationContainerId });
            return Ok(operation);
        }*/
        // POST api/<controller>
        [EnableCors("POST")]
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] CreateOperationContainer command)
        {
            return Ok(await _mediator.Send(command));
        }

        // PUT api/<controller>/5
       /* [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, UpdateOperationContainer command)
        {
            if (id != command.Id)
            {
                return BadRequest();
            }
            return Ok(await _mediator.Send(command));
        }*/
    }
}