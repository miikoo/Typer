using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Typer.Application.Queries.MatchPredictions.AreGameweekPredictionsExist;

namespace Typer.Infrastructure.QueryHandlers.MatchPredictions
{
    public class AreGameweekPredictionsExistQueryHandler : IRequestHandler<AreGameweekPredictionsExistQuery, MatchPredictionDto>
    {
        private readonly TyperContext _context;

        public AreGameweekPredictionsExistQueryHandler(TyperContext context)
        {
            _context = context;
        }

        public async Task<MatchPredictionDto> Handle(AreGameweekPredictionsExistQuery request, CancellationToken cancellationToken)
            => await (from mp in _context.MatchPredictions
                      join m in _context.Matches on new { mp.MatchId, request.GameweekId } equals new { m.MatchId, m.GameweekId }
                      join u in _context.Users on mp.UserId equals u.UserId
                      where mp.UserId == u.UserId && mp.MatchId == m.MatchId && m.GameweekId == request.GameweekId
                      select mp
                      ).AnyAsync() ? new MatchPredictionDto(true) : new MatchPredictionDto(false);
    }
}
