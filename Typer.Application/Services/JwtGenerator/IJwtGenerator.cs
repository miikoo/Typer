using System;
using System.Collections.Generic;
using System.Text;
using Typer.Domain.Enums;

namespace Typer.Application.Services.JwtGenerator
{
    public interface IJwtGenerator
    {
        string Generate(string userId, Roles role);
    }
}
