using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Typer.Domain.Interfaces;

namespace Typer.Application.Commands.User.Authenticate
{
    public class AuthenticateCommandHandler : IRequestHandler<AuthenticateCommand, string>
    {
        private readonly IUserRepository _userRepository;

        public AuthenticateCommandHandler(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public Task<string> Handle(AuthenticateCommand request, CancellationToken cancellationToken)
            => _userRepository.Authenticate(request.Username, request.Password);
    }
}
