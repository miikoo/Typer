using System;
using System.Collections.Generic;
using System.Text;

namespace Typer.Application.Queries.User
{
    public class UserPointsDto
    {

        public UserPointsDto(int points)
        {
            Points = points;
        }

        public int Points { get; set; }
    }
}
