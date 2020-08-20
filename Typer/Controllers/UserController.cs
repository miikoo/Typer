using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using Typer.Logic.Commands.User.Authenticate;
using Typer.Logic.Commands.User.CreateUser;
using Typer.Logic.Queries.User.GetUser;

namespace Typer.Controllers
{
    public class UserController : BaseTyperController
    {
        public UserController(IMediator _mediator) : base(_mediator)
        {
        }

        [HttpGet]
        public async Task<IActionResult> GetUser(GetUserQuery query)
            => Ok(await _mediator.Send(query));

        [AllowAnonymous]
        [HttpPost("register")]
        public async Task<IActionResult> CreateUser([FromBody] CreateUserCommand command)
            => Ok(await _mediator.Send(command));

        [AllowAnonymous]
        [HttpPost("authenticate")]
        public async Task<IActionResult> Authenticate([FromBody] AuthenticateCommand command)
            => Ok(await _mediator.Send(command));
    }
}
