using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Typer.Logic.DtoModels;
using Typer.Logic.Services;

namespace Typer.Logic.Queries.Seasons.GetSeasons
{
    public class GetSeasonsQueryHandler : IRequestHandler<GetSeasonsQuery, List<SeasonDto>>
    {
        private readonly ISeasonService _seasonService;

        public GetSeasonsQueryHandler(ISeasonService seasonService)
        {
            _seasonService = seasonService;
        }

        public async Task<List<SeasonDto>> Handle(GetSeasonsQuery request, CancellationToken cancellationToken)
            => await _seasonService.GetSeasons();
    }
}
