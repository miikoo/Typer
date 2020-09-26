using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Typer.API.Commands.Match.CreateMatch
{
    public class CreateMatchCommand : IRequest<long>
    {
        public long HomeTeamId { get; set; }
        public long AwayTeamId { get; set; }
        public DateTime MatchDate { get; set; }
        public long GameweekId { get; set; }
    }
}
