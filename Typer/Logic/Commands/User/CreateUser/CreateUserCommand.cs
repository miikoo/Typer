using MediatR;
using Typer.Logic.DtoModels;

namespace Typer.Logic.Commands.User.CreateUser
{
    public class CreateUserCommand : IRequest<UserDto>
    {
        public string Username { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
    }
}
