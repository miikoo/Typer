using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Typer.Domain.Interfaces.Services;
using Typer.Domain.Models;
using Typer.Application.Client.PLClient;
using System.Linq;

namespace Typer.Infrastructure.PLClientSevice
{
    public class PLClientService : IPLClientService
    {
        private readonly IPLClient _pLClient;
        private readonly TyperContext _context;

        public PLClientService(IPLClient pLClient, TyperContext context)
        {
            _pLClient = pLClient;
            _context = context;
        }

        public async Task<List<Match>> GetNextGameweeksMatches(int numOfGameweeks)
        {
            var currentGameweekNum = await (from m in _context.Matches
                                    where m.MatchDate > DateTime.UtcNow
                                    join g in _context.Gameweeks on m.GameweekId equals g.GameweekId
                                    orderby m.MatchDate
                                    select g.GameweekNumber).FirstAsync();
            return  await (from m in _context.Matches
                           join g in _context.Gameweeks on m.GameweekId equals g.GameweekId
                           where g.GameweekNumber >= currentGameweekNum && g.GameweekNumber <= currentGameweekNum+numOfGameweeks
                           orderby g.GameweekNumber
                           select new Match(m.MatchId, m.HomeTeamGoals, m.AwayTeamGoals,
                               m.MatchDate, m.AwayTeamId, m.HomeTeamId, m.GameweekId)).ToListAsync();
        }

        public async Task<List<Match>> GetNotUpdatedMatchessAsync()
            => await (from m in _context.Matches
                      where m.HomeTeamGoals == null && m.MatchDate < DateTime.UtcNow.AddHours(-2)
                      select new Match(m.MatchId, null, null, m.MatchDate, m.AwayTeamId, m.HomeTeamId, m.GameweekId))
                        .ToListAsync();
    }
}