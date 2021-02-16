using System;
using System.Collections.Generic;
using System.Text;

namespace Typer.Domain.Models
{
    public class Team
    {
        public Team(Guid teamId, string teamName)
        {
            TeamId = teamId;
            TeamName = teamName;
        }

        public Guid TeamId { get; set; }
        public string TeamName { get; set; }

        public static Team Create(string teamName)
            => new Team(Guid.NewGuid(), teamName);
    }
}
