using System;
using System.Threading.Tasks;
using Typer.Domain.Enums;
using Typer.Domain.Models;

namespace Typer.Domain.Interfaces
{
    public interface IUserRepository
    {
        Task<Guid> CreateAsync(string username, string email, string password, string salt);
        Task<User> GetAsync(Guid userId);
        Task UpdateAsync(Guid userId, string username, string email, string password, Roles role);
        Task DeleteAsync(Guid userid);
        Task<User> GetUserByUsername(string username);
        Task<User> GetUserByEmail(string email);
    }
}
