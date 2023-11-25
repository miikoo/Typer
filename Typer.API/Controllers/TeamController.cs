using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;
using Typer.Application.Commands.Teams.CreateTeam;
using Typer.Application.Commands.Teams.DeleteTeam;
using Typer.Application.Commands.Teams.UpdateTeam;
using Typer.Application.Queries.Teams.GetTeamsQuery;
using Typer.Application.Queries.Teams.GetTeamsStats;

namespace Typer.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TeamController : ControllerBase
    {
        private readonly IMediator _mediator;

        public TeamController(IMediator mediator)
        {
            _mediator = mediator;
        }

        //[Authorize(Roles = "Admin")]
        [AllowAnonymous]
        [HttpPost]
        public async Task<IActionResult> CreateTeam([FromBody]CreateTeamCommand command)
            => Ok(await _mediator.Send(command));

        [Authorize(Roles = "Admin")]
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTeam([FromRoute] string id)
            => Ok(await _mediator.Send(new DeleteTeamCommand
            {
                TeamId = id
            }));

        [Authorize(Roles = "Admin")]
        [HttpPut]
        public async Task<IActionResult> UpdateTeam([FromBody] UpdateTeamCommand command)
            => Ok(await _mediator.Send(command));

        [Authorize]
        [HttpGet]
        public async Task<IActionResult> GetTeams()
            => Ok(await _mediator.Send(new GetTeamsQuery()));

        [HttpGet("getTeamStats")]
        public async Task<IActionResult> GetTeamsStats()
            => Ok(await _mediator.Send(new GetTeamsStatsQuery()));

    }
}