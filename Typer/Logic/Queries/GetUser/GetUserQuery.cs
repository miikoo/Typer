using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Typer.Logic.DtoModels;

namespace Typer.Logic.Queries.GetUser
{
    public class GetUserQuery : IRequest<UserDto>
    {
        public string Username { get; set; }
    }
}
