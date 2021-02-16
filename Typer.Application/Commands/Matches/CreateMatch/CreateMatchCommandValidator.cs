using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Typer.Application.Commands.Matches.CreateMatch
{
    public class CreateMatchCommandValidator : AbstractValidator<CreateMatchCommand>
    {
        public CreateMatchCommandValidator()
        {
            RuleFor(x => x.AwayTeamId).NotEmpty().WithMessage("brak przyjezdnego");
            RuleFor(x => x.AwayTeamId).NotEmpty().WithMessage("brak gospodarza");
            RuleFor(x => x.GameweekId).NotEmpty().WithMessage("brak numeru kolejki");
            RuleFor(x => x.MatchDate).NotEmpty().WithMessage("brak daty spotkania");
        }
    }
}
