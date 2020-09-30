using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Typer.Domain.Interfaces;

namespace Typer.Application.Commands.Season.CreateSeason
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
            var id = await _seasonRepository.CreateAsync(request.StartYear, request.EndYear);
            return new SeasonDto(id);
        }
    }
}
