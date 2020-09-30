using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Typer.Application.Commands.Season.CreateSeason
{
    public class CreateSeasonCommand : IRequest<SeasonDto>
    {
        public int StartYear { get; set; }
        public int EndYear { get; set; }
    }
}
