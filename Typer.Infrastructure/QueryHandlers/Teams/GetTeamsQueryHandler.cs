using MediatR;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Typer.Application.Queries.Teams.GetTeamsQuery;

namespace Typer.Infrastructure.QueryHandlers.Teams
{
    public class GetTeamsQueryHandler : IRequestHandler<GetTeamsQuery, List<TeamDto>>
    {
        private readonly TyperContext _context;

        public GetTeamsQueryHandler(TyperContext context)
        {
            _context = context;
        }

        public async Task<List<TeamDto>> Handle(GetTeamsQuery request, CancellationToken cancellationToken)
            => await(from t in _context.Teams
                     select new TeamDto
                     {
                         TeamId = t.TeamId,
                         TeamName = t.TeamName
                     }).ToListAsync();
    }
}
