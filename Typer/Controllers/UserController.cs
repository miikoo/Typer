using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using Typer.Logic.Commands.User.CreateUserCommand;
using Typer.Logic.Queries.User.GetUser;

namespace Typer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [AllowAnonymous]
    public class UserController : BaseTyperController
    {
        public UserController(IMediator _mediator) : base(_mediator)
        {
        }

        [HttpGet]
        public async Task<IActionResult> GetUser(GetUserQuery query)
        => Ok(await _mediator.Send(query)); // NoContent ?

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] CreateUserCommand command)
        => Ok(await _mediator.Send(command));
    }
}
