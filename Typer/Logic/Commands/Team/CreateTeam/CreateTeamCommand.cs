using MediatR;
using Typer.Logic.DtoModels;

namespace Typer.Logic.Commands.CreateTeam
{
    public class CreateTeamCommand : IRequest<TeamDto>
    {
        public string TeamName { get; set; }
    }
}
