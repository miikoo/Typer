using MediatR;
using System.Threading;
using System.Threading.Tasks;
using Typer.Logic.Services;

namespace Typer.Logic.Commands.CreateTeam
{
    public class CreateTeamCommandHandler : IRequestHandler<CreateTeamCommand, Unit>
    {
        private readonly ITeamService _teamService;

        public CreateTeamCommandHandler(ITeamService teamService)
        {
            _teamService = teamService;
        }

        public async Task<Unit> Handle(CreateTeamCommand request, CancellationToken cancellationToken)
        {
            await _teamService.CreateMatch(request.TeamName);
            return Unit.Value;
        }
    }
}
