using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace Typer.Application.Commands.User.Authenticate
{
    public class AuthenticateCommand : IRequest<UserDto>
    {
        public string Username { get; set; }
        public string Password { get; set; }
    }
}
