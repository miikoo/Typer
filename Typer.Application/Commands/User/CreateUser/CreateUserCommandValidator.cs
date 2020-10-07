using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Typer.Application.Commands.User.CreateUser
{
    public class CreateUserCommandValidator : AbstractValidator<CreateUserCommand>
    {
        public CreateUserCommandValidator()
        {
            RuleFor(x => x.Email).EmailAddress().WithMessage("niepoprawny email");
            RuleFor(x => x.Password).MinimumLength(6).WithMessage("zbyt krótkie hasło");
            RuleFor(x => x.Username).MinimumLength(4).WithMessage("zbyt krótka nazwa użytkownika");
        }
    }
}
