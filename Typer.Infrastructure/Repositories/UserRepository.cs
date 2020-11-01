using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Threading.Tasks;
using Typer.Application.Services.JwtGenerator;
using Typer.Domain.Enums;
using Typer.Domain.Interfaces;
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

        public async Task<Guid> CreateAsync(string username, string email, string password, string salt)
        {
            var user = new DbUser
            {
                Email = email,
                Password = password,
                Role = Roles.User,
                Username = username,
                Salt = salt
            };
            await _context.Users.AddAsync(user);
            await _context.SaveChangesAsync();
            return user.UserId;
        }

        public async Task DeleteAsync(Guid userid)
        {
            var user = await (from u in _context.Users where u.UserId == userid select u).FirstAsync();
            _context.Users.Remove(user);
            await _context.SaveChangesAsync();
        }

        public async Task<User> GetAsync(Guid userId)
            => await (from u in _context.Users
                      where u.UserId == userId
                      select new User
                      {
                          Email = u.Email,
                          Role = u.Role,
                          UserId = u.UserId,
                          Username = u.Username,
                          Salt = u.Salt
                      }).FirstAsync();

        public async Task<User> GetUserByUsername(string username)
            => await (from u in _context.Users
                     where u.Username == username
                     select new User
                     {
                         Email = u.Email,
                         Role = u.Role,
                         UserId = u.UserId,
                         Username = u.Username,
                         Salt = u.Salt,
                         Password = u.Password
                     }).FirstOrDefaultAsync();

        public async Task<User> GetUserByEmail(string email)
            => await (from u in _context.Users
                      where u.Email == email
                      select new User
                      {
                          Email = u.Email,
                          Role = u.Role,
                          UserId = u.UserId,
                          Username = u.Username,
                          Salt = u.Salt,
                          Password = u.Password
                      }).FirstOrDefaultAsync();

        public async Task UpdateAsync(Guid userId, string username, string email, string password, Roles role)
        {
            var user = await (from u in _context.Users where u.UserId == userId select u).FirstAsync();
            user.Username = username;
            user.Email = email;
            user.Password = password;
            user.Role = role;
            await _context.SaveChangesAsync();
        }
    }
}