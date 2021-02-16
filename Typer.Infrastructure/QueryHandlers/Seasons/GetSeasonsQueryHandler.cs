using MediatR;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Typer.API.Queries.Seasons.GetSeasonQuery;
using Typer.Application.Client.PLClient;

namespace Typer.Infrastructure.QueryHandlers.Seasons
{
    public class GetSeasonsQueryHandler : IRequestHandler<GetSeasonsQuery, List<SeasonDto>>
    {
        private readonly TyperContext _context;

        public GetSeasonsQueryHandler(TyperContext context)
        {
            _context = context;
        }

        public async Task<List<SeasonDto>> Handle(GetSeasonsQuery request, CancellationToken cancellationToken)
            => await (from s in _context.Seasons
                    select new SeasonDto(s.SeasonId, s.StartYear, s.EndYear))
            .ToListAsync();
    }
}
