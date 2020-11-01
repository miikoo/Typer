using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace Typer.Application.Queries.User.GetUserPoints
{
    public class GetUserPointsQuery : IRequest<UserPointsDto>
    {
        public Guid UserId { get; set; }
    }
}
