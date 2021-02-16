using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Typer.Application.Services;
using Typer.Application.Services.JwtGenerator;
using Typer.Application.Services.PasswordHasher;
using Typer.Domain.Exceptions;
using Typer.Domain.Interfaces.Repositories;

namespace Typer.Application.Commands.Users.CreateUser
{
    public class CreateUserCommandHandler : IRequestHandler<CreateUserCommand, UserDto>
    {
        private readonly IUserRepository _userRepository;
        private readonly IPasswordHasher _passwordHasher;
        private readonly IJwtGenerator _jwtGenerator;

        public CreateUserCommandHandler(IUserRepository userRepository, IPasswordHasher passwordHasher, IJwtGenerator jwtGenerator)
        {
            _userRepository = userRepository;
            _passwordHasher = passwordHasher;
            _jwtGenerator = jwtGenerator;
        }

        public async Task<UserDto> Handle(CreateUserCommand request, CancellationToken cancellationToken)
        {
            var salt = _passwordHasher.GenerateSalt();
            var hashedPassword = _passwordHasher.GenerateHash(request.Password, salt);

            var user = await _userRepository.GetUserByUsername(request.Username);
            if (user != null) throw new TyperBadRequestException("Login jest zajęty");
            user = await _userRepository.GetUserByEmail(request.Email);
            if (user != null) throw new TyperBadRequestException("Email jest zajęty");
            var newUser = Domain.Models.User.Create(request.Username, request.Email,Domain.Enums.Roles.User, hashedPassword, salt);
            await _userRepository.CreateAsync(newUser);
            var token = _jwtGenerator.Generate(newUser.UserId, newUser.Role);
            return new UserDto(token, newUser.UserId);
        }
    }
}
