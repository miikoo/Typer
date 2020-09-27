using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Typer.Domain.Interfaces;

namespace Typer.Application.Commands.User.Authenticate
{
    public class AuthenticateCommandHandler : IRequestHandler<AuthenticateCommand, UserDto>
    {
        private readonly IUserRepository _userRepository;

        public AuthenticateCommandHandler(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public async Task<UserDto> Handle(AuthenticateCommand request, CancellationToken cancellationToken)
        {
            var token = await _userRepository.Authenticate(request.Username, request.Password);
            return new UserDto
            {
                Token = token
            };
        }
    }
}
