using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using Typer.Database;
using Typer.Database.Entities;
using Typer.Logic.DtoModels;

namespace Typer.Logic.Services
{
    public interface IUserService
    {
        Task<UserDto> GetUser(string username);
        Task<UserDto> CreateUser(string username, string email, string password);
    }

    public class UserService : IUserService
    {
        private readonly TyperContext _context;
        public UserService(TyperContext context)
        {
            _context = context;
        }

        public async Task<UserDto> CreateUser(string username, string email, string password)
        {
            var user = new User
            {
                Email = email,
                Password = password,
                Username = username
            };
            await _context.Users.AddAsync(user);
            await _context.SaveChangesAsync();
            return new UserDto(user.UserId, username, email);
        }

        public async Task<UserDto> GetUser(string username)
        {
            var user = await _context.Users.FirstAsync(x => x.Username == username);
            return new UserDto(user.UserId, user.Username, user.Email);
        }
    }
}
