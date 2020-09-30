using MediatR;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Typer.Application.Commands.MatchPrediction.CreateMatchPrediction;
using Typer.Application.Commands.MatchPrediction.UpdateMatchPrediction;

namespace Typer.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MatchPredictionController : ControllerBase
    {
        private readonly IMediator _mediator;

        public MatchPredictionController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        public async Task<IActionResult> CreateMatchPrediction([FromBody] CreateMatchPredictionCommand command)
            => Ok(await _mediator.Send(command));

        [HttpPut]
        public async Task<IActionResult> UpdateMatchPrediction([FromBody]UpdateMatchPredictionCommand command)
            => Ok(await _mediator.Send(command));

    }
}
