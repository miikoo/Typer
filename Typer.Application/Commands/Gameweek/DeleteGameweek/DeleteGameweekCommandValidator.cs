using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Typer.Application.Commands.Gameweek.DeleteGameweek
{
    public class DeleteGameweekCommandValidator : AbstractValidator<DeleteGameweekCommand>
    {
        public DeleteGameweekCommandValidator()
        {
            RuleFor(x => x.GameweekId).WithMessage("brak id do usunięcia");
        }
    }
}
