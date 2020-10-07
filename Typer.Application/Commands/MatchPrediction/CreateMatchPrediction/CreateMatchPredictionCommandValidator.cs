using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Typer.Application.Commands.MatchPrediction.CreateMatchPrediction
{
    public class CreateMatchPredictionCommandValidator : AbstractValidator<CreateMatchPredictionCommand>
    {
        public CreateMatchPredictionCommandValidator()
        {
            RuleFor(x => x.MatchId).NotEmpty().WithMessage("brak id meczu");
            RuleFor(x => x.UserId).NotEmpty().WithMessage("brak id użytkownika");
        }
    }
}
