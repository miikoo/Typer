using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Typer.Logic.DtoModels;

namespace Typer.Logic.Queries.Seasons.GetSeasons
{
    public class GetSeasonsQuery : IRequest<List<SeasonDto>>
    {
    }
}
