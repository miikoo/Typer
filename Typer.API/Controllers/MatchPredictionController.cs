using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;
using Typer.Application.Commands.MatchPredictions.CreateGameweekPredictions;
using Typer.Application.Commands.MatchPredictions.CreateMatchPrediction;
using Typer.Application.Commands.MatchPredictions.UpdateMatchPrediction;
using Typer.Application.Commands.MatchPredictions.UpdateMatchPredictions;
using Typer.Application.Queries.MatchPredictions.AreGameweekPredictionsExist;
using Typer.Application.Queries.MatchPredictions.GetCurrentGameweekPredictions;
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

        [Authorize]
        [HttpPost]
        public async Task<IActionResult> CreateMatchPrediction([FromBody] CreateMatchPredictionCommand command)
            => Ok(await _mediator.Send(command));

        [Authorize]
        [HttpPut]
        public async Task<IActionResult> UpdateMatchPrediction([FromBody]UpdateMatchPredictionCommand command)
            => Ok(await _mediator.Send(command));

        [Authorize]
        [HttpGet("areGameweekPredictionsExist/{id}/{userId}")]
        public async Task<IActionResult> AreGameweekPredictionsExist([FromRoute]Guid id, [FromRoute] Guid userId)
        {
            var areExist = await _mediator.Send(new AreGameweekPredictionsExistQuery
            {
                GameweekId = id,
                UserId = userId
            });
            return Ok(areExist.AreExist);
        }

        [Authorize]
        [HttpGet("getGameweekPredictionsByUserId/{id}/{userid}")]
        public async Task<IActionResult> GetGameweekPredictionsByUserId([FromRoute]Guid id, [FromRoute]Guid userId)
            => Ok(await _mediator.Send(new GetGameweekPredictionsByUserIdQuery 
            {
                GameweekId = id,
                UserId = userId
            }));

        [Authorize]
        [HttpPost("createGameweeksPrediction")]
        public async Task<IActionResult> CreateGameweeksPrediction([FromBody]CreateGameweekPredictionsCommand command)
            => Ok(await _mediator.Send(command));

        [Authorize]
        [HttpPut("updateMatchPredictions")]
        public async Task<IActionResult> UpdateMatchPredictions([FromBody]UpdateMatchPredictionsCommand command)
            => Ok(await _mediator.Send(command));

        [Authorize]
        [HttpGet("getCurrentGameweekPredictionsByUserId/{userid}")]
        public async Task<IActionResult> GetCurrentGameweekPredictionsByUserId([FromRoute]Guid userId)
            => Ok(await _mediator.Send(new GetCurrentGameweekPredictionsQuery
            {
                UserId = userId
            }));
    }
}
