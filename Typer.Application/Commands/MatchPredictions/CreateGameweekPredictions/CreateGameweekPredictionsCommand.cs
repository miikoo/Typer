using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace Typer.Application.Commands.MatchPredictions.CreateGameweekPredictions
{
    public class CreateGameweekPredictionsCommand : IRequest<Unit>
    {
        public string UserId { get; set; }
        public string GameweekId { get; set; }
    }
}
