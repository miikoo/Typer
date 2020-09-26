using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace Typer.Application.Queries.Teams.GetTeamsQuery
{
    public class GetTeamsQuery : IRequest<List<TeamDto>>
    {
    }
}
