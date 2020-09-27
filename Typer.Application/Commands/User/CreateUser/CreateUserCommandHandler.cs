using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Typer.Application.Services;
using Typer.Domain.Interfaces;

namespace Typer.Application.Commands.User.CreateUser
{
    public class CreateUserCommandHandler : IRequestHandler<CreateUserCommand, UserDto>
    {
        private readonly IUserRepository _userRepository;
        private readonly IJwtGenerator _jwtGenerator;

        public CreateUserCommandHandler(IUserRepository userRepository, IJwtGenerator jwtGenerator)
        {
            _userRepository = userRepository;
            _jwtGenerator = jwtGenerator;
        }

        public async Task<UserDto> Handle(CreateUserCommand request, CancellationToken cancellationToken)
        {
            var userId = await _userRepository.CreateAsync(request.Username, request.Email, request.Password);
            var user = await _userRepository.GetAsync(userId);
            var token = _jwtGenerator.Generate(userId, user.Role);
            return new UserDto
            {
                Token = token
            };
        }
    }
}
