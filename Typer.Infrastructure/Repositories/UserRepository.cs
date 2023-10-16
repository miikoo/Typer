using System;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using Dapper;
using Typer.Application.Services.JwtGenerator;
using Typer.Domain.Enums;
using Typer.Domain.Interfaces.Repositories;
using Typer.Domain.Models;
using Typer.Infrastructure.Entities;

namespace Typer.Infrastructure.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly IDbConnection _dbConnection;
        private readonly IJwtGenerator _jwtGenerator;

        public UserRepository(IDbConnection dbConnection, IJwtGenerator jwtGenerator)
        {
            _dbConnection = dbConnection;
            _jwtGenerator = jwtGenerator;
        }

        public async Task CreateAsync(User user)
        {
            const string insertQuery = "INSERT INTO Users (UserId, Username, Email, Role, Password, Salt) VALUES (@UserId, @Username, @Email, @Role, @Password, @Salt)";
            await _dbConnection.ExecuteAsync(insertQuery, DbUser.Create(user));
        }

        public async Task DeleteAsync(Guid userId)
        {
            const string deleteQuery = "DELETE FROM Users WHERE UserId = @UserId";
            await _dbConnection.ExecuteAsync(deleteQuery, new { UserId = userId });
        }

        public async Task<User> GetAsync(Guid userId)
        {
            const string selectQuery = "SELECT UserId, Username, Email, Role, Password, Salt FROM Users WHERE UserId = @UserId";
            return await _dbConnection.QueryFirstOrDefaultAsync<User>(selectQuery, new { UserId = userId });
        }

        public async Task<User> GetUserByUsername(string username)
        {
            const string selectQuery = "SELECT UserId, Username, Email, Role, Password, Salt FROM Users WHERE Username = @Username";
            return await _dbConnection.QueryFirstOrDefaultAsync<User>(selectQuery, new { Username = username });
        }

        public async Task<User> GetUserByEmail(string email)
        {
            const string selectQuery = "SELECT UserId, Username, Email, Role, Password, Salt FROM Users WHERE Email = @Email";
            return await _dbConnection.QueryFirstOrDefaultAsync<User>(selectQuery, new { Email = email });
        }

        public async Task UpdateAsync(User user)
        {
            const string updateQuery = "UPDATE Users SET Username = @Username, Email = @Email, Password = @Password, Role = @Role WHERE UserId = @UserId";
            await _dbConnection.ExecuteAsync(updateQuery, user);
        }
    }
}
