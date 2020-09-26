using System;
using System.Collections.Generic;
using System.Text;
using Typer.Domain.Enums;
using static Typer.Infrastructure.Entities.DbUser;

namespace Typer.Infrastructure.Services
{
    public interface IJwtGenerator
    {
        string Generate(Guid userId, Roles role);
    }
}
