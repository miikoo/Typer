using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Typer.Application.Commands.Gameweeks.UpdateGameweek
{
    public class UpdateGameweekCommandValidator : AbstractValidator<UpdateGameweekCommand>
    {
        public UpdateGameweekCommandValidator()
        {
            RuleFor(x => x.GameweekId).NotEmpty().WithMessage("brak podanego gameweekId ");
            RuleFor(x => x.GameweekNumber).InclusiveBetween(1,50).WithMessage("zły numer kolejki");
        }
    }
}
