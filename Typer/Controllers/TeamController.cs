using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using Typer.Logic.Commands.CreateTeam;
using Typer.Logic.Commands.Team.DeleteTeam;
using Typer.Logic.Queries.Team.GetTeams;

namespace Typer.Controllers
{
    public class TeamController : BaseTyperController
    {
        public TeamController(IMediator _mediator) : base(_mediator)
        {

        }

        [HttpPost]
        public async Task<IActionResult> CreateTeam(CreateTeamCommand command)
            => Ok(await _mediator.Send(command));

        [HttpGet]
        public async Task<IActionResult> GetTeams([FromQuery]GetTeamsQuery query)
            => Ok(await _mediator.Send(query));

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTeam([FromRoute] int id)
            => Ok(await _mediator.Send(new DeleteTeamCommand
            {
                TeamId = id
            }));
    }
}