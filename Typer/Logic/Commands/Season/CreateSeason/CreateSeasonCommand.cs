using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Typer.Logic.Commands.Season.CreateSeason
{
    public class CreateSeasonCommand : IRequest<Unit>
    {
        public int startYear { get; set; }
        public int endYear { get; set; }
    }
}
