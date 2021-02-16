using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;
using Typer.Application.Commands.Gameweeks.CreateGameweek;
using Typer.Application.Commands.Gameweeks.DeleteGameweek;
using Typer.Application.Commands.Gameweeks.UpdateGameweek;
using Typer.Application.Queries.Gameweeks.GetCurrentSeasonGameweeks;
using Typer.Application.Queries.Gameweeks.GetGameweeksBySeasonId;

namespace Typer.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GameweekController : ControllerBase
    {
        private readonly IMediator _mediator;

        public GameweekController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [Authorize(Roles = "Admin")]
        [HttpPost]
        public async Task<IActionResult> CreateGameweek([FromBody]CreateGameweekCommand command)
        {
            var id = await _mediator.Send(command);
            return Ok(id.GameweekId);
        }

        [Authorize(Roles = "Admin")]
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteGameweek([FromRoute] Guid id)
            => Ok(await _mediator.Send(new DeleteGameweekCommand
            {
                GameweekId = id
            }));

        [Authorize(Roles = "Admin")]
        [HttpPut]
        public async Task<IActionResult> UpdateGameweek([FromBody] UpdateGameweekCommand command)
            => Ok(await _mediator.Send(command));

        [Authorize]
        [HttpGet("getCurrentSeasonGameweeks")]
        public async Task<IActionResult> GetCurrentSeasonGameweeks()
            => Ok(await _mediator.Send(new GetCurrentSeasonGameweeksQuery { }));

        [Authorize]
        [HttpGet("getGameweeksBySeasonId/{id}")]
        public async Task<IActionResult> GetGameweeksBySeasonIdQuery([FromRoute] Guid id)
            => Ok(await _mediator.Send(new GetGameweeksBySeasonIdQuery
            {
                SeasonId = id
            }));
    }
}
