using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace Typer.Application.Queries.Teams.GetTeamsStats
{
    public class GetTeamsStatsQuery : IRequest<List<TeamStats>>
    {
    }
}
