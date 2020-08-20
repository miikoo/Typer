using System.Threading.Tasks;
using Typer.Database;
using Typer.Database.Entities;

namespace Typer.Logic.Services
{
    public interface IMatchPredictionService
    {
        Task CreateMatchPrediction(string userId, long matchId, int homeTeamGoals, int awayTeamGoals);
    }

    public class MatchPredictionService : IMatchPredictionService
    {
        private readonly TyperContext _context;

        public MatchPredictionService(TyperContext context)
        {
            _context = context;
        }

        public async Task CreateMatchPrediction(string userId, long matchId, int homeTeamGoals, int awayTeamGoals)
            => await _context.MatchPredictions.AddAsync(new MatchPrediction
            {
                UserId = userId,
                MatchId = matchId,
                AwayTeamGoalPrediction = awayTeamGoals,
                HomeTeamGoalPrediction = homeTeamGoals
            });
    }
}
