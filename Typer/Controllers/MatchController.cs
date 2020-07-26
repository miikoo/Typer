using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using Typer.Logic.Commands.CreateMatchCommand;
using Typer.Logic.Commands.UpdateMatchResultCommand;
using Typer.Logic.Queries.Matches.GetMatchesByGameweekId;

namespace Typer.Controllers
{
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

        [HttpGet]
        public async Task<IActionResult> GetMatchesByGameweekId([FromQuery] GetMatchesByGameweekIdQuery query)
            => Ok(await _mediator.Send(query));
    }
}
