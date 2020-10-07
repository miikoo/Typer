using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace Typer.Application.Queries.MatchPredictions.AreGameweekPredictionsExist
{
    public class AreGameweekPredictionsExistQuery : IRequest<MatchPredictionDto>
    {
        public long GameweekId { get; set; }
        public Guid UserId { get; set; }
    }
}
