using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Typer.Application.Client.PLClient;
using Typer.Application.Client.PLClient.Matches;
using Typer.Domain.Interfaces.Repositories;
using Typer.Domain.Interfaces.Services;
using Typer.Domain.Models;

namespace Typer.Application.Commands.Seasons.UpdateSeasonResults
{
    public class UpdateSeasonResultsCommandHandler : IRequestHandler<UpdateSeasonResultsCommand, Unit>
    {
        private readonly ITeamRepository _teamRepository;
        private readonly IMatchRepository _matchRepository;
        private readonly IGameweekRepository _gameweekRepository;
        private readonly IPLClient _client;
        private readonly ISeasonRepository _seasonRepository;
        private readonly IPLClientService _pLClientService;

        public UpdateSeasonResultsCommandHandler(ITeamRepository teamRepository, IMatchRepository matchRepository,
            IGameweekRepository gameweekRepository, IPLClient client, ISeasonRepository seasonRepository, IPLClientService pLClientService)
        {
            _teamRepository = teamRepository;
            _matchRepository = matchRepository;
            _gameweekRepository = gameweekRepository;
            _client = client;
            _seasonRepository = seasonRepository;
            _pLClientService = pLClientService;
        }

        public async Task<Unit> Handle(UpdateSeasonResultsCommand request, CancellationToken cancellationToken)
        {
            Gameweek gameweek;
            GetMatchesResponse matches;
            RestEase.Response<GetMatchesResponse> response;
            var matchesToUpdate = await _pLClientService.GetNotUpdatedMatchessAsync();
            var matchDatesToUpdate = await _pLClientService.GetNextGameweeksMatches(1);
            var teams = await _teamRepository.GetAsync();
            if (matchesToUpdate != null)
            {
                matchesToUpdate = matchesToUpdate.OrderByDescending(x => x.MatchDate).ToList();
                gameweek = await _gameweekRepository.GetByIdAsync(matchesToUpdate.FirstOrDefault().GameweekId);
                response = await _client.GetMatchesAsync(gameweek.GameweekNumber.ToString());
                matches = response.GetContent();
                foreach (var match in matchesToUpdate)
                {
                    if (match.GameweekId != gameweek.GameweekId)
                    {
                        gameweek = await _gameweekRepository.GetByIdAsync(match.GameweekId);
                        response = await _client.GetMatchesAsync(gameweek.GameweekNumber.ToString());
                        matches = response.GetContent();
                    }
                    var at = teams.First(y => y.TeamId == match.AwayTeamId).TeamName;
                    var ht = teams.First(y => y.TeamId == match.HomeTeamId).TeamName;
                    var result = matches.Matches.First(x => x.Team2.TeamName == at && x.Team1.TeamName == ht);
                    match.HomeTeamGoals = result.Team1.TeamScore;
                    match.AwayTeamGoals = result.Team2.TeamScore;
                    match.MatchDate = result.When;
                }
                await _matchRepository.UpdateAsync(matchesToUpdate.ToArray());
            }
            else if (matchDatesToUpdate != null)
            {
                gameweek = await _gameweekRepository.GetByIdAsync(matchDatesToUpdate[0].GameweekId);
                response = await _client.GetMatchesAsync(gameweek.GameweekNumber.ToString());
                matches = response.GetContent();
            }
            else
                return Unit.Value;
            foreach (var match in matchDatesToUpdate)
            {
                if (match.GameweekId != gameweek.GameweekId)
                {
                    gameweek = await _gameweekRepository.GetByIdAsync(match.GameweekId);
                    response = await _client.GetMatchesAsync(gameweek.GameweekNumber.ToString());
                    matches = response.GetContent();
                }
                var at = teams.First(y => y.TeamId == match.AwayTeamId).TeamName;
                var ht = teams.First(y => y.TeamId == match.HomeTeamId).TeamName;
                var result = matches.Matches.First(x => x.Team2.TeamName == at && x.Team1.TeamName == ht);
                match.MatchDate = result.When;
            }
            await _matchRepository.UpdateAsync(matchDatesToUpdate.ToArray());
            return Unit.Value;
        }
    }
}
