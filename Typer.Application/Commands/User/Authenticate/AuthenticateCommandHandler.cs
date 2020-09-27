using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Typer.Application.Services;
using Typer.Domain.Interfaces;

namespace Typer.Application.Commands.User.Authenticate
{
    public class AuthenticateCommandHandler : IRequestHandler<AuthenticateCommand, UserDto>
    {
        private readonly IUserRepository _userRepository;
        private readonly IJwtGenerator _jwtGenerator;

        public AuthenticateCommandHandler(IUserRepository userRepository, IJwtGenerator jwtGenerator)
        {
            _userRepository = userRepository;
            _jwtGenerator = jwtGenerator;
        }

        public async Task<UserDto> Handle(AuthenticateCommand request, CancellationToken cancellationToken)
        {
            var userId = await _userRepository.AuthenticateAsync(request.Username, request.Password);
            var user = await _userRepository.GetAsync(userId);
            var token = _jwtGenerator.Generate(userId, user.Role);
            return new UserDto
            {
                Token = token
            };
        }
    }
}
