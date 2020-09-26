using System;
using System.Threading.Tasks;
using Typer.Domain.Enums;
using Typer.Domain.Models;

namespace Typer.Domain.Interfaces
{
    public interface IUserRepository
    {
        Task<string> CreateAsync(string username, string email, string password);
        Task<User> GetAsync(Guid userId);
        Task UpdateAsync(Guid userId, string username, string email, string password, Roles role);
        Task DeleteAsync(Guid userid);
        Task<string> Authenticate(string username, string password);
    }
}
