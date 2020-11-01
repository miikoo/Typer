using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace Typer.Application.Commands.MatchPrediction.CreateGameweekPredictions
{
    public class CreateGameweekPredictionsCommand : IRequest<Unit>
    {
        public Guid UserId { get; set; }
        public long GameweekId { get; set; }
    }
}
