using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace Typer.Application.Queries.MatchPredictions.GetNextPredictions
{
    public class GetNextPredictionsQuery : IRequest<List<MatchPredictionDto>>
    {
        public int NumOfPredictions { get; set; }
        public string UserId { get; set; }
    }
}
