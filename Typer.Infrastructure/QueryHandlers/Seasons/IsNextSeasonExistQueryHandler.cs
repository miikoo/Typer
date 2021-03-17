using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Typer.Application.Queries.Seasons.IsNextSeasonExist;
using Typer.Domain.Interfaces.Repositories;

namespace Typer.Infrastructure.QueryHandlers.Seasons
{
    public class IsNextSeasonExistQueryHandler : IRequestHandler<IsNextSeasonExistQuery, SeasonDto>
    {
        private readonly TyperContext _context;

        public IsNextSeasonExistQueryHandler(TyperContext context)
        {
            _context = context;
        }
        public async Task<SeasonDto> Handle(IsNextSeasonExistQuery request, CancellationToken cancellationToken)
            => new SeasonDto(await (from m in _context.Matches
                                        where m.MatchDate > DateTime.UtcNow
                                        select m).AnyAsync());
    }
}
