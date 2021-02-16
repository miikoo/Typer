using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Typer.Domain.Interfaces.Repositories;

namespace Typer.Application.Commands.Seasons.DeleteSeason
{
    public class DeleteSeasonCommandHandler : IRequestHandler<DeleteSeasonCommand, Unit>
    {
        private readonly ISeasonRepository _seasonRepository;

        public DeleteSeasonCommandHandler(ISeasonRepository seasonRepository)
        {
            _seasonRepository = seasonRepository;
        }

        public async Task<Unit> Handle(DeleteSeasonCommand request, CancellationToken cancellationToken)
        {
            await _seasonRepository.DeleteAsync(request.SeasonId);
            return Unit.Value;
        }
    }
}
