using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Typer.Logic.DtoModels;
using Typer.Logic.Services;

namespace Typer.Logic.Queries.Team.GetTeams
{
    public class GetTeamsQueryHandler : IRequestHandler<GetTeamsQuery, List<TeamDto>>
    {
        private readonly ITeamService _teamService;

        public GetTeamsQueryHandler(ITeamService teamService)
        {
            _teamService = teamService;
        }

        public async Task<List<TeamDto>> Handle(GetTeamsQuery request, CancellationToken cancellationToken)
            => await _teamService.GetTeams();
    }
}
