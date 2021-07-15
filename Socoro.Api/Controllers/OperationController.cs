using Socoro.API.Controllers;
using Socoro.Application.Features.Operations.Commands;
using Socoro.Application.Features.Operations.Queries;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Cors;

namespace Socoro.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OperationController : BaseApiController<OperationController>
    {
        [EnableCors("GET")]
        [HttpGet("{pageNumber}/{pageSize}")]
        public async Task<IActionResult> GetAll(int pageNumber, int pageSize)
        {
            var operations = await _mediator.Send(new GetAllOperations(pageNumber, pageSize));
            return Ok(operations);
        }
        [EnableCors("GET")]
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var operation = await _mediator.Send(new GetOperationById() { Id = id });
            return Ok(operation);
        }
        [EnableCors("GET")]
        [HttpGet]
        public async Task<IActionResult> GetLastOperationById(int id)
        {
            var operation = await _mediator.Send(new GetLastOperationById() { Id = id });
            return Ok(operation);
        }
        // POST api/<controller>
        [EnableCors("POST")]
        [HttpPost]
        public async Task<IActionResult> Post([FromBody]CreateOperation command)
        {
            return Ok(await _mediator.Send(command));
        }

        // PUT api/<controller>/5
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, UpdateOperation command)
        {
            if (id != command.Id)
            {
                return BadRequest();
            }
            return Ok(await _mediator.Send(command));
        }

        // DELETE api/<controller>/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            return Ok(await _mediator.Send(new DeleteOperation { Id = id }));
        }
    }
}