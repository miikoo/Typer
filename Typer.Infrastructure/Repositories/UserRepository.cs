using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Threading.Tasks;
using Typer.Application.Services.JwtGenerator;
using Typer.Domain.Enums;
using Typer.Domain.Interfaces.Repositories;
using Typer.Domain.Models;
using Typer.Infrastructure.Entities;

namespace Typer.Infrastructure.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly TyperContext _context;

        public UserRepository(TyperContext context, IJwtGenerator jwtGenerator)
        {
            _context = context;
        }

        public async Task CreateAsync(User user)
        {
            await _context.Users.AddAsync(DbUser.Create(user));
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(Guid userId)
        {
            var user = await (from u in _context.Users where u.UserId == userId select u).FirstAsync();
            _context.Users.Remove(user);
            await _context.SaveChangesAsync();
        }

        public async Task<User> GetAsync(Guid userId)
            => await (from u in _context.Users
                      where u.UserId == userId
                      select new User(u.UserId, u.Username, u.Email, u.Role, u.Password, u.Salt)).FirstAsync();

        public async Task<User> GetUserByUsername(string username)
            => await (from u in _context.Users
                     where u.Username == username
                     select new User(u.UserId, u.Username, u.Email, u.Role, u.Password, u.Salt)).FirstOrDefaultAsync();

        public async Task<User> GetUserByEmail(string email)
            => await (from u in _context.Users
                      where u.Email == email
                      select new User(u.UserId, u.Username, u.Email, u.Role, u.Password, u.Salt)).FirstOrDefaultAsync();

        public async Task UpdateAsync(User user)
        {
            var _user = await (from u in _context.Users where u.UserId == user.UserId select u).FirstAsync();
            _user.Username = user.Username;
            _user.Email = user.Email;
            _user.Password = user.Password;
            _user.Role = user.Role;
            await _context.SaveChangesAsync();
        }
    }
}