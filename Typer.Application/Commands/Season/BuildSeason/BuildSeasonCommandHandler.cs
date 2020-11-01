using MediatR;
using System.Linq;
using System.Collections.Generic;
using Typer.Domain.Models;
using System.Threading;
using System.Threading.Tasks;
using Typer.Domain.Interfaces;

namespace Typer.Application.Commands.Season.BuildSeason
{
    public class BuildSeasonCommandHandler : IRequestHandler<BuildSeasonCommand, Unit>
    {
        private readonly ITeamRepository _teamRepository;
        private readonly IMatchRepository _matchRepository;
        private readonly IGameweekRepository _gameweekRepository;

        public BuildSeasonCommandHandler(ITeamRepository teamRepository, IMatchRepository matchRepository, IGameweekRepository gameweekRepository)
        {
            _teamRepository = teamRepository;
            _matchRepository = matchRepository;
            _gameweekRepository = gameweekRepository;
        }

        public async Task<Unit> Handle(BuildSeasonCommand request, CancellationToken cancellationToken)
        {
            //List<Domain.Models.Gameweek> gameweeks = new List<Domain.Models.Gameweek>();
            //for (int i = 1; i <= request.GameweekAmount; i++)
            //{
            //    gameweeks.Add(new Domain.Models.Gameweek
            //    {
            //        GameweekId = await _gameweekRepository.CreateAsync(request.SeasonId, i),
            //        GameweekNumber = i
            //    });
            //}
            for (int i = 1; i <= request.GameweekAmount; i++)
                await _gameweekRepository.CreateAsync(request.SeasonId, i);
            var gameweeks = await _gameweekRepository.GetAsync(request.SeasonId);
            var existingTeams = await _teamRepository.GetAsync();
            foreach (var team in request.TeamNames)
                if(!existingTeams.Any(x => x.TeamName == team))
                    await _teamRepository.CreateAsync(team);
            var teams = await _teamRepository.GetAsync();
            foreach (var match in request.Matches)
                await _matchRepository.CreateAsync(
                    teams.Find(x => x.TeamName.Equals(match.HomeTeamName)).TeamId,
                    teams.Find(x => x.TeamName.Equals(match.AwayTeamName)).TeamId,
                    gameweeks.Find(x => x.GameweekNumber.Equals(match.GameweekNumber)).GameweekId,
                    match.MatchDate, match.HomeTeamGoals, match.AwayTeamGoals);
            return Unit.Value;
        }
    }
}
