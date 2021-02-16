using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Typer.Application.Commands.Seasons.UpdateSeason
{
    public class UpdateSeasonCommandValidator : AbstractValidator<UpdateSeasonCommand>
    {
        public UpdateSeasonCommandValidator()
        {
            RuleFor(x => x.EndYear).InclusiveBetween(2000, 2030).WithMessage("zły numer końca sezonu");
            RuleFor(x => x.StartYear).InclusiveBetween(2000, 2030).WithMessage("zły numer początku sezonu");
            RuleFor(x => x.SeasonId).NotEmpty().WithMessage("brak id sezonu");
        }
    }
}
