using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Typer.Logic.Commands.CreateMatchCommand;

namespace Typer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MatchController : BaseTyperController
    {
        public MatchController(IMediator _mediator) : base(_mediator)
        {
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] CreateMatchCommand command)
        => Ok(await _mediator.Send(command));
    }
}
