using System;
using System.Collections.Generic;
using System.Text;

namespace Typer.Application.Services.PasswordHasher
{
    public interface IPasswordHasher
    {
        string GenerateHash(string password, string salt);
        string GenerateSalt();
        bool Validate(string password, string salt, string hashedPassword);
    }
}
