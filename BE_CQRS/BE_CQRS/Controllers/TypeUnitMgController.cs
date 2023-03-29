using BE_CQRS.Application.DTOs.Command.CreateCommand.Mongo;
using BE_CQRS.Repository.RepositotyMongo;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BE_CQRS.Controllers
{
    [Route("api/TypeUnitPg")]
    [ApiController]
    public class TypeUnitMgController : ControllerBase
    {
        private readonly IMediator _mediator;
        public TypeUnitMgController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost("Create")]
        public async Task<IActionResult> Create([FromBody] CreateTypeUnitCommand command)
        {
            //var result = await _mediator.Send(command);

            //return Ok(result);
            return Ok();
        }


    }
}
