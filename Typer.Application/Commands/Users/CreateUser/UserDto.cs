using System;
using System.Collections.Generic;
using System.Text;

namespace Typer.Application.Commands.Users.CreateUser
{
    public class UserDto
    {
        public UserDto(string token, Guid userId)
        {
            Token = token;
            UserId = userId;
        }

        public Guid UserId { get; set; }
        public string Token { get; set; }
    }
}
