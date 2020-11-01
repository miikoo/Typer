using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;
using Typer.Application.Commands.User.Authenticate;
using Typer.Application.Commands.User.CreateUser;
using Typer.Application.Queries.User.GetUserPoints;
using Typer.Application.Queries.User.GetUsersPoints;

namespace Typer.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IMediator _mediator;

        public UserController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [AllowAnonymous]
        [HttpPost("register")]
        public async Task<IActionResult> CreateUser([FromBody] CreateUserCommand command)
            => Ok(await _mediator.Send(command));

        [AllowAnonymous]
        [HttpPost("authenticate")]
        public async Task<IActionResult> Authenticate([FromBody] AuthenticateCommand command)
            => Ok(await _mediator.Send(command));

        [Authorize]
        [HttpGet("getUserPoints/{id}")]
        public async Task<IActionResult> GetUserPoints([FromRoute]Guid id)
            => Ok(await _mediator.Send(new GetUserPointsQuery
            {
                UserId = id
            }));

        [AllowAnonymous]
        [HttpGet("getUsersPoints")]
        public async Task<IActionResult> GetUsersPoints()
            => Ok(await _mediator.Send(new GetUsersPointsQuery()));
    }
}
