using Socoro.API.Controllers;
using Socoro.Application.Features.OperationTypes.Queries.GetAllOperationTypes;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Cors;

namespace Socoro.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OperationTypeController : BaseApiController<OperationTypeController>
    {
        [EnableCors("GET")]
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var operationTypes = await _mediator.Send(new GetAllOperationTypesCachedQuery());
            return Ok(operationTypes);
        }

    }
}
