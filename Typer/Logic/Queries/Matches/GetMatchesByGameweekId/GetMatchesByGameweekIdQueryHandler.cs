using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using Typer.Logic.Queries.Matches;
using Typer.Logic.DtoModels;
using System.Threading;
using System.Threading.Tasks;
using Typer.Logic.Services;

namespace Typer.Logic.Queries.Matches.GetMatchesByGameweekId
{
    public class GetMatchesByGameweekIdQueryHandler : IRequestHandler<GetMatchesByGameweekIdQuery, List<MatchDto>>
    {
        private readonly IMatchService _matchService;

        public GetMatchesByGameweekIdQueryHandler(IMatchService matchService)
        {
            _matchService = matchService;
        }

        public async Task<List<MatchDto>> Handle(GetMatchesByGameweekIdQuery request, CancellationToken cancellationToken)
        {
            var matches = await _matchService.GetMatchesByGameweekId(request.GameweekId);
            return matches.Select(x => new MatchDto
            {
                AwayTeamGoals = x.AwayTeamGoals,
                HomeTeamGoals = x.HomeTeamGoals,
                AwayTeamName = x.AwayTeam.TeamName,
                HomeTeamName = x.HomeTeam.TeamName,
                MatchId = x.MatchId
            }).ToList();
        }
    }
}
