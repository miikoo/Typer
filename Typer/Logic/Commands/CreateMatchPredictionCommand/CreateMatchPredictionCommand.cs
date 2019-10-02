using MediatR;

namespace Typer.Logic.Commands.CreateMatchPredictionCommand
{
    public class CreateMatchPredictionCommand : IRequest<Unit>
    {
        public long MatchId { get; set; }
        public long UserId { get; set; }
        public int AwayTeamGoals { get; set; }
        public int HomeTeamGoals { get; set; }
    }
}
