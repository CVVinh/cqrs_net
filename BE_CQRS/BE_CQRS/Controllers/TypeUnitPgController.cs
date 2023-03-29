using BE_CQRS.Application.Data.Queries.GetAllQuery;
using BE_CQRS.Application.Data.Queries.GetAllQuery.Postgre;
using BE_CQRS.Application.Data.Queries.GetByIdQuery;
using BE_CQRS.Application.Data.Queries.GetByIdQuery.Postgre;
using BE_CQRS.Application.DTOs.Command.CreateCommand.Postgre;
using BE_CQRS.Application.DTOs.Command.DeleteCommand;
using BE_CQRS.Application.DTOs.Command.DeleteCommand.Postgre;
using BE_CQRS.Application.DTOs.Command.UpdateCommand.Postgre;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BE_CQRS.Controllers
{
    [Route("api/TypeUnitPg")]
    [ApiController]
    public class TypeUnitPgController : ControllerBase
    {
        private readonly IMediator _mediator;

        public TypeUnitPgController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var query = new GetAllTypeUnitQuery();
            var result = await _mediator.Send(query);

            return Ok(result);
        }

        [HttpGet("GetById/{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var query = new GetByIdTypeUnitQuery(id);
            var result = await _mediator.Send(query);

            if (result == null)
            {
                return NotFound();
            }

            return Ok(result);
        }

        [HttpPost("Create")]
        public async Task<IActionResult> Create([FromBody] CreateTypeUnitCommand command)
        {
            var result = await _mediator.Send(command);

            //return CreatedAtAction(nameof(GetAll), new { id = result.Id }, result);
            return Ok(result);
        }

        [HttpPut("Update/{id}")]
        public async Task<IActionResult> Update(int id, [FromBody] UpdateTypeUnitCommand command)
        {
            if (id != command.Id)
            {
                return BadRequest();
            }

            var result = await _mediator.Send(command);

            if (result == null)
            {
                return NotFound();
            }

            return Ok(result);
        }

        [HttpDelete("Delete/{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var command = new DeleteTypeUnitCommand(id);
            var result = await _mediator.Send(command);

            if (result == null)
            {
                return NotFound();
            }

            return Ok(result);
        }



    }
}
