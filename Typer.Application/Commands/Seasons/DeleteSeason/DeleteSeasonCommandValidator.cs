using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Typer.Application.Commands.Seasons.DeleteSeason
{
    public class DeleteSeasonCommandValidator : AbstractValidator<DeleteSeasonCommand>
    {
        public DeleteSeasonCommandValidator()
        {
            RuleFor(x => x.SeasonId).NotEmpty().WithMessage("brak id sezonu");
        }
    }
}
