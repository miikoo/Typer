using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Typer.Application.Queries.Gameweek.GetGameweeksBySeasonId
{
    public class GetGameweeksBySeasonIdQueryValidator : AbstractValidator<GetGameweeksBySeasonIdQuery>
    {
        public GetGameweeksBySeasonIdQueryValidator()
        {
            RuleFor(x => x.SeasonId).NotEmpty().WithMessage("brak id sezonu");
        }
    }
}
