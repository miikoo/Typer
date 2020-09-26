using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Typer.Domain.Interfaces;

namespace Typer.Application.Commands.Team.CreateTeam
{
    public class CreateTeamCommandHandler : IRequestHandler<CreateTeamCommand, long>
    {
        private readonly ITeamRepository _teamRepository;

        public CreateTeamCommandHandler(ITeamRepository teamRepository)
        {
            _teamRepository = teamRepository;
        }

        public async Task<long> Handle(CreateTeamCommand request, CancellationToken cancellationToken)
            => await _teamRepository.CreateAsync(request.TeamName);
    }
}
