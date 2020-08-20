using MediatR;
using System.Threading;
using System.Threading.Tasks;
using Typer.Logic.DtoModels;
using Typer.Logic.Services;

namespace Typer.Logic.Queries.User.GetUser
{
    public class GetUserQueryHandler : IRequestHandler<GetUserQuery, UserDto>
    {
        private readonly IUserService _userService;
        public GetUserQueryHandler(IUserService userService)
        {
            _userService = userService;
        }

        public Task<UserDto> Handle(GetUserQuery request, CancellationToken cancellationToken)
            => _userService.GetUser(request.Username);
    }
}
