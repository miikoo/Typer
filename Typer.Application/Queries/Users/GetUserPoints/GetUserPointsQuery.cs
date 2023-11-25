using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace Typer.Application.Queries.Users.GetUserPoints
{
    public class GetUserPointsQuery : IRequest<UserPointsDto>
    {
        public string UserId { get; set; }
    }
}
