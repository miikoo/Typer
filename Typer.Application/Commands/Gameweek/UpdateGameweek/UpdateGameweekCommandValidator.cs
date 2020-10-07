using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Typer.Application.Commands.Gameweek.UpdateGameweek
{
    public class UpdateGameweekCommandValidator : AbstractValidator<UpdateGameweekCommand>
    {
        public UpdateGameweekCommandValidator()
        {
            RuleFor(x => x.GameweekId).NotEmpty().WithMessage("brak podanego gameweekId ");
            RuleFor(x => x.GameweekNumber).InclusiveBetween(0,50).WithMessage("zły numer kolejki");
        }
    }
}
