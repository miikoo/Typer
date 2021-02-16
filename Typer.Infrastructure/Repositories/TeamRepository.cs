using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Typer.Domain.Interfaces.Repositories;
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

        public async Task CreateAsync(params Team[] teams)
        {
            await _context.AddRangeAsync(teams.Select(x => DbTeam.Create(x)));
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(Guid teamId)
        {
            var team = await (from t in _context.Teams where t.TeamId == teamId select t).FirstAsync();
            _context.Teams.Remove(team);
            await _context.SaveChangesAsync();
        }

        public async Task<List<Team>> GetAsync()
            => await (from t in _context.Teams
                      select new Team(t.TeamId, t.TeamName)).ToListAsync();

        public async Task<Team> GetAsync(Guid teamId)
            => await (from t in _context.Teams
                      where t.TeamId == teamId
                      select new Team(t.TeamId, t.TeamName)).FirstAsync();

        public async Task<Team> GetByName(string name)
            => await (from t in _context.Teams
                      where t.TeamName == name
                      select new Team(t.TeamId, t.TeamName)).FirstOrDefaultAsync();

        public async Task UpdateAsync(Team team)
        {
            var _team = await (from t in _context.Teams where t.TeamId == team.TeamId select t).FirstAsync();
            _team.TeamName = team.TeamName;
            await _context.SaveChangesAsync();
        }
    }
}
