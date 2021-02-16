using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace Typer.Application.Queries.MatchPredictions.AreGameweekPredictionsExist
{
    public class AreGameweekPredictionsExistQuery : IRequest<MatchPredictionDto>
    {
        public Guid GameweekId { get; set; }
        public Guid UserId { get; set; }
    }
}
