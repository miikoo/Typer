using System;
using System.Collections.Generic;
using System.Text;

namespace Typer.Application.Queries.Users.GetUserDetails
{
    public class UserDetails
    {
        public UserDetails(string username, string email)
        {
            Username = username;
            Email = email;
        }

        public string Username { get; set; }
        public string Email { get; set; }
    }
}
