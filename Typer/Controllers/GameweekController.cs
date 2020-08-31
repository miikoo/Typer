using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Typer.Logic.Commands.Gameweek.CreateGameweek;
using Typer.Logic.Commands.Gameweek.DeleteGameweek;
using Typer.Logic.Commands.Gameweek.EditGameweek;
using Typer.Logic.Queries.Gameweeks.GetGameweeksBySeasonId;

namespace Typer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [AllowAnonymous]
    public class GameweekController : BaseTyperController
    {
        public GameweekController(IMediator _mediator): base(_mediator)
        {

        }

        [HttpPost]
        public async Task<IActionResult> CreateGameweek([FromBody] CreateGameweekCommand command)
            => Ok(await _mediator.Send(command));

        [HttpGet("{id}")]
        public async Task<IActionResult> GetGameweeksBySeasonId([FromRoute] int id)
        {
            return Ok(await _mediator.Send(new GetGameweeksBySeasonIdQuery
            {
                SeasonId = id
            }));
        }


        [Authorize(Roles = "Admin")]
        [HttpPut]
        public async Task<IActionResult> EditGameweek([FromBody] EditGameweekCommand command)
            => Ok(await _mediator.Send(command));

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteGamewee([FromRoute] int id)
            => Ok(await _mediator.Send(new DeleteGameweekCommand
            {
                GameweekId = id
            }));
    }
}
