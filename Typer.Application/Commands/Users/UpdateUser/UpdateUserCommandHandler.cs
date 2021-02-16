using MediatR;
using System.Threading;
using System.Threading.Tasks;
using Typer.Application.Services.PasswordHasher;
using Typer.Domain.Enums;
using Typer.Domain.Exceptions;
using Typer.Domain.Interfaces.Repositories;
using Typer.Domain.Models;

namespace Typer.Application.Commands.Users.UpdateUser
{
    public class UpdateUserCommandHandler : IRequestHandler<UpdateUserCommand, Unit>
    {
        private readonly IUserRepository _userRepository;
        private readonly IPasswordHasher _passwordHasher;

        public UpdateUserCommandHandler(IUserRepository userRepository, IPasswordHasher passwordHasher)
        {
            _userRepository = userRepository;
            _passwordHasher = passwordHasher;
        }

        public async Task<Unit> Handle(UpdateUserCommand request, CancellationToken cancellationToken)
        {
            var user = await _userRepository.GetAsync(request.UserId);
            if (!_passwordHasher.Validate(request.Password, user.Salt, user.Password))
                throw new TyperBadRequestException("niepoprawne hasło");
            if (request.NewPassword == null)
            {
                if(request.Email != user.Email)
                {
                    var isExist = await _userRepository.GetUserByEmail(request.Email);
                    if (isExist != null) throw new TyperBadRequestException("Email jest zajęty");
                }
                else
                {
                    var isExist = await _userRepository.GetUserByUsername(request.Username);
                    if (isExist != null) throw new TyperBadRequestException("Login jest zajęty");
                }
                await _userRepository.UpdateAsync(new User(user.UserId, request.Username, request.Email, Roles.User,
                    user.Password, user.Salt));
                return Unit.Value;
            }
            if(request.NewPassword != request.ConfirmNewPassword)
                throw new TyperBadRequestException("Hasła nie są identyczne");
            var hashedPassword = _passwordHasher.GenerateHash(request.NewPassword, user.Salt);
            await _userRepository.UpdateAsync(new User(user.UserId, request.Username, request.Email, Roles.User,
                    hashedPassword, user.Salt));
            return Unit.Value;
        }
    }
}
