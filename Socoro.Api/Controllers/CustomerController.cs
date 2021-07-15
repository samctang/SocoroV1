using Socoro.API.Controllers;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Cors;
using Socoro.Application.Features.Customers.Queries;
using Socoro.Application.Features.Customers.Commands;

namespace Socoro.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : BaseApiController<CustomerController>
    {
        [EnableCors("GET")]
        [HttpGet("{id}")]
        public async Task<IActionResult> GetCustomersById(int id)
        {
            var customerList = await _mediator.Send(new GetCustomersById() { Id = id });
            return Ok(customerList);
        }
        [EnableCors("GET")]
        [HttpGet]
        public async Task<IActionResult> GetCustomersByCompanyId(int companyId)
        {
            var customerList = await _mediator.Send(new GetCustomersByCompanyId() { Id = companyId });
            return Ok(customerList);
        }
        [EnableCors("POST")]
        [HttpPost]
        public async Task<IActionResult> Post([FromBody]CreateCustomer command)
        {
            return Ok(await _mediator.Send(command));
        }
    }
}
