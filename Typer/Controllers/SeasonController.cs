using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Typer.Logic.Commands.Season.CreateSeason;
using Typer.Logic.Commands.Season.DeleteSeason;
using Typer.Logic.Commands.Season.EditSeason;
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

        [Authorize(Roles = "Admin")]
        [HttpPut]
        public async Task<IActionResult> EditSeason([FromBody] EditSeasonCommand command)
            => Ok(await _mediator.Send(command));

        [Authorize(Roles = "Admin")]
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteSeason([FromRoute] int id)
            => Ok(await _mediator.Send(new DeleteSeasonCommand
            {
                seasonId = id
            }));
    }
}
