using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace Typer.Application.Queries.Gameweek.GetGameweeksBySeasonId
{
    public class GetGameweeksBySeasonIdQuery : IRequest<List<GameweekDto>>
    {
        public long SeasonId { get; set; }
        public int GameweekNumber { get; set; }
    }
}
