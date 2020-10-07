using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Typer.Application.Queries.MatchPredictions.AreGameweekPredictionsExist
{
    public class AreGameweekPredictionsExistQueryValidator : AbstractValidator<AreGameweekPredictionsExistQuery>
    {
        public AreGameweekPredictionsExistQueryValidator()
        {
            RuleFor(x => x.GameweekId).NotEmpty().WithMessage("brak id kolejki");
            RuleFor(x => x.UserId).NotEmpty().WithMessage("brak id użytkownika");
        }
    }
}
