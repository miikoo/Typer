using MediatR;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Typer.Logic.Commands.Season.CreateSeason;

namespace Typer.Controllers
{
    public class SeasonController : BaseTyperController
    {
        public SeasonController(IMediator _mediator): base(_mediator)
        {

        }

        [HttpPost]
        public async Task<IActionResult> CreateSeason(CreateSeasonCommand command)
            => Ok(await _mediator.Send(command));
    }
}
