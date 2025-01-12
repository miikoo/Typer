﻿using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;
using Typer.Application.Commands.Matches.CreateMatch;
using Typer.Application.Commands.Matches.DeleteMatch;
using Typer.Application.Commands.Matches.UpdateMatchDetails;
using Typer.Application.Commands.Matches.UpdateMatchResult;
using Typer.Application.Queries.Matches.GetMatchesByGameweekId;

namespace Typer.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MatchController : ControllerBase
    {
        private readonly IMediator _mediator;

        public MatchController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [Authorize(Roles = "Admin")]
        [HttpPost]
        public async Task<IActionResult> CreateMatch([FromBody] CreateMatchCommand command)
        {
            var id = await _mediator.Send(command);
            return Ok(id.MatchId);
        }

        [Authorize(Roles = "Admin")]
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteMatch([FromRoute]string id)
            => Ok(await _mediator.Send(new DeleteMatchCommand
            {
                MatchId = id
            }));

        [Authorize(Roles = "Admin")]
        [HttpPut("updateMatchDetails")]
        public async Task<IActionResult> UpdateMatchDetails([FromBody] UpdateMatchDetailsCommand command)
            => Ok(await _mediator.Send(command));

        [Authorize(Roles = "Admin")]
        [HttpPut("updateMatchResult")]
        public async Task<IActionResult> UpdateMatchResult([FromBody] UpdateMatchResultCommand command)
            => Ok(await _mediator.Send(command));

        [HttpGet("getMatchesByGameweekId/{id}")]
        public async Task<IActionResult> GetMatchesByGameweekId([FromRoute]string id)
            => Ok(await _mediator.Send(new GetMatchesByGameweekIdQuery
            {
                GameweekId = id
            }));
    }
}