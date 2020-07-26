using MediatR;
using System.Threading;
using System.Threading.Tasks;
using Typer.Logic.Services;

namespace Typer.Logic.Commands.UpdateMatchResult
{
    public class UpdateMatchResultCommandHandler : IRequestHandler<UpdateMatchResultCommand, Unit>
    {
        private readonly IMatchService _matchService;

        public UpdateMatchResultCommandHandler(IMatchService matchService)
        {
            _matchService = matchService;
        }

        public async Task<Unit> Handle(UpdateMatchResultCommand request, CancellationToken cancellationToken)
        {
            await _matchService.UpdateMatchResult(request.MatchId, request.HomeTeamGoals, request.AwayTeamGoals);
            return Unit.Value;
        }
    }
}
