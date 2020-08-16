namespace Typer.Logic.DtoModels
{
    public class UserDto
    {
        public UserDto()
        {

        }
        public UserDto(string userId, string username, string email, string token=null)
        {
            UserId = userId;
            Username = username;
            Email = email;
            Token = token;
        }

        public string UserId { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public string Token { get; set; }
    }
}
