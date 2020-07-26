using MediatR;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Typer.Logic.Commands.Gameweek.CreateGameweek;

namespace Typer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GameweekController : BaseTyperController
    {
        public GameweekController(IMediator _mediator): base(_mediator)
        {

        }

        [HttpPost]
        public async Task CreateGameweek([FromBody] CreateGameweekCommand command)
            => Ok(await _mediator.Send(command));
    }
}
