using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Typer.Logic.DtoModels;

namespace Typer.Logic.Commands.Season.CreateSeason
{
    public class CreateSeasonCommand : IRequest<SeasonDto>
    {
        public int startYear { get; set; }
        public int endYear { get; set; }
    }
}
