using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Typer.Application.Commands.Teams.DeleteTeam
{
    public class DeleteTeamCommandValidator : AbstractValidator<DeleteTeamCommand>
    {
        public DeleteTeamCommandValidator()
        {
            RuleFor(x => x.TeamId).NotEmpty().WithMessage("brak id zespołu");
        }
    }
}
