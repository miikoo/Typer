using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Threading.Tasks;
using Typer.Database;
using Typer.Database.Entities;
using Typer.Logic.DtoModels;
using static Typer.Database.Entities.User;

namespace Typer.Logic.Services
{
    public interface IUserService
    {
        Task<UserDto> GetUser(string username);
        Task<UserDto> CreateUser(string username, string email, string password);
        Task<UserDto> Authenticate(string username, string password);
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
                Username = username,
                Role = Roles.User
            };
            var isUserExist =  await _context.Users.Where(x => x.Email == email).ToListAsync();
            if (isUserExist.Any())
                throw new Exception("użytkownik z podanym adresem email istnieje");
            await _context.Users.AddAsync(user);
            await _context.SaveChangesAsync();
            return new UserDto(user.UserId, username, email);
        }

        public async Task<UserDto> GetUser(string username)
        {
            var user = await _context.Users.FirstAsync(x => x.Username == username);
            return new UserDto(user.UserId, user.Username, user.Email);
        }
        public async Task<UserDto> Authenticate(string username, string password)
        {
            var user = await _context.Users.FirstAsync(x => x.Username == username && x.Password == password);
            return new UserDto
            {
                Email = user.Email,
                UserId = user.UserId,
                Username = user.Username,
                Role = user.Role
            };
        }
    }
}
