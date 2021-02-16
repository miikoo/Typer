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
    public class MatchPredictionRepository : IMatchPredictionRepository
    {
        private readonly TyperContext _context;

        public MatchPredictionRepository(TyperContext context)
        {
            _context = context;
        }

        public async Task CreateAsync(params MatchPrediction[] matchPredictions)
        {
            await _context.AddRangeAsync(matchPredictions.Select(x => DbMatchPrediction.Create(x)));
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(Guid matchPredictionId)
        {
            var prediction = await (from m in _context.MatchPredictions
                                    where m.MatchPredictionId == matchPredictionId
                                    select m).FirstAsync();
            _context.MatchPredictions.Remove(prediction);
            await _context.SaveChangesAsync();
        }

        public async Task<MatchPrediction> GetAsync(Guid matchPredictionId)
            => await (from m in _context.MatchPredictions
                      where m.MatchPredictionId == matchPredictionId
                      select new MatchPrediction(m.MatchPredictionId, m.HomeTeamGoalPrediction, m.AwayTeamGoalPrediction,
                          m.MatchId, m.UserId)).FirstAsync();

        public async Task<List<MatchPrediction>> GetByUserIdAsync(Guid userId)
            => await (from m in _context.MatchPredictions
                      where m.UserId == userId
                      select new MatchPrediction(m.MatchPredictionId, m.HomeTeamGoalPrediction, m.AwayTeamGoalPrediction,
                          m.MatchId, m.UserId)).ToListAsync();

        public async Task UpdateAsync(MatchPrediction matchPrediction)
        {
            var prediction = await (from m in _context.MatchPredictions
                                    where m.MatchPredictionId == matchPrediction.MatchPredictionId
                                    select m).FirstAsync();
            prediction.HomeTeamGoalPrediction = matchPrediction.HomeTeamGoalPrediction;
            prediction.AwayTeamGoalPrediction = matchPrediction.AwayTeamGoalPrediction;
            await _context.SaveChangesAsync();
        }

        public async Task UpdateManyAsync(params Tuple<Guid,int?,int?>[] matchPredictions)
        {
            var predictions = (from mp in _context.MatchPredictions
                               where matchPredictions.Select(x => x.Item1).Contains(mp.MatchPredictionId)
                               select mp);
            predictions.ToList().ForEach(x =>
            {
                var prediction = matchPredictions.First(y => y.Item1 == x.MatchPredictionId);
                x.HomeTeamGoalPrediction = prediction.Item2;
                x.AwayTeamGoalPrediction = prediction.Item3;
            });
            await _context.SaveChangesAsync();
        }
    }
}
