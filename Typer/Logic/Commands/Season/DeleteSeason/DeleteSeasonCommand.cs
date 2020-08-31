using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Typer.Logic.Commands.Season.DeleteSeason
{
    public class DeleteSeasonCommand : IRequest<Unit>
    {
        public long seasonId { get; set; }
    }
}
