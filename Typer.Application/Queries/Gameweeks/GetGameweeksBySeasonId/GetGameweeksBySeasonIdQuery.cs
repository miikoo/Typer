using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace Typer.Application.Queries.Gameweeks.GetGameweeksBySeasonId
{
    public class GetGameweeksBySeasonIdQuery : IRequest<List<GameweekDto>>
    {
        public string SeasonId { get; set; }
    }
}
