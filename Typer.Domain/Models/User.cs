using System;
using System.Collections.Generic;
using System.Text;
using Typer.Domain.Enums;

namespace Typer.Domain.Models
{
    public class User
    {
        public User(string userId, string username, string email, Roles role, string password, string salt)
        {
            UserId = userId;
            Username = username;
            Email = email;
            Role = role;
            Password = password;
            Salt = salt;
        }

        public User()
        {
            
        }

        public string UserId { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public Roles Role { get; set; }
        public string Password { get; set; }
        public string Salt { get; set; }

        public static User Create(string username, string email, Roles role, string password, string salt)
            => new User(Guid.NewGuid().ToString(), username, email, role, password, salt);
    }
}
