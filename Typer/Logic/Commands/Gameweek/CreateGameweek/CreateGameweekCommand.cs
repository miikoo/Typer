using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Typer.Logic.DtoModels;

namespace Typer.Logic.Commands.Gameweek.CreateGameweek
{
    public class CreateGameweekCommand : IRequest<GameweekDto>
    {
        public long SeasonId { get; set; }
        public int GameweekNumber { get; set; }
    }
}
