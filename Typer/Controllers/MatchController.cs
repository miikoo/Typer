using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using Typer.Logic.Commands.CreateMatchCommand;
using Typer.Logic.Commands.UpdateMatchResultCommand;

namespace Typer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MatchController : BaseTyperController
    {
        public MatchController(IMediator _mediator) : base(_mediator)
        {
        }

        [HttpPost]
        public async Task<IActionResult> CreateMatch([FromBody] CreateMatchCommand command)
            => Ok(await _mediator.Send(command));

        [HttpPut]
        public async Task<IActionResult> UpdateMatchResult([FromBody] UpdateMatchResultCommand command)
            => Ok(await _mediator.Send(command));
    }
}
