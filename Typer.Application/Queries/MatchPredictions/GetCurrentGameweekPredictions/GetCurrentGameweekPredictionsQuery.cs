using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace Typer.Application.Queries.MatchPredictions.GetCurrentGameweekPredictions
{
    public class GetCurrentGameweekPredictionsQuery : IRequest<List<MatchPredictionDto>>
    {
        public Guid UserId { get; set; }
    }
}
