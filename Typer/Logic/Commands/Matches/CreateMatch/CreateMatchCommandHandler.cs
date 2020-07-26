using MediatR;
using System.Threading;
using System.Threading.Tasks;
using Typer.Logic.Services;

namespace Typer.Logic.Commands.CreateMatch
{
    public class CreateMatchCommandHandler : IRequestHandler<CreateMatchCommand, Unit>
    {
        private readonly IMatchService _matchService;

        public CreateMatchCommandHandler(IMatchService matchService)
        {
            _matchService = matchService;
        }

        public async Task<Unit> Handle(CreateMatchCommand request, CancellationToken cancellationToken)
        {
            await _matchService.CreateMatch(request.HomeTeamId, request.AwayTeamId, request.GameweekId);
            return Unit.Value;
        }
    }
}
