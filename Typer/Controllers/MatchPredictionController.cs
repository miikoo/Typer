using MediatR;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Typer.Logic.Commands.CreateMatchPredictionCommand;

namespace Typer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MatchPredictionController : BaseTyperController
    {
        public MatchPredictionController(IMediator _mediator) : base(_mediator)
        {
        }

        [HttpPost]
        public async Task<IActionResult> CreateMatchPrediction([FromBody] CreateMatchPredictionCommand command)
            => Ok(await _mediator.Send(command));
    }
}
