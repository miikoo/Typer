using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Typer.Logic.Services;

namespace Typer.Logic.Commands.Season.DeleteSeason
{
    public class DeleteSeasonCommandHandler : IRequestHandler<DeleteSeasonCommand, Unit>
    {
        private readonly ISeasonService _seasonService;

        public DeleteSeasonCommandHandler(ISeasonService seasonService)
        {
            _seasonService = seasonService;
        }

        public async Task<Unit> Handle(DeleteSeasonCommand request, CancellationToken cancellationToken)
        {
            await _seasonService.DeleteSeason(request.seasonId);
            return Unit.Value;
        }
    }
}
