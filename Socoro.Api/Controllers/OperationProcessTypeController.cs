using Socoro.API.Controllers;
using Socoro.Application.Features.OperationProcessTypes.Queries;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Cors;

namespace Socoro.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OperationProcessTypeController : BaseApiController<OperationProcessTypeController>
    {
        [EnableCors("GET")]
        [HttpGet("0/{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var operation = await _mediator.Send(new GetOperationProcessTypeById() { Id = id });
            return Ok(operation);
        }
        [EnableCors("GET")]
        [HttpGet("1/{typeId}")]
        public async Task<IActionResult> GetByTypeId(int operationTypeId)
        {
            var operation = await _mediator.Send(new GetOperationProcessTypeByOperationTypeId() { OperationTypeId = operationTypeId });
            return Ok(operation);
        }
    }
}
