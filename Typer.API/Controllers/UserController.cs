using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;
using Typer.Application.Commands.Users.Authenticate;
using Typer.Application.Commands.Users.CreateUser;
using Typer.Application.Commands.Users.UpdateUser;
using Typer.Application.Queries.Users.GetUserDetails;
using Typer.Application.Queries.Users.GetUserPoints;
using Typer.Application.Queries.Users.GetUsersPoints;

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

        [AllowAnonymous]
        [HttpGet("getUserDetails/{username}")]
        public async Task<IActionResult> GetUserDetails([FromRoute] string username)
            => Ok(await _mediator.Send(new GetUserDetailsQuery { Username = username }));

        [Authorize]
        [HttpPut]
        public async Task<IActionResult> UpdateUser([FromBody] UpdateUserCommand command)
            => Ok(await _mediator.Send(command));
    }
}
