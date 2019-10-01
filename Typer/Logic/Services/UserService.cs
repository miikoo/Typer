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
        Task CreateUser(string username, string email, string password);
    }

    public class UserService : IUserService
    {
        private readonly TyperContext _context;
        public UserService(TyperContext context)
        {
            _context = context;
        }

        public async Task CreateUser(string username, string email, string password)
        {
            await _context.Users.AddAsync(new User
            {
                Email = email,
                Password = password,
                Username = username
            });
            await _context.SaveChangesAsync();
        }

        public async Task<UserDto> GetUser(string username)
        {
            var user = await _context.Users.FirstAsync(x => x.Username == username);
            return new UserDto(user.UserId, user.Username, user.Email, user.Password);
        }
    }
}
