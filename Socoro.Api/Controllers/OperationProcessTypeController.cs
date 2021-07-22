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
        [HttpGet]
        public async Task<IActionResult> GetByTypeId(int typeId)
        {
            var operation = await _mediator.Send(new GetOperationProcessByTypeId() { TypeId = typeId });
            return Ok(operation);
        }
    }
}
