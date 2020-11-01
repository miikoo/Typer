using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Typer.Domain.Interfaces;
using Typer.Domain.Models;
using Typer.Infrastructure.Entities;

namespace Typer.Infrastructure.Repositories
{
    public class TeamRepository : ITeamRepository
    {
        private readonly TyperContext _context;

        public TeamRepository(TyperContext context)
        {
            _context = context;
        }

        public async Task<long> CreateAsync(string TeamName)
        {
            var team = new DbTeam
            {
                TeamName = TeamName
            };
            await _context.AddAsync(team);
            await _context.SaveChangesAsync();
            return team.TeamId;
        }

        public async Task DeleteAsync(long teamId)
        {
            var team = await (from t in _context.Teams where t.TeamId == teamId select t).FirstAsync();
            _context.Teams.Remove(team);
            await _context.SaveChangesAsync();
        }

        public async Task<List<Team>> GetAsync()
            => await (from t in _context.Teams
                      select new Team
                      {
                          TeamId = t.TeamId,
                          TeamName = t.TeamName
                      }).ToListAsync();

        public async Task<Team> GetAsync(long teamId)
            => await (from t in _context.Teams
                      where t.TeamId == teamId
                      select new Team
                      {
                          TeamId = t.TeamId,
                          TeamName = t.TeamName
                      }).FirstAsync();

        public async Task<Team> GetByName(string name)
            => await (from t in _context.Teams
                      where t.TeamName == name
                      select new Team
                      {
                          TeamId = t.TeamId,
                          TeamName = t.TeamName
                      }).FirstOrDefaultAsync();

        public async Task UpdateAsync(long teamId, string teamName)
        {
            var team = await (from t in _context.Teams where t.TeamId == teamId select t).FirstAsync();
            team.TeamName = teamName;
            await _context.SaveChangesAsync();
        }
    }
}
