using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using Typer.Logic.Commands.CreateTeamCommand;

namespace Typer.Controllers
{
    public class TeamController : BaseTyperController
    {
        public TeamController(IMediator _mediator) : base(_mediator)
        {

        }

        [HttpPost]
        public async Task<IActionResult> CreateTeam([FromBody] CreateTeamCommand command)
            => Ok(await _mediator.Send(command));
    }
}