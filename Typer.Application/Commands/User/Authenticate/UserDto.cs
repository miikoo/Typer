using System;
using System.Collections.Generic;
using System.Text;
using Typer.Domain.Enums;

namespace Typer.Application.Commands.User.Authenticate
{
    public class UserDto
    {
        public string Username { get; set; }
        public Roles Role { get; set; }
        public Guid UserId { get; set; }
        public string Token { get; set; }
    }
}
