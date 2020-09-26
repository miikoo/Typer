using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Typer.API.Commands.Season.UpdateSeason
{
    public class UpdateSeasonCommand : IRequest<Unit>
    {
        public long SeasonId { get; set; }
        public int StartYear { get; set; }
        public int EndYear { get; set; }
    }
}
