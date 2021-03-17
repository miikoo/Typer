using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace Typer.Application.Queries.Seasons.IsNextSeasonExist
{
    public class IsNextSeasonExistQuery : IRequest<SeasonDto>
    {
    }
}
