using MediatR;
using System.Collections.Generic;

namespace Typer.API.Queries.Seasons.GetSeasonQuery
{
    public class GetSeasonsQuery : IRequest<List<SeasonDto>>
    {
    }
}
