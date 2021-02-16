using MediatR;
using System.Linq;
using System.Collections.Generic;
using Typer.Domain.Models;
using System.Threading;
using System.Threading.Tasks;
using Typer.Domain.Interfaces.Repositories;
using Typer.Application.Client.PLClient;
using Typer.Application.Client.PLClient.Matches;
using System;

namespace Typer.Application.Commands.Seasons.BuildSeason
{
    public class BuildSeasonCommandHandler : IRequestHandler<BuildSeasonCommand, Unit>
    {
        private readonly ITeamRepository _teamRepository;
        private readonly IMatchRepository _matchRepository;
        private readonly IGameweekRepository _gameweekRepository;
        private readonly IPLClient _client;
        private readonly ISeasonRepository _seasonRepository;

        public BuildSeasonCommandHandler(ITeamRepository teamRepository, IMatchRepository matchRepository,
            IGameweekRepository gameweekRepository, IPLClient client, ISeasonRepository seasonRepository)
        {
            _teamRepository = teamRepository;
            _matchRepository = matchRepository;
            _seasonRepository = seasonRepository;
            _gameweekRepository = gameweekRepository;
            _client = client;
        }

        public async Task<Unit> Handle(BuildSeasonCommand request, CancellationToken cancellationToken)
        { 
            List<Match> matches = new List<Match>();
            var teams = await _teamRepository.GetAsync();
            var res = await _client.GetMatchesAsync("1");
            var startYear = res.GetContent().Matches[0].When.Year;
            var season = Season.Create(startYear - 1, startYear);
            await _seasonRepository.CreateAsync(season);
            List<Team> newTeams = new List<Team>();
            var gameweek = Gameweek.Create(1, season.SeasonId);
            await _gameweekRepository.CreateAsync(gameweek);
            res.GetContent().Matches.ForEach(x =>
            {
                if (!teams.Any(y => y.TeamName == x.Team1.TeamName))
                    newTeams.Add(Team.Create(x.Team1.TeamName));

                if (!teams.Any(y => y.TeamName == x.Team2.TeamName))
                    newTeams.Add(Team.Create(x.Team2.TeamName));
            });
            await _teamRepository.CreateAsync(newTeams.ToArray());
            teams.AddRange(newTeams);
            matches.AddRange(res.GetContent().Matches.Select(x => Match.Create(x.Team1?.TeamScore, x.Team2?.TeamScore, x.When,
                    teams.First(y => y.TeamName == x.Team2.TeamName).TeamId,
                    teams.First(y => y.TeamName == x.Team1.TeamName).TeamId, gameweek.GameweekId)));
            for (int i = 20; i < 38; i++)
            {
                gameweek = Gameweek.Create(i, season.SeasonId);
                await _gameweekRepository.CreateAsync(gameweek);
                res = await _client.GetMatchesAsync(i.ToString());
                matches.AddRange(res.GetContent().Matches.Select(x => Match.Create(x.Team1?.TeamScore, x.Team2?.TeamScore, x.When,
                    teams.First(y => y.TeamName == x.Team2.TeamName).TeamId,
                    teams.First(y => y.TeamName == x.Team1.TeamName).TeamId, gameweek.GameweekId)));
            }

            await _matchRepository.CreateAsync(matches.ToArray());
            return Unit.Value;
        }
    }
}
