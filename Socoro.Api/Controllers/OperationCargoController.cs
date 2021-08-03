﻿using Socoro.API.Controllers;
using Socoro.Application.Features.OperationCargos.Commands;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Cors;

namespace Socoro.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OperationCargoController : BaseApiController<OperationCargoController>
    {
        /*[EnableCors("GET")]
        [HttpGet("{operationId}")]
        public async Task<IActionResult> GetByOperationId(int operationId)
        {
            var operation = await _mediator.Send(new GetOperationCargoByOperationId() { OperationId = operationId });
            return Ok(operation);
        }*/
        // POST api/<controller>
        [EnableCors("POST")]
        [HttpPost]
        public async Task<IActionResult> Post([FromBody]CreateOperationCargo command)
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