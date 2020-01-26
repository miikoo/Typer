using MediatR;
using Typer.Logic.DtoModels;

namespace Typer.Logic.Queries.User.GetUser
{
    public class GetUserQuery : IRequest<UserDto>
    {
        public string Username { get; set; }
    }
}