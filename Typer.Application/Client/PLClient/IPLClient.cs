using RestEase;
using System.Threading.Tasks;
using Typer.Application.Client.PLClient.Matches;
using Typer.Application.Client.PLClient.Teams;

namespace Typer.Application.Client.PLClient
{
    [Header("x-rapidapi-key", "3329bdd7c9msh0ff4ee6560ca4a2p1c2db4jsn0b0adafa96df")] // key to api 
    [Header("x-rapidapi-host", "heisenbug-premier-league-live-scores-v1.p.rapidapi.com")]
    public interface IPLClient
    {
        //[Get]
        //Task<Response<GetTeamsResponse>> GetTeamsAsync([Query]int compSeasons, [Query]int page);

        [Get]
        Task<Response<GetMatchesResponse>> GetMatchesAsync(string matchday);
        //Task<List<PLMatch>> GetMatchesAsync(long seasonId);
        //Task<List<PLMatch>> GetMatchesAsync(long seasonId, DateTime startDate, DateTime endDate);
        //Task<List<PLMatch>> GetNonUpdatedMatchesAsync(long seasonId);
    }
}
