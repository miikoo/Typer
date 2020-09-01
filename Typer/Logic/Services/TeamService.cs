using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Typer.Database;
using Typer.Database.Entities;
using Typer.Logic.DtoModels;

namespace Typer.Logic.Services
{
    public interface ITeamService
    {
        Task<TeamDto> CreateTeam(string teamName);
        Task<List<TeamDto>> GetTeams();
        Task DeleteTeam(long teamId);
    }

    public class TeamService : ITeamService
    {
        private readonly TyperContext _context;

        public TeamService(TyperContext context)
        {
            _context = context;
        }

        public async Task<TeamDto> CreateTeam(string teamName)
        {
            var team = new Team
            {
                TeamName = teamName
            };
            await _context.AddAsync(team);
            await _context.SaveChangesAsync();
            return new TeamDto
            {
                TeamId = team.TeamId,
                TeamName = team.TeamName
            };
        }

        public async Task DeleteTeam(long teamId)
        {
            var team = await _context.Teams.FirstAsync(x => x.TeamId == teamId);
            _context.Teams.Remove(team);
            await _context.SaveChangesAsync();
        }

        public async Task<List<TeamDto>> GetTeams()
            => await _context.Teams.Select(x => new TeamDto
            {
                TeamId = x.TeamId,
                TeamName = x.TeamName
            }).ToListAsync();
    }
}
