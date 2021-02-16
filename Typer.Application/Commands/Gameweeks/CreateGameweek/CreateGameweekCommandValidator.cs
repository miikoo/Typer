using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Typer.Application.Commands.Gameweeks.CreateGameweek
{
    public class CreateGameweekCommandValidator : AbstractValidator<CreateGameweekCommand>
    {
        public CreateGameweekCommandValidator()
        {
            RuleFor(x => x.SeasonId).NotEmpty().WithMessage("seasonId nie może być puste");
            RuleFor(x => x.GameweekNumber).InclusiveBetween(1,50).WithMessage("zły numer kolejki");
        }
    }
}
