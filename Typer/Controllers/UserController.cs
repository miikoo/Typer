using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Typer.Logic.Commands.CreateUserCommand;
using Typer.Logic.Queries.GetUser;

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
        public async Task<IActionResult> CreateUser([FromBody] CreateUserCommand command)
            => Ok(await _mediator.Send(command));
    }
}
