using Socoro.API.Controllers;
using Socoro.Application.Features.OperationProcesses.Commands;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Cors;
using Socoro.Application.Features.OperationProcesses.Queries;

namespace Socoro.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OperationProcessController : BaseApiController<OperationProcessController>
    {
        [EnableCors("GET")]
        [HttpGet("{operationId}")]
        public async Task<IActionResult> GetByOperationId(int operationId)
        {
            var operation = await _mediator.Send(new GetOperationProcessByOperationId() { OperationId = operationId });
            return Ok(operation);
        }
        [EnableCors("GET")]
        [HttpGet("{operationId}/{typeId}")]
        public async Task<IActionResult> GetIdByOperationIdAndTypeId(int operationId, int typeId)
        {
            var operation = await _mediator.Send(new GetIdByOperationIdAndTypeId() { OperationId = operationId, TypeId = typeId });
            return Ok(operation);
        }
        // POST api/<controller>
        [EnableCors("POST")]
        [HttpPost]
        public async Task<IActionResult> Post([FromBody]CreateOperationProcess command)
        {
            return Ok(await _mediator.Send(command));
        }

        // PUT api/<controller>/5
       /* [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, UpdateOperation command)
        {
            if (id != command.Id)
            {
                return BadRequest();
            }
            return Ok(await _mediator.Send(command));
        }*/
    }
}