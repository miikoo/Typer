using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Typer.Domain.Models;

namespace Typer.Domain.Interfaces.Services
{
    public interface IPLClientService
    {
        Task<List<Match>> GetNotUpdatedMatchessAsync();
        Task<List<Match>> GetNextGameweeksMatches(int numOfGameweeks);
    }
}
