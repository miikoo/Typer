using System;
using System.Collections.Generic;
using System.Text;

namespace Typer.Application.Commands.Users.CreateUser
{
    public class UserDto
    {
        public UserDto()
        {
            
        }
        public UserDto(string token, string userId)
        {
            Token = token;
            UserId = userId;
        }

        public string UserId { get; set; }
        public string Token { get; set; }
    }
}
