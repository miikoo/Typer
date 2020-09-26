using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace Typer.Application.Queries.Gameweek.GetCurrentSeasonGameweeks
{
    public class GetCurrentSeasonGameweeksQuery : IRequest<List<GameweekDto>>
    {
    }
}
