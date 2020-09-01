using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Typer.Logic.Services;

namespace Typer.Logic.Commands.Team.DeleteTeam
{
    public class DeleteTeamCommandHandler : IRequestHandler<DeleteTeamCommand, Unit>
    {
        private readonly ITeamService _teamService;

        public DeleteTeamCommandHandler(ITeamService teamService)
        {
            _teamService = teamService;
        }

        public async Task<Unit> Handle(DeleteTeamCommand request, CancellationToken cancellationToken)
        {
            await _teamService.DeleteTeam(request.TeamId);
            return Unit.Value;
        }
    }
}
