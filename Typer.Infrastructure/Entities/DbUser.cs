using System;
using System.Collections.Generic;
using System.Text;
using Typer.Domain.Enums;
using Typer.Domain.Models;

namespace Typer.Infrastructure.Entities
{
    public class DbUser
    {
        public DbUser()
        {
            MatchPredictions = new HashSet<DbMatchPrediction>();
        }

        public Guid UserId { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public Roles Role { get; set; }
        public string Salt { get; set; }

        public virtual ICollection<DbMatchPrediction> MatchPredictions { get; set; }

        public static DbUser Create(User user)
            => new DbUser
            {
                Salt = user.Salt,
                Email = user.Email,
                Password = user.Password,
                Role = user.Role,
                Username = user.Username,
                UserId = user.UserId
            };
    }
}
