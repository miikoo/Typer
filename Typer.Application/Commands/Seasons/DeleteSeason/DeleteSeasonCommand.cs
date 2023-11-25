using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Typer.Application.Commands.Seasons.DeleteSeason
{
    public class DeleteSeasonCommand : IRequest<Unit>
    {
        public string SeasonId { get; set; }
    }
}
