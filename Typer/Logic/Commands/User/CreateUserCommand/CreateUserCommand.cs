using MediatR;

namespace Typer.Logic.Commands.User.CreateUserCommand
{
    public class CreateUserCommand : IRequest<Unit>
    {
        public string Username { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
    }
}
