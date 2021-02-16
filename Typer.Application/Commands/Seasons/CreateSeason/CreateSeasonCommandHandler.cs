using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Typer.Domain.Interfaces.Repositories;
using Typer.Domain.Models;

namespace Typer.Application.Commands.Seasons.CreateSeason
{
    public class CreateSeasonCommandHandler : IRequestHandler<CreateSeasonCommand, SeasonDto>
    {
        private readonly ISeasonRepository _seasonRepository;

        public CreateSeasonCommandHandler(ISeasonRepository seasonRepository)
        {
            _seasonRepository = seasonRepository;
        }

        public async Task<SeasonDto> Handle(CreateSeasonCommand request, CancellationToken cancellationToken)
        {
            var season = Season.Create(request.StartYear, request.EndYear);
            await _seasonRepository.CreateAsync(season);
            return new SeasonDto(season.SeasonId);
        }
    }
}
