using MediatR;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Typer.Application.Queries.MatchPredictions.GetGameweekPredictionsByUserId;

namespace Typer.Infrastructure.QueryHandlers.MatchPredictions
{
    public class GetGameweekPredictionsByUserIdQueryHandler : IRequestHandler<GetGameweekPredictionsByUserIdQuery, List<MatchPredictionDto>>
    {
        private readonly TyperContext _context;

        public GetGameweekPredictionsByUserIdQueryHandler(TyperContext context)
        {
            _context = context;
        }

        public async Task<List<MatchPredictionDto>> Handle(GetGameweekPredictionsByUserIdQuery request, CancellationToken cancellationToken)
        {
            var teams =  (from t in _context.Teams select t).ToList();

            var matches = await (from m in _context.Matches
                                 where m.GameweekId == request.GameweekId
                                 select m).ToListAsync();

            var predictions = (from m in matches
                                     join mp in _context.MatchPredictions on m.MatchId equals mp.MatchId
                                     where mp.UserId == request.UserId
                                     select mp).ToList();

            List<MatchPredictionDto> result = new List<MatchPredictionDto>();
            foreach(var m in matches)
            {
                var prediction = predictions.FirstOrDefault(x => x.MatchId == m.MatchId);
                var ht = teams.First(x => x.TeamId == m.HomeTeamId).TeamName;
                var at = teams.First(x => x.TeamId == m.AwayTeamId).TeamName;
                result.Add(prediction == null ? new MatchPredictionDto(null, m.HomeTeamGoals, m.AwayTeamGoals, ht, at, null, null, m.MatchDate)
                    : new MatchPredictionDto(prediction.MatchPredictionId, m.HomeTeamGoals, m.AwayTeamGoals, ht, at,
                    prediction.HomeTeamGoalPrediction, prediction.AwayTeamGoalPrediction, m.MatchDate));
            }

            return result;

            //return await (from mp in _context.MatchPredictions
            //    join m in _context.Matches on new { request.GameweekId, mp.MatchId } equals new { m.GameweekId, m.MatchId }
            //    where mp.UserId == request.UserId && m.GameweekId == request.GameweekId
            //    select new MatchPredictionDto(mp.MatchPredictionId, m.HomeTeamGoals, m.AwayTeamGoals,
            //    teams.Where(x => x.TeamId == m.HomeTeamId).FirstOrDefault().TeamName,
            //    teams.Where(x => x.TeamId == m.AwayTeamId).FirstOrDefault().TeamName,
            //    mp.HomeTeamGoalPrediction, mp.AwayTeamGoalPrediction, m.MatchDate)).ToListAsync();

        }
    }
}
