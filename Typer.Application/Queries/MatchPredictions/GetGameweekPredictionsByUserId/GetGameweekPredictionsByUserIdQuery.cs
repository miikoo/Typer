using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace Typer.Application.Queries.MatchPredictions.GetGameweekPredictionsByUserId
{
    public class GetGameweekPredictionsByUserIdQuery : IRequest<List<MatchPredictionDto>>
    {
        public Guid GameweekId { get; set; }
        public Guid UserId { get; set; }
    }
}
