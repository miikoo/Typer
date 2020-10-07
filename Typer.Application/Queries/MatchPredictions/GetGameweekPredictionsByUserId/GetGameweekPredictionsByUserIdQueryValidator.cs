using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Typer.Application.Queries.MatchPredictions.GetGameweekPredictionsByUserId
{
    public class GetGameweekPredictionsByUserIdQueryValidator : AbstractValidator<GetGameweekPredictionsByUserIdQuery>
    {
        public GetGameweekPredictionsByUserIdQueryValidator()
        {
            RuleFor(x => x.GameweekId).NotEmpty().WithMessage("brak id kolejki");
            RuleFor(x => x.UserId).NotEmpty().WithMessage("brak id użytkownika");
        }
    }
}
