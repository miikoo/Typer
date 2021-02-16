using System;
using System.Collections.Generic;
using System.Text;

namespace Typer.Application.Client.PLClient.Matches
{
    public class ExternalApiTeam
    {
        public string TeamName { get; set; }
        public int? TeamScore { get; set; }
    }

    public class ExternalApiMatch
    {
        public DateTime When { get; set; }
        public ExternalApiTeam Team1 { get; set; }
        public ExternalApiTeam Team2 { get; set; }
    }

    public class GetMatchesResponse
    {
        public List<ExternalApiMatch> Matches { get; set; }
    }
}
