using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Typer.Application.Commands.Gameweeks.DeleteGameweek
{
    public class DeleteGameweekCommandValidator : AbstractValidator<DeleteGameweekCommand>
    {
        public DeleteGameweekCommandValidator()
        {
            RuleFor(x => x.GameweekId).NotEmpty().WithMessage("brak id do usunięcia");
        }
    }
}
