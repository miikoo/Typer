using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace Typer.Application.Queries.Matches.GetMatchesByGameweekId
{
    public class GetMatchesByGameweekIdQuery : IRequest<List<MatchDto>>
    {
        public string GameweekId { get; set; }
    }
}
