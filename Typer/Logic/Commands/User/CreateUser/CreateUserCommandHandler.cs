using MediatR;
using System.Threading;
using System.Threading.Tasks;
using Typer.Logic.DtoModels;
using Typer.Logic.Services;

namespace Typer.Logic.Commands.User.CreateUser
{
    public class CreateUserCommandHandler : IRequestHandler<CreateUserCommand, UserDto>
    {
        private readonly IUserService _userService;
        private readonly IJwtGenerator _jwtGenerator;
        public CreateUserCommandHandler(IUserService userService, IJwtGenerator jwtGenerator)
        {
            _userService = userService;
            _jwtGenerator = jwtGenerator;
        }

        public async Task<UserDto> Handle(CreateUserCommand request, CancellationToken cancellationToken)
        {
            var user = await _userService.CreateUser(request.Username, request.Email, request.Password);
            user.Token = _jwtGenerator.Generate(user.UserId, user.Role);
            return user;
        }
    }
}
