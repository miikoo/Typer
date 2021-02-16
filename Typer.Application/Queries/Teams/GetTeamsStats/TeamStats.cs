using System;
using System.Collections.Generic;
using System.Text;

namespace Typer.Application.Queries.Teams.GetTeamsStats
{
    public class TeamStats
    {
        public TeamStats(Guid teamId, string teamName, int? scoredGoals, int? concededGoals,
            int points, int wins, int draws, int losses)
        {
            TeamId = teamId;
            TeamName = teamName;
            ScoredGoals = scoredGoals;
            ConcededGoals = concededGoals;
            Points = points;
            Wins = wins;
            Losses = losses;
            Draws = draws;
        }

        public Guid TeamId { get; set; }
        public string TeamName { get; set; }
        public int? ScoredGoals { get; set; }
        public int? ConcededGoals { get; set; }
        public int Points { get; set; }
        public int Wins { get; set; }
        public int Losses { get; set; }
        public int Draws { get; set; }
    }
}
