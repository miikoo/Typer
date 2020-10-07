using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Typer.Application.Commands.Season.CreateSeason
{
    public class CreateSeasonCommandValidator : AbstractValidator<CreateSeasonCommand>
    {
        public CreateSeasonCommandValidator()
        {
            RuleFor(x => x.EndYear).ExclusiveBetween(2000, 2030).WithMessage("zły numer końca sezonu");
            RuleFor(x => x.StartYear).ExclusiveBetween(2000, 2030).WithMessage("zły numer startu sezonu");
        }
    }
}
