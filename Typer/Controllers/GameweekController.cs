using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Typer.Logic.Commands.Gameweek.CreateGameweek;
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
    }
}
