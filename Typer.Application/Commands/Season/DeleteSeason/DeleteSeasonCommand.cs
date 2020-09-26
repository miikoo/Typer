using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Typer.Application.Commands.Season.DeleteSeason
{
    public class DeleteSeasonCommand : IRequest<Unit>
    {
        public long SeasonId { get; set; }
    }
}
