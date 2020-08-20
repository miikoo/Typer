using System;
using System.Collections.Generic;

namespace Typer.Database.Entities
{
    public class User
    {
        public User()
        {
            MatchPredictions = new HashSet<MatchPrediction>();
            UserId = Guid.NewGuid().ToString();
        }

        public string UserId { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public Roles Role { get; set; }

        public virtual ICollection<MatchPrediction> MatchPredictions { get; set; }

        public enum Roles
        {
            Admin,
            User
        }
    }
}
