using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Typer.Application.Commands.Match.UpdateMatchDetails
{
    public class UpdateMatchDetailsCommandValidator : AbstractValidator<UpdateMatchDetailsCommand>
    {
        public UpdateMatchDetailsCommandValidator()
        {
            RuleFor(x => x.MatchId).NotEmpty().WithMessage("brak id meczu");
            RuleFor(x => x.MatchDate).NotEmpty().WithMessage("brak daty meczu");
            RuleFor(x => x.HomeTeamId).NotEmpty().WithMessage("brak id gospodarza");
            RuleFor(x => x.AwayTeamId).NotEmpty().WithMessage("brak id przyjezdnych");
        }
    }
}
