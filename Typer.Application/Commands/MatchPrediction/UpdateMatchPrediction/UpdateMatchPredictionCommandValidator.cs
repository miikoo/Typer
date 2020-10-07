using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Typer.Application.Commands.MatchPrediction.UpdateMatchPrediction
{
    public class UpdateMatchPredictionCommandValidator : AbstractValidator<UpdateMatchPredictionCommand>
    {
        public UpdateMatchPredictionCommandValidator()
        {
            RuleFor(x => x.MatchPredictionId).NotEmpty().WithMessage("brak id typu");
        }
    }
}
