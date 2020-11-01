using System;
using System.Collections.Generic;
using System.Text;
using Typer.Domain.Enums;

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

    }
}
