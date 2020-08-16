using System;
using System.Collections.Generic;

namespace Typer.Database.Entities
{
    public class User
    {
        public User()
        {
            MatchPredictions = new HashSet<MatchPrediction>();
        }

        public Guid _UserId { get; set; }
        public string UserId => _UserId.ToString();
        public string Username { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

        public virtual ICollection<MatchPrediction> MatchPredictions { get; set; }
    }
}
