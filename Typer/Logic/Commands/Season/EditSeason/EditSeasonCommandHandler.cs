using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Typer.Logic.DtoModels;
using Typer.Logic.Services;

namespace Typer.Logic.Commands.Season.EditSeason
{
    public class EditSeasonCommandHandler : IRequestHandler<EditSeasonCommand, SeasonDto>
    {
        private readonly ISeasonService _seasonService;

        public EditSeasonCommandHandler(ISeasonService seasonService)
        {
            _seasonService = seasonService;
        }

        public async Task<SeasonDto> Handle(EditSeasonCommand request, CancellationToken cancellationToken)
        {
            return await _seasonService.EditSeason(request.StartYear, request.EndYear, request.SeasonId);
        }
    }
}
