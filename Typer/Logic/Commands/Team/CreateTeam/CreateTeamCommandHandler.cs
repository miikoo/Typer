using MediatR;
using System.Threading;
using System.Threading.Tasks;
using Typer.Logic.DtoModels;
using Typer.Logic.Services;

namespace Typer.Logic.Commands.CreateTeam
{
    public class CreateTeamCommandHandler : IRequestHandler<CreateTeamCommand, TeamDto>
    {
        private readonly ITeamService _teamService;

        public CreateTeamCommandHandler(ITeamService teamService)
        {
            _teamService = teamService;
        }

        public async Task<TeamDto> Handle(CreateTeamCommand request, CancellationToken cancellationToken)
            => await _teamService.CreateTeam(request.TeamName);
    }
}
