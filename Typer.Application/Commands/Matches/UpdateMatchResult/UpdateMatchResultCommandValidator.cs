using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Typer.Application.Commands.Matches.UpdateMatchResult
{
    public class UpdateMatchResultCommandValidator : AbstractValidator<UpdateMatchResultCommand>
    {
        public UpdateMatchResultCommandValidator()
        {
            RuleFor(x => x.MatchId).NotEmpty().WithMessage("brak id meczu");
            RuleFor(x => x.HomeTeamGoals).InclusiveBetween(0,15).WithMessage("zła liczba goli gospodarzy");
            RuleFor(x => x.AwayTeamGoals).InclusiveBetween(0,15).WithMessage("zła liczba goli przyjezdnych");
        }
    }
}
