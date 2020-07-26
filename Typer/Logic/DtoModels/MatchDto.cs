using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Typer.Logic.DtoModels
{
    public class MatchDto
    {
        public long MatchId { get; set; }
        public int? HomeTeamGoals { get; set; }
        public int? AwayTeamGoals { get; set; }
        public string HomeTeamName { get; set; }
        public string AwayTeamName { get; set; }
    }
}
