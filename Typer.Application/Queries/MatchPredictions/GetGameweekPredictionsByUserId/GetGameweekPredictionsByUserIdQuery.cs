using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace Typer.Application.Queries.MatchPredictions.GetGameweekPredictionsByUserId
{
    public class GetGameweekPredictionsByUserIdQuery : IRequest<List<MatchPredictionDto>>
    {
        public string GameweekId { get; set; }
        public string UserId { get; set; }
    }
}
