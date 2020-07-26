using MediatR;

namespace Typer.Logic.Commands.CreateMatch
{
    public class CreateMatchCommand : IRequest<Unit>
    {
        public long HomeTeamId { get; set; }
        public long AwayTeamId { get; set; }
        public long GameweekId { get; set; }
    }
}
