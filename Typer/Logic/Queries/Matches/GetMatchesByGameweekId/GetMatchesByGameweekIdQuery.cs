using MediatR;
using System.Collections.Generic;
using Typer.Logic.DtoModels;

namespace Typer.Logic.Queries.Matches.GetMatchesByGameweekId
{
    public class GetMatchesByGameweekIdQuery : IRequest<List<MatchDto>>
    {
        public long GameweekId { get; set; }
    }
}
