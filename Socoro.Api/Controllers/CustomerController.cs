using Socoro.API.Controllers;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Cors;
using Socoro.Application.Features.Customers.Queries.GetByCompanyId;
using Socoro.Application.Features.Customers.Commands.Create;

namespace Socoro.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : BaseApiController<CustomerController>
    {
        [EnableCors("GET")]
        [HttpGet]
        public async Task<IActionResult> GetCustomersByCompanyId(int companyId)
        {
            var customerList = await _mediator.Send(new GetCustomersByCompanyIdQuery() { CompanyId = companyId });
            return Ok(customerList);
        }
        [EnableCors("POST")]
        [HttpPost]
        public async Task<IActionResult> Post([FromBody]CreateCustomerCommand command)
        {
            return Ok(await _mediator.Send(command));
        }
    }
}
