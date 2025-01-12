﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Typer.Application.Queries.MatchPredictions.GetNextPredictions
{
    public class MatchPredictionDto
    {
        public MatchPredictionDto()
        {
            
        }
        public MatchPredictionDto(string? matchPredictionId, int? homeTeamGoals, int? awayTeamGoals, string homeTeamName,
            string awayTeamName, int? homeTeamGoalsPrediction, int? awayTeamGoalsPrediction, DateTime matchDate)
        {
            MatchPredictionId = matchPredictionId;
            HomeTeamName = homeTeamName;
            AwayTeamName = awayTeamName;
            HomeTeamGoals = homeTeamGoals;
            AwayTeamGoals = awayTeamGoals;
            HomeTeamGoalsPrediction = homeTeamGoalsPrediction;
            AwayTeamGoalsPrediction = awayTeamGoalsPrediction;
            MatchDate = matchDate;
        }

        public string? MatchPredictionId { get; set; }
        public string HomeTeamName { get; set; }
        public string AwayTeamName { get; set; }
        public int? HomeTeamGoals { get; set; }
        public int? AwayTeamGoals { get; set; }
        public int? HomeTeamGoalsPrediction { get; set; }
        public int? AwayTeamGoalsPrediction { get; set; }
        public DateTime MatchDate { get; set; }
    }
}
