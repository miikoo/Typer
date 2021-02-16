using System;
using System.Threading.Tasks;
using Typer.Domain.Enums;
using Typer.Domain.Models;

namespace Typer.Domain.Interfaces.Repositories
{
    public interface IUserRepository
    {
        Task CreateAsync(User user);
        Task<User> GetAsync(Guid userId);
        Task UpdateAsync(User user);
        Task DeleteAsync(Guid userid);
        Task<User> GetUserByUsername(string username);
        Task<User> GetUserByEmail(string email);
    }
}
