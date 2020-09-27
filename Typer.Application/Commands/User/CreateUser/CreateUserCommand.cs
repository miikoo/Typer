using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace Typer.Application.Commands.User.CreateUser
{
    public class CreateUserCommand : IRequest<UserDto>
    {
        public string Email { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
    }
}
