using MediatR;

namespace Typer.Logic.Commands.CreateTeamCommand
{
    public class CreateTeamCommand : IRequest<Unit>
    {
        public string TeamName { get; set; }
    }
}
