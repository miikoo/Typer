using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Typer.Application.Queries.Matches.GetMatchesByGameweekId
{
    public class GetMatchesByGameweekIdQueryValidator : AbstractValidator<GetMatchesByGameweekIdQuery>
    {
        public GetMatchesByGameweekIdQueryValidator()
        {
            RuleFor(x => x.GameweekId).NotEmpty().WithMessage("brak id kolejki");
        }
    }
}
