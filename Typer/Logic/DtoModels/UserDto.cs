using static Typer.Database.Entities.User;

namespace Typer.Logic.DtoModels
{
    public class UserDto
    {
        public UserDto()
        {

        }
        public UserDto(string userId, string username, string email, Roles role=Roles.User, string token= null)
        {
            UserId = userId;
            Username = username;
            Email = email;
            Token = token;
            Role = role;
        }

        public string UserId { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public string Token { get; set; }
        public Roles Role { get; set; }
    }
}
