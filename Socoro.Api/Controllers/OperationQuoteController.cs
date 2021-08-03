using Socoro.API.Controllers;
using Socoro.Application.Features.OperationQuotes.Commands;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Cors;

namespace Socoro.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OperationQuoteController : BaseApiController<OperationQuoteController>
    {
        /*[EnableCors("GET")]
        [HttpGet("{operationId}")]
        public async Task<IActionResult> GetByOperationId(int operationId)
        {
            var operation = await _mediator.Send(new GetOperationQuoteByOperationId() { OperationId = operationId });
            return Ok(operation);
        }*/
        // POST api/<controller>
        [EnableCors("POST")]
        [HttpPost]
        public async Task<IActionResult> Post([FromBody]CreateOperationQuote command)
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