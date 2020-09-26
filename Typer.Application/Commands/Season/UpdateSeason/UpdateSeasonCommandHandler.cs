using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Typer.Domain.Interfaces;

namespace Typer.API.Commands.Season.UpdateSeason
{
    public class UpdateSeasonCommandHandler : IRequestHandler<UpdateSeasonCommand, Unit>
    {
        private readonly ISeasonRepository _seasonRepository;

        public UpdateSeasonCommandHandler(ISeasonRepository seasonRepository)
        {
            _seasonRepository = seasonRepository;
        }

        public async Task<Unit> Handle(UpdateSeasonCommand request, CancellationToken cancellationToken)
        {
            await _seasonRepository.UpdateAsync(request.SeasonId, request.StartYear, request.EndYear);
            return Unit.Value;
        }
    }
}
