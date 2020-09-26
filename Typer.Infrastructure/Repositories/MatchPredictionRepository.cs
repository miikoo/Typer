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
    public class MatchPredictionRepository : IMatchPredictionRepository
    {
        private readonly TyperContext _context;

        public MatchPredictionRepository(TyperContext context)
        {
            _context = context;
        }

        public async Task<long> CreateAsync(int homeTeamGoalPrediction, int awayTeamGoalPrediction, Guid userId, long matchId)
        {
            var prediction = new DbMatchPrediction
            {
                HomeTeamGoalPrediction = homeTeamGoalPrediction,
                AwayTeamGoalPrediction = awayTeamGoalPrediction,
                MatchId = matchId,
                UserId = userId
            };
            await _context.AddAsync(prediction);
            await _context.SaveChangesAsync();
            return prediction.MatchPredictionId;
        }

        public async Task DeleteAsync(long matchPredictionId)
        {
            var prediction = await (from m in _context.MatchPredictions
                                    where m.MatchPredictionId == matchPredictionId
                                    select m).FirstAsync();
            _context.MatchPredictions.Remove(prediction);
            await _context.SaveChangesAsync();
        }

        public async Task<MatchPrediction> GetAsync(long matchPredictionId)
            => await (from m in _context.MatchPredictions
                      where m.MatchPredictionId == matchPredictionId
                      select new MatchPrediction
                      {
                          AwayTeamGoalPrediction = m.AwayTeamGoalPrediction,
                          HomeTeamGoalPrediction = m.HomeTeamGoalPrediction,
                          MatchPredictionId = m.MatchPredictionId

                      }).FirstAsync();

        public async Task<List<MatchPrediction>> GetAsync(Guid userId)
            => await (from m in _context.MatchPredictions
                      where m.UserId == userId
                      select new MatchPrediction
                      {
                          AwayTeamGoalPrediction = m.AwayTeamGoalPrediction,
                          HomeTeamGoalPrediction = m.HomeTeamGoalPrediction,
                          MatchPredictionId = m.MatchPredictionId
                      }).ToListAsync();

        public async Task UpdateAsync(int homeTeamGoalPrediction, int awayTeamGoalPrediction, long matchPredictionId)
        {
            var prediction = await (from m in _context.MatchPredictions
                                    where m.MatchPredictionId == matchPredictionId
                                    select m).FirstAsync();
            prediction.HomeTeamGoalPrediction = homeTeamGoalPrediction;
            prediction.AwayTeamGoalPrediction = awayTeamGoalPrediction;
            await _context.SaveChangesAsync();
        }
    }
}
