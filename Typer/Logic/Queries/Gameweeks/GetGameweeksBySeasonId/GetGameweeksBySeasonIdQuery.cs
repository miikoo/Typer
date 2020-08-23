using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Typer.Logic.DtoModels;

namespace Typer.Logic.Queries.Gameweeks.GetGameweeksBySeasonId
{
    public class GetGameweeksBySeasonIdQuery : IRequest<List<GameweekDto>>
    {
        public long SeasonId { get; set; }
    }
}
