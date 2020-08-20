using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Typer.Logic.Commands.Season.CreateSeason;
using Typer.Logic.Queries.Seasons.GetSeasons;

namespace Typer.Controllers
{
    public class SeasonController : BaseTyperController
    {
        public SeasonController(IMediator _mediator): base(_mediator)
        {

        }

        [Authorize(Roles ="Admin")]
        [HttpPost]
        public async Task<IActionResult> CreateSeason(CreateSeasonCommand command)
            => Ok(await _mediator.Send(command));

        [HttpGet]
        public async Task<IActionResult> GetSeasons([FromQuery]GetSeasonsQuery query)
            => Ok(await _mediator.Send(query));
    }
}
