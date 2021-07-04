using Socoro.API.Controllers;
using Socoro.Application.Features.Operations.Commands.Create;
using Socoro.Application.Features.Operations.Commands.Delete;
using Socoro.Application.Features.Operations.Commands.Update;
using Socoro.Application.Features.Operations.Queries.GetAllPaged;
using Socoro.Application.Features.Operations.Queries.GetById;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Socoro.Api.Controllers.v1
{
    public class OperationController : BaseApiController<OperationController>
    {
        [HttpGet]
        public async Task<IActionResult> GetAll(int pageNumber, int pageSize)
        {
            var operations = await _mediator.Send(new GetAllOperationsQuery(pageNumber, pageSize));
            return Ok(operations);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var operation = await _mediator.Send(new GetOperationByIdQuery() { Id = id });
            return Ok(operation);
        }

        // POST api/<controller>
        [HttpPost]
        public async Task<IActionResult> Post(CreateOperationCommand command)
        {
            return Ok(await _mediator.Send(command));
        }

        // PUT api/<controller>/5
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, UpdateOperationCommand command)
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
            return Ok(await _mediator.Send(new DeleteOperationCommand { Id = id }));
        }
    }
}