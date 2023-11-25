using System;
using System.Collections.Generic;
using System.Text;
using Typer.Domain.Enums;

namespace Typer.Application.Commands.Users.Authenticate
{
    public class UserDto
    {
        public UserDto()
        {
            
        }
        public UserDto(string username, Roles role, string userId, string token)
        {
            Username = username;
            Role = role;
            UserId = userId;
            Token = token;
        }

        public string Username { get; set; }
        public Roles Role { get; set; }
        public string UserId { get; set; }
        public string Token { get; set; }
    }
}
