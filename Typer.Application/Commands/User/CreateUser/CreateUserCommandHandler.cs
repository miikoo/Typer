using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Typer.Application.Services;
using Typer.Application.Services.PasswordHasher;
using Typer.Domain.Interfaces;

namespace Typer.Application.Commands.User.CreateUser
{
    public class CreateUserCommandHandler : IRequestHandler<CreateUserCommand, Unit>
    {
        private readonly IUserRepository _userRepository;
        private readonly IPasswordHasher _passwordHasher;

        public CreateUserCommandHandler(IUserRepository userRepository, IPasswordHasher passwordHasher)
        {
            _userRepository = userRepository;
            _passwordHasher = passwordHasher;
        }

        public async Task<Unit> Handle(CreateUserCommand request, CancellationToken cancellationToken)
        {
            var salt = _passwordHasher.GenerateSalt();
            var hashedPassword = _passwordHasher.GenerateHash(request.Password, salt);

            var user = await _userRepository.GetUserByUsername(request.Username);
            if (user != null) throw new Exception("userExist");
            user = await _userRepository.GetUserByEmail(request.Email);
            if (user != null) throw new Exception("emailExist");

            await _userRepository.CreateAsync(request.Username, request.Email, hashedPassword, salt);
            return Unit.Value;
        }
    }
}
