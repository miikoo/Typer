using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;
using Typer.API.Queries.Seasons.GetSeasonQuery;
using Typer.Application.Commands.Seasons.CreateSeason;
using Typer.Application.Commands.Seasons.DeleteSeason;
using Typer.Application.Commands.Seasons.UpdateSeason;
using Typer.Application.Queries.Seasons.IsNextSeasonExist;

namespace Typer.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SeasonController : ControllerBase
    {
        private readonly IMediator _mediator;

        public SeasonController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [Authorize(Roles = "Admin")]
        [HttpPost]
        public async Task<IActionResult> CreateSeason([FromBody] CreateSeasonCommand command)
        {
            var id = await _mediator.Send(command);
            return Ok(id.SeasonId);
        }

        [Authorize(Roles = "Admin")]
        [HttpPut]
        public async Task<IActionResult> UpdateSeason([FromBody] UpdateSeasonCommand command)
            => Ok(await _mediator.Send(new UpdateSeasonCommand
            {
                SeasonId = command.SeasonId,
                StartYear = command.StartYear,
                EndYear = command.EndYear
            }));

        [AllowAnonymous]
        [HttpGet]
        public async Task<IActionResult> GetSeasons()
            => Ok(await _mediator.Send(new GetSeasonsQuery { }));

        [Authorize(Roles = "Admin")]
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteSeason([FromRoute] string id)
            => Ok(await _mediator.Send(new DeleteSeasonCommand
            {
                SeasonId = id
            }));

        [AllowAnonymous]
        [HttpGet("isNextSeasonExist")]
        public async Task<IActionResult> IsNextSeasonExist()
            => Ok(await _mediator.Send(new IsNextSeasonExistQuery()));
    }
}