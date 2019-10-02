using System.Threading;
using System.Threading.Tasks;
using MediatR;
using Typer.Logic.Services;

namespace Typer.Logic.Commands.CreateMatchPredictionCommand
{
    public class CreateMatchPredictionHandler : IRequestHandler<CreateMatchPredictionCommand, Unit>
    {
        private readonly IMatchPredictionService _matchPredictionService;

        public CreateMatchPredictionHandler(IMatchPredictionService matchPredictionService)
        {
            _matchPredictionService = matchPredictionService;
        }

        public async Task<Unit> Handle(CreateMatchPredictionCommand request, CancellationToken cancellationToken)
        {
            await _matchPredictionService.CreateMatchPrediction(request.UserId, request.MatchId, request.HomeTeamGoals, request.AwayTeamGoals);
            return Unit.Value;
        }
    }
}
