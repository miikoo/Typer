using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Typer.Application.Services.JwtGenerator;
using Typer.Application.Services.PasswordHasher;
using Typer.Domain.Interfaces;

namespace Typer.Application.Commands.User.Authenticate
{
    public class AuthenticateCommandHandler : IRequestHandler<AuthenticateCommand, UserDto>
    {
        private readonly IUserRepository _userRepository;
        private readonly IJwtGenerator _jwtGenerator;
        private readonly IPasswordHasher _passwordHasher;

        public AuthenticateCommandHandler(IUserRepository userRepository, IJwtGenerator jwtGenerator, IPasswordHasher passwordHasher)
        {
            _userRepository = userRepository;
            _jwtGenerator = jwtGenerator;
            _passwordHasher = passwordHasher;
        }

        public async Task<UserDto> Handle(AuthenticateCommand request, CancellationToken cancellationToken)
        {
            var user = await _userRepository.GetUserByUsername(request.Username);
            var hashedPassword = _passwordHasher.GenerateHash(request.Password, user.Salt);
            var token = _jwtGenerator.Generate(user.UserId, user.Role);
            if (_passwordHasher.GenerateHash(request.Password, user.Salt) == user.Password)
                return new UserDto(user.Username, user.Role, user.UserId, token);
            throw new Exception("niepoprawne dane");
        }
    }
}
