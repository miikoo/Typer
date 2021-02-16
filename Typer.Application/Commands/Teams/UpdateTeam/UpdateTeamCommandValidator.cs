using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Typer.Application.Commands.Teams.UpdateTeam
{
    public class UpdateTeamCommandValidator : AbstractValidator<UpdateTeamCommand>
    {
        public UpdateTeamCommandValidator()
        {
            RuleFor(x => x.TeamId).NotEmpty().WithMessage("brak id zespołu");
            RuleFor(x => x.TeamName).Length(4, 30).WithMessage("zła długość nazwy zespołu");
        }
    }
}
