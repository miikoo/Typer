using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Typer.Application.Commands.Matches.DeleteMatch
{
    public class DeleteMatchCommandValidator : AbstractValidator<DeleteMatchCommand>
    {
        public DeleteMatchCommandValidator()
        {
            RuleFor(x => x.MatchId).NotEmpty().WithMessage("brak id meczu");
        }
    }
}
