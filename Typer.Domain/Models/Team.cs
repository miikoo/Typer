using System;
using System.Collections.Generic;
using System.Text;

namespace Typer.Domain.Models
{
    public class Team
    {
        public Team(string teamId, string teamName)
        {
            TeamId = teamId;
            TeamName = teamName;
        }

        public Team()
        {
            
        }

        public string TeamId { get; set; }
        public string TeamName { get; set; }

        public static Team Create(string teamName)
            => new Team(Guid.NewGuid().ToString(), teamName);
    }
}
