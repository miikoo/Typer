using MediatR;

namespace Typer.Logic.Commands.CreateTeam
{
    public class CreateTeamCommand : IRequest<Unit>
    {
        public string TeamName { get; set; }
    }
}
