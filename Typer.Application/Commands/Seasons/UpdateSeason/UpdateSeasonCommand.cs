using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Typer.Application.Commands.Seasons.UpdateSeason
{
    public class UpdateSeasonCommand : IRequest<Unit>
    {
        public Guid SeasonId { get; set; }
        public int StartYear { get; set; }
        public int EndYear { get; set; }
    }
}
