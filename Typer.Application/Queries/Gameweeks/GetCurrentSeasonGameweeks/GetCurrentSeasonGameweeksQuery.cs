using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace Typer.Application.Queries.Gameweeks.GetCurrentSeasonGameweeks
{
    public class GetCurrentSeasonGameweeksQuery : IRequest<List<GameweekDto>>
    {
    }
}
