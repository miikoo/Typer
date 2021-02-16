using System;
using System.Collections.Generic;
using System.Text;

namespace Typer.Application.Client.PLClient.Teams
{
    public class ExternalApiClub
    {
        public float Id { get; set; }
    }
    public class ExternalApiTeam
    {
        public string Name { get; set; }
        public ExternalApiClub Club { get; set; }
    }

    public class GetTeamsResponseInfo
    {
        public float Page { get; set; }
    }
    public class GetTeamsResponse
    {
        public GetTeamsResponseInfo PageInfo { get; set; }
        public List<ExternalApiTeam> Content { get; set; }
    }
}
