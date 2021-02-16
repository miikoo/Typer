using System;
using System.Collections.Generic;
using System.Text;

namespace Typer.Application.Queries.MatchPredictions.AreGameweekPredictionsExist
{
    public class MatchPredictionDto
    {
        public MatchPredictionDto(bool areExist)
        {
            AreExist = areExist;
        }

        public bool AreExist { get; set; }
    }
}
