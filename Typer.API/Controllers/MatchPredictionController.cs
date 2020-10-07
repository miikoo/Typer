using MediatR;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Typer.Application.Commands.MatchPrediction.CreateMatchPrediction;
using Typer.Application.Commands.MatchPrediction.UpdateMatchPrediction;
using Typer.Application.Queries.MatchPredictions.AreGameweekPredictionsExist;
using Typer.Application.Queries.MatchPredictions.GetGameweekPredictionsByUserId;

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

        [HttpGet("areGameweekPredictionsExist/{id}/{userId}")]
        public async Task<IActionResult> AreGameweekPredictionsExist([FromRoute]int id, [FromRoute] Guid userId)
        {
            var areExist = await _mediator.Send(new AreGameweekPredictionsExistQuery
            {
                GameweekId = id,
                UserId = userId
            });
            return Ok(areExist.AreExist);
        }

        [HttpGet("getGameweekPredictionsByUserId/{id}/{userid}")]
        public async Task<IActionResult> GetGameweekPredictionsByUserId([FromRoute]long id, [FromRoute]Guid userId)
            => Ok(await _mediator.Send(new GetGameweekPredictionsByUserIdQuery 
            {
                GameweekId = id,
                UserId = userId
            }));
    }
}
