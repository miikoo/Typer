using System;
using System.Collections.Generic;
using System.Text;
using Typer.Domain.Enums;

namespace Typer.Domain.Models
{
    public class User
    {
        public Guid UserId { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public Roles Role { get; set; }
    }
}
