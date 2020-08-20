using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Typer.Logic.DtoModels;
using Typer.Logic.Services;

namespace Typer.Logic.Commands.User.Authenticate
{
    public class AuthenticateCommandHandler : IRequestHandler<AuthenticateCommand, UserDto>
    {
        private readonly IUserService _userService;
        private readonly IJwtGenerator _jwtGenerator;

        public AuthenticateCommandHandler(IUserService userService, IJwtGenerator jwtGenerator)
        {
            _userService = userService;
            _jwtGenerator = jwtGenerator;
        }

        public async Task<UserDto> Handle(AuthenticateCommand request, CancellationToken cancellationToken)
        {
            var user = await _userService.Authenticate(request.Username, request.Password);
            user.Token = _jwtGenerator.Generate(user.UserId, user.Role);
            return user;
        }
    }
}
