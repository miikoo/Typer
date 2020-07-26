using MediatR;

namespace Typer.Logic.Commands.UpdateMatchResult
{
    public class UpdateMatchResultCommand : IRequest<Unit>
    {
        public long MatchId { get; set; }
        public int HomeTeamGoals { get; set; }
        public int AwayTeamGoals { get; set; }
    }
}
