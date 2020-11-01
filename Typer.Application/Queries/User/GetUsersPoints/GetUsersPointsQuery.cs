using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace Typer.Application.Queries.User.GetUsersPoints
{
    public class GetUsersPointsQuery : IRequest<List<UserPointsDto>>
    {
    }
}
