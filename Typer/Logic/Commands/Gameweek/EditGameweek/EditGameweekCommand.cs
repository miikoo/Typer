using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Typer.Logic.DtoModels;

namespace Typer.Logic.Commands.Gameweek.EditGameweek
{
    public class EditGameweekCommand : IRequest<GameweekDto>
    {
        public long gameweekId { get; set; }
        public int gameweekNumber { get; set; }
    }
}
