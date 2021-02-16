using System;
using System.Collections.Generic;
using System.Text;

namespace Typer.Application.Queries.Users.GetUsersPoints
{
    public class UserPointsDto
    {
        public UserPointsDto(int points, string username, int exactPredictions, int incorrectPredictions, int winnerPredictions)
        {
            Points = points;
            Username = username;
            ExactPredictions = exactPredictions;
            IncorrectPredictions = incorrectPredictions;
            WinnerPredictions = winnerPredictions;
        }

        public int Points { get; set; }
        public int ExactPredictions { get; set; }
        public int IncorrectPredictions { get; set; }
        public int WinnerPredictions { get; set; }
        public string Username { get; set; }
    }
}
