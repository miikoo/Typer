INSERT INTO Teams (TeamId, TeamName)
VALUES
(UUID(), 'Arsenal'),
(UUID(), 'Aston Villa'),
(UUID(), 'Brighton'),
(UUID(), 'Burnley'),
(UUID(), 'Chelsea'),
(UUID(), 'Crystal Palace'),
(UUID(), 'Everton'),
(UUID(), 'Fulham'),
(UUID(), 'Leeds United'),
(UUID(), 'Leicester City'),
(UUID(), 'Liverpool'),
(UUID(), 'Manchester City'),
(UUID(), 'Manchester Utd'),
(UUID(), 'Newcastle'),
(UUID(), 'Sheffield Utd'),
(UUID(), 'Tottenham'),
(UUID(), 'West Bromwich Albion'),
(UUID(), 'Bournemouth'),
(UUID(), 'Luton'),
(UUID(), 'Nottingham'),
(UUID(), 'West Ham'),
(UUID(), 'Southampton'),
(UUID(), 'Brentford'),
(UUID(), 'Wolves');

INSERT INTO Seasons (SeasonId, StartYear, EndYear)
VALUES
    (UUID(), 2023,2024);


INSERT INTO Gameweeks (GameweekId, GameweekNumber, SeasonId)
VALUES
    (UUID(), 1, (SELECT SeasonId FROM Seasons WHERE StartYear = 2023 and EndYear = 2024)),
    (UUID(), 2, (SELECT SeasonId FROM Seasons WHERE StartYear = 2023 and EndYear = 2024)),
    (UUID(), 3, (SELECT SeasonId FROM Seasons WHERE StartYear = 2023 and EndYear = 2024)),
    (UUID(), 4, (SELECT SeasonId FROM Seasons WHERE StartYear = 2023 and EndYear = 2024)),
    (UUID(), 5, (SELECT SeasonId FROM Seasons WHERE StartYear = 2023 and EndYear = 2024)),
    (UUID(), 6, (SELECT SeasonId FROM Seasons WHERE StartYear = 2023 and EndYear = 2024)),
    (UUID(), 7, (SELECT SeasonId FROM Seasons WHERE StartYear = 2023 and EndYear = 2024)),
    (UUID(), 8, (SELECT SeasonId FROM Seasons WHERE StartYear = 2023 and EndYear = 2024)),
    (UUID(), 9, (SELECT SeasonId FROM Seasons WHERE StartYear = 2023 and EndYear = 2024)),
    (UUID(), 10, (SELECT SeasonId FROM Seasons WHERE StartYear = 2023 and EndYear = 2024)),
    (UUID(), 11, (SELECT SeasonId FROM Seasons WHERE StartYear = 2023 and EndYear = 2024)),
    (UUID(), 12, (SELECT SeasonId FROM Seasons WHERE StartYear = 2023 and EndYear = 2024)),
    (UUID(), 13, (SELECT SeasonId FROM Seasons WHERE StartYear = 2023 and EndYear = 2024)),
    (UUID(), 14, (SELECT SeasonId FROM Seasons WHERE StartYear = 2023 and EndYear = 2024)),
    (UUID(), 15, (SELECT SeasonId FROM Seasons WHERE StartYear = 2023 and EndYear = 2024)),
    (UUID(), 16, (SELECT SeasonId FROM Seasons WHERE StartYear = 2023 and EndYear = 2024)),
    (UUID(), 17, (SELECT SeasonId FROM Seasons WHERE StartYear = 2023 and EndYear = 2024)),
    (UUID(), 18, (SELECT SeasonId FROM Seasons WHERE StartYear = 2023 and EndYear = 2024)),
    (UUID(), 19, (SELECT SeasonId FROM Seasons WHERE StartYear = 2023 and EndYear = 2024)),
    (UUID(), 20, (SELECT SeasonId FROM Seasons WHERE StartYear = 2023 and EndYear = 2024)),
    (UUID(), 21, (SELECT SeasonId FROM Seasons WHERE StartYear = 2023 and EndYear = 2024)),
    (UUID(), 22, (SELECT SeasonId FROM Seasons WHERE StartYear = 2023 and EndYear = 2024)),
    (UUID(), 23, (SELECT SeasonId FROM Seasons WHERE StartYear = 2023 and EndYear = 2024)),
    (UUID(), 24, (SELECT SeasonId FROM Seasons WHERE StartYear = 2023 and EndYear = 2024)),
    (UUID(), 25, (SELECT SeasonId FROM Seasons WHERE StartYear = 2023 and EndYear = 2024)),
    (UUID(), 26, (SELECT SeasonId FROM Seasons WHERE StartYear = 2023 and EndYear = 2024)),
    (UUID(), 27, (SELECT SeasonId FROM Seasons WHERE StartYear = 2023 and EndYear = 2024)),
    (UUID(), 28, (SELECT SeasonId FROM Seasons WHERE StartYear = 2023 and EndYear = 2024)),
    (UUID(), 29, (SELECT SeasonId FROM Seasons WHERE StartYear = 2023 and EndYear = 2024)),
    (UUID(), 30, (SELECT SeasonId FROM Seasons WHERE StartYear = 2023 and EndYear = 2024)),
    (UUID(), 31, (SELECT SeasonId FROM Seasons WHERE StartYear = 2023 and EndYear = 2024)),
    (UUID(), 32, (SELECT SeasonId FROM Seasons WHERE StartYear = 2023 and EndYear = 2024)),
    (UUID(), 33, (SELECT SeasonId FROM Seasons WHERE StartYear = 2023 and EndYear = 2024)),
    (UUID(), 34, (SELECT SeasonId FROM Seasons WHERE StartYear = 2023 and EndYear = 2024)),
    (UUID(), 35, (SELECT SeasonId FROM Seasons WHERE StartYear = 2023 and EndYear = 2024)),
    (UUID(), 36, (SELECT SeasonId FROM Seasons WHERE StartYear = 2023 and EndYear = 2024)),
    (UUID(), 37, (SELECT SeasonId FROM Seasons WHERE StartYear = 2023 and EndYear = 2024)),
    (UUID(), 38, (SELECT SeasonId FROM Seasons WHERE StartYear = 2023 and EndYear = 2024));

INSERT INTO Matches (MatchId, HomeTeamGoals, AwayTeamGoals, MatchDate, HomeTeamId, AwayTeamId, GameweekId)
VALUES
(UUID(), 1, 0, '2023-08-14', (SELECT TeamId FROM Teams WHERE TeamName = 'Manchester Utd'), (SELECT TeamId FROM Teams WHERE TeamName = 'Wolves'), (SELECT GameweekId FROM Gameweeks WHERE GameweekNumber = 1)),
(UUID(), 1, 1, '2023-08-13', (SELECT TeamId FROM Teams WHERE TeamName = 'Chelsea'), (SELECT TeamId FROM Teams WHERE TeamName = 'Liverpool'), (SELECT GameweekId FROM Gameweeks WHERE GameweekNumber = 1)),
(UUID(), 2, 2, '2023-08-13', (SELECT TeamId FROM Teams WHERE TeamName = 'Brentford'), (SELECT TeamId FROM Teams WHERE TeamName = 'Tottenham'), (SELECT GameweekId FROM Gameweeks WHERE GameweekNumber = 1)),
(UUID(), 5, 1, '2023-08-12', (SELECT TeamId FROM Teams WHERE TeamName = 'Newcastle'), (SELECT TeamId FROM Teams WHERE TeamName = 'Aston Villa'), (SELECT GameweekId FROM Gameweeks WHERE GameweekNumber = 1)),
(UUID(), 1, 1, '2023-08-12', (SELECT TeamId FROM Teams WHERE TeamName = 'Bournemouth'), (SELECT TeamId FROM Teams WHERE TeamName = 'West Ham'), (SELECT GameweekId FROM Gameweeks WHERE GameweekNumber = 1)),
(UUID(), 4, 1, '2023-08-12', (SELECT TeamId FROM Teams WHERE TeamName = 'Brighton'), (SELECT TeamId FROM Teams WHERE TeamName = 'Luton'), (SELECT GameweekId FROM Gameweeks WHERE GameweekNumber = 1)),
(UUID(), 0, 1, '2023-08-12', (SELECT TeamId FROM Teams WHERE TeamName = 'Everton'), (SELECT TeamId FROM Teams WHERE TeamName = 'Fulham'), (SELECT GameweekId FROM Gameweeks WHERE GameweekNumber = 1)),
(UUID(), 0, 1, '2023-08-12', (SELECT TeamId FROM Teams WHERE TeamName = 'Sheffield Utd'), (SELECT TeamId FROM Teams WHERE TeamName = 'Crystal Palace'), (SELECT GameweekId FROM Gameweeks WHERE GameweekNumber = 1)),
(UUID(), 2, 1, '2023-08-12', (SELECT TeamId FROM Teams WHERE TeamName = 'Arsenal'), (SELECT TeamId FROM Teams WHERE TeamName = 'Nottingham'), (SELECT GameweekId FROM Gameweeks WHERE GameweekNumber = 1)),
(UUID(), 0, 3, '2023-08-11', (SELECT TeamId FROM Teams WHERE TeamName = 'Burnley'), (SELECT TeamId FROM Teams WHERE TeamName = 'Manchester City'), (SELECT GameweekId FROM Gameweeks WHERE GameweekNumber = 1));

INSERT INTO Matches (MatchId, HomeTeamGoals, AwayTeamGoals, MatchDate, HomeTeamId, AwayTeamId, GameweekId)
VALUES
(UUID(), 0, 1, '2023-08-21', (SELECT TeamId FROM Teams WHERE TeamName = 'Crystal Palace'), (SELECT TeamId FROM Teams WHERE TeamName = 'Arsenal'), (SELECT GameweekId FROM Gameweeks WHERE GameweekNumber = 2)),
(UUID(), 3, 1, '2023-08-20', (SELECT TeamId FROM Teams WHERE TeamName = 'West Ham'), (SELECT TeamId FROM Teams WHERE TeamName = 'Chelsea'), (SELECT GameweekId FROM Gameweeks WHERE GameweekNumber = 2)),
(UUID(), 4, 0, '2023-08-20', (SELECT TeamId FROM Teams WHERE TeamName = 'Aston Villa'), (SELECT TeamId FROM Teams WHERE TeamName = 'Everton'), (SELECT GameweekId FROM Gameweeks WHERE GameweekNumber = 2)),
(UUID(), 1, 0, '2023-08-19', (SELECT TeamId FROM Teams WHERE TeamName = 'Manchester City'), (SELECT TeamId FROM Teams WHERE TeamName = 'Newcastle'), (SELECT GameweekId FROM Gameweeks WHERE GameweekNumber = 2)),
(UUID(), 2, 0, '2023-08-19', (SELECT TeamId FROM Teams WHERE TeamName = 'Tottenham'), (SELECT TeamId FROM Teams WHERE TeamName = 'Manchester Utd'), (SELECT GameweekId FROM Gameweeks WHERE GameweekNumber = 2)),
(UUID(), 0, 3, '2023-08-19', (SELECT TeamId FROM Teams WHERE TeamName = 'Fulham'), (SELECT TeamId FROM Teams WHERE TeamName = 'Brentford'), (SELECT GameweekId FROM Gameweeks WHERE GameweekNumber = 2)),
(UUID(), 3, 1, '2023-08-19', (SELECT TeamId FROM Teams WHERE TeamName = 'Liverpool'), (SELECT TeamId FROM Teams WHERE TeamName = 'Bournemouth'), (SELECT GameweekId FROM Gameweeks WHERE GameweekNumber = 2)),
(UUID(), 1, 4, '2023-08-19', (SELECT TeamId FROM Teams WHERE TeamName = 'Wolves'), (SELECT TeamId FROM Teams WHERE TeamName = 'Brighton'), (SELECT GameweekId FROM Gameweeks WHERE GameweekNumber = 2)),
(UUID(), 2, 1, '2023-08-18', (SELECT TeamId FROM Teams WHERE TeamName = 'Nottingham'), (SELECT TeamId FROM Teams WHERE TeamName = 'Sheffield Utd'), (SELECT GameweekId FROM Gameweeks WHERE GameweekNumber = 2)),
(UUID(), 1, 2, '2023-10-03', (SELECT TeamId FROM Teams WHERE TeamName = 'Luton'), (SELECT TeamId FROM Teams WHERE TeamName = 'Burnley'), (SELECT GameweekId FROM Gameweeks WHERE GameweekNumber = 2));


INSERT INTO Matches (MatchId, HomeTeamGoals, AwayTeamGoals, MatchDate, HomeTeamId, AwayTeamId, GameweekId)
VALUES
(UUID(), 1, 2, '2023-08-27', (SELECT TeamId FROM Teams WHERE TeamName = 'Newcastle'), (SELECT TeamId FROM Teams WHERE TeamName = 'Liverpool'), (SELECT GameweekId FROM Gameweeks WHERE GameweekNumber = 3)),
(UUID(), 1, 3, '2023-08-27', (SELECT TeamId FROM Teams WHERE TeamName = 'Burnley'), (SELECT TeamId FROM Teams WHERE TeamName = 'Aston Villa'), (SELECT GameweekId FROM Gameweeks WHERE GameweekNumber = 3)),
(UUID(), 1, 2, '2023-08-27', (SELECT TeamId FROM Teams WHERE TeamName = 'Sheffield Utd'), (SELECT TeamId FROM Teams WHERE TeamName = 'Manchester City'), (SELECT GameweekId FROM Gameweeks WHERE GameweekNumber = 3)),
(UUID(), 1, 3, '2023-08-26', (SELECT TeamId FROM Teams WHERE TeamName = 'Brighton'), (SELECT TeamId FROM Teams WHERE TeamName = 'West Ham'), (SELECT GameweekId FROM Gameweeks WHERE GameweekNumber = 3)),
(UUID(), 2, 2, '2023-08-26', (SELECT TeamId FROM Teams WHERE TeamName = 'Arsenal'), (SELECT TeamId FROM Teams WHERE TeamName = 'Fulham'), (SELECT GameweekId FROM Gameweeks WHERE GameweekNumber = 3)),
(UUID(), 1, 1, '2023-08-26', (SELECT TeamId FROM Teams WHERE TeamName = 'Brentford'), (SELECT TeamId FROM Teams WHERE TeamName = 'Crystal Palace'), (SELECT GameweekId FROM Gameweeks WHERE GameweekNumber = 3)),
(UUID(), 0, 1, '2023-08-26', (SELECT TeamId FROM Teams WHERE TeamName = 'Everton'), (SELECT TeamId FROM Teams WHERE TeamName = 'Wolves'), (SELECT GameweekId FROM Gameweeks WHERE GameweekNumber = 3)),
(UUID(), 3, 2, '2023-08-26', (SELECT TeamId FROM Teams WHERE TeamName = 'Manchester Utd'), (SELECT TeamId FROM Teams WHERE TeamName = 'Nottingham'), (SELECT GameweekId FROM Gameweeks WHERE GameweekNumber = 3)),
(UUID(), 0, 2, '2023-08-26', (SELECT TeamId FROM Teams WHERE TeamName = 'Bournemouth'), (SELECT TeamId FROM Teams WHERE TeamName = 'Tottenham'), (SELECT GameweekId FROM Gameweeks WHERE GameweekNumber = 3)),
(UUID(), 3, 0, '2023-08-25', (SELECT TeamId FROM Teams WHERE TeamName = 'Chelsea'), (SELECT TeamId FROM Teams WHERE TeamName = 'Luton'), (SELECT GameweekId FROM Gameweeks WHERE GameweekNumber = 3));

INSERT INTO Matches (MatchId, HomeTeamGoals, AwayTeamGoals, MatchDate, HomeTeamId, AwayTeamId, GameweekId)
VALUES
(UUID(), 3, 1, '2023-09-03', (SELECT TeamId FROM Teams WHERE TeamName = 'Arsenal'), (SELECT TeamId FROM Teams WHERE TeamName = 'Manchester Utd'), (SELECT GameweekId FROM Gameweeks WHERE GameweekNumber = 4)),
(UUID(), 3, 2, '2023-09-03', (SELECT TeamId FROM Teams WHERE TeamName = 'Crystal Palace'), (SELECT TeamId FROM Teams WHERE TeamName = 'Wolves'), (SELECT GameweekId FROM Gameweeks WHERE GameweekNumber = 4)),
(UUID(), 3, 0, '2023-09-03', (SELECT TeamId FROM Teams WHERE TeamName = 'Liverpool'), (SELECT TeamId FROM Teams WHERE TeamName = 'Aston Villa'), (SELECT GameweekId FROM Gameweeks WHERE GameweekNumber = 4)),
(UUID(), 3, 1, '2023-09-02', (SELECT TeamId FROM Teams WHERE TeamName = 'Brighton'), (SELECT TeamId FROM Teams WHERE TeamName = 'Newcastle'), (SELECT GameweekId FROM Gameweeks WHERE GameweekNumber = 4)),
(UUID(), 2, 2, '2023-09-02', (SELECT TeamId FROM Teams WHERE TeamName = 'Brentford'), (SELECT TeamId FROM Teams WHERE TeamName = 'Bournemouth'), (SELECT GameweekId FROM Gameweeks WHERE GameweekNumber = 4)),
(UUID(), 2, 5, '2023-09-02', (SELECT TeamId FROM Teams WHERE TeamName = 'Burnley'), (SELECT TeamId FROM Teams WHERE TeamName = 'Tottenham'), (SELECT GameweekId FROM Gameweeks WHERE GameweekNumber = 4)),
(UUID(), 0, 1, '2023-09-02', (SELECT TeamId FROM Teams WHERE TeamName = 'Chelsea'), (SELECT TeamId FROM Teams WHERE TeamName = 'Nottingham'), (SELECT GameweekId FROM Gameweeks WHERE GameweekNumber = 4)),
(UUID(), 5, 1, '2023-09-02', (SELECT TeamId FROM Teams WHERE TeamName = 'Manchester City'), (SELECT TeamId FROM Teams WHERE TeamName = 'Fulham'), (SELECT GameweekId FROM Gameweeks WHERE GameweekNumber = 4)),
(UUID(), 2, 2, '2023-09-02', (SELECT TeamId FROM Teams WHERE TeamName = 'Sheffield Utd'), (SELECT TeamId FROM Teams WHERE TeamName = 'Everton'), (SELECT GameweekId FROM Gameweeks WHERE GameweekNumber = 4)),
(UUID(), 1, 2, '2023-09-01', (SELECT TeamId FROM Teams WHERE TeamName = 'Luton'), (SELECT TeamId FROM Teams WHERE TeamName = 'West Ham'), (SELECT GameweekId FROM Gameweeks WHERE GameweekNumber = 4));

INSERT INTO Matches (MatchId, HomeTeamGoals, AwayTeamGoals, MatchDate, HomeTeamId, AwayTeamId, GameweekId)
VALUES
(UUID(), 1, 1, '2023-09-18', (SELECT TeamId FROM Teams WHERE TeamName = 'Nottingham'), (SELECT TeamId FROM Teams WHERE TeamName = 'Burnley'), (SELECT GameweekId FROM Gameweeks WHERE GameweekNumber = 5)),
(UUID(), 0, 1, '2023-09-17', (SELECT TeamId FROM Teams WHERE TeamName = 'Everton'), (SELECT TeamId FROM Teams WHERE TeamName = 'Arsenal'), (SELECT GameweekId FROM Gameweeks WHERE GameweekNumber = 5)),
(UUID(), 0, 0, '2023-09-17', (SELECT TeamId FROM Teams WHERE TeamName = 'Bournemouth'), (SELECT TeamId FROM Teams WHERE TeamName = 'Chelsea'), (SELECT GameweekId FROM Gameweeks WHERE GameweekNumber = 5)),
(UUID(), 1, 0, '2023-09-16', (SELECT TeamId FROM Teams WHERE TeamName = 'Newcastle'), (SELECT TeamId FROM Teams WHERE TeamName = 'Brentford'), (SELECT GameweekId FROM Gameweeks WHERE GameweekNumber = 5)),
(UUID(), 3, 1, '2023-09-16', (SELECT TeamId FROM Teams WHERE TeamName = 'Aston Villa'), (SELECT TeamId FROM Teams WHERE TeamName = 'Crystal Palace'), (SELECT GameweekId FROM Gameweeks WHERE GameweekNumber = 5)),
(UUID(), 1, 0, '2023-09-16', (SELECT TeamId FROM Teams WHERE TeamName = 'Fulham'), (SELECT TeamId FROM Teams WHERE TeamName = 'Luton'), (SELECT GameweekId FROM Gameweeks WHERE GameweekNumber = 5)),
(UUID(), 1, 3, '2023-09-16', (SELECT TeamId FROM Teams WHERE TeamName = 'Manchester Utd'), (SELECT TeamId FROM Teams WHERE TeamName = 'Brighton'), (SELECT GameweekId FROM Gameweeks WHERE GameweekNumber = 5)),
(UUID(), 2, 1, '2023-09-16', (SELECT TeamId FROM Teams WHERE TeamName = 'Tottenham'), (SELECT TeamId FROM Teams WHERE TeamName = 'Sheffield Utd'), (SELECT GameweekId FROM Gameweeks WHERE GameweekNumber = 5)),
(UUID(), 1, 3, '2023-09-16', (SELECT TeamId FROM Teams WHERE TeamName = 'West Ham'), (SELECT TeamId FROM Teams WHERE TeamName = 'Manchester City'), (SELECT GameweekId FROM Gameweeks WHERE GameweekNumber = 5)),
(UUID(), 1, 3, '2023-09-16', (SELECT TeamId FROM Teams WHERE TeamName = 'Wolves'), (SELECT TeamId FROM Teams WHERE TeamName = 'Liverpool'), (SELECT GameweekId FROM Gameweeks WHERE GameweekNumber = 5));

INSERT INTO Matches (MatchId, HomeTeamGoals, AwayTeamGoals, MatchDate, HomeTeamId, AwayTeamId, GameweekId)
VALUES
(UUID(), 0, 8, '2023-09-24', (SELECT TeamId FROM Teams WHERE TeamName = 'Sheffield Utd'), (SELECT TeamId FROM Teams WHERE TeamName = 'Newcastle'), (SELECT GameweekId FROM Gameweeks WHERE GameweekNumber = 6)),
(UUID(), 2, 2, '2023-09-24', (SELECT TeamId FROM Teams WHERE TeamName = 'Arsenal'), (SELECT TeamId FROM Teams WHERE TeamName = 'Tottenham'), (SELECT GameweekId FROM Gameweeks WHERE GameweekNumber = 6)),
(UUID(), 3, 1, '2023-09-24', (SELECT TeamId FROM Teams WHERE TeamName = 'Brighton'), (SELECT TeamId FROM Teams WHERE TeamName = 'Bournemouth'), (SELECT GameweekId FROM Gameweeks WHERE GameweekNumber = 6)),
(UUID(), 0, 1, '2023-09-24', (SELECT TeamId FROM Teams WHERE TeamName = 'Chelsea'), (SELECT TeamId FROM Teams WHERE TeamName = 'Aston Villa'), (SELECT GameweekId FROM Gameweeks WHERE GameweekNumber = 6)),
(UUID(), 3, 1, '2023-09-24', (SELECT TeamId FROM Teams WHERE TeamName = 'Liverpool'), (SELECT TeamId FROM Teams WHERE TeamName = 'West Ham'), (SELECT GameweekId FROM Gameweeks WHERE GameweekNumber = 6)),
(UUID(), 0, 1, '2023-09-23', (SELECT TeamId FROM Teams WHERE TeamName = 'Burnley'), (SELECT TeamId FROM Teams WHERE TeamName = 'Manchester Utd'), (SELECT GameweekId FROM Gameweeks WHERE GameweekNumber = 6)),
(UUID(), 1, 3, '2023-09-23', (SELECT TeamId FROM Teams WHERE TeamName = 'Brentford'), (SELECT TeamId FROM Teams WHERE TeamName = 'Everton'), (SELECT GameweekId FROM Gameweeks WHERE GameweekNumber = 6)),
(UUID(), 0, 0, '2023-09-23', (SELECT TeamId FROM Teams WHERE TeamName = 'Crystal Palace'), (SELECT TeamId FROM Teams WHERE TeamName = 'Fulham'), (SELECT GameweekId FROM Gameweeks WHERE GameweekNumber = 6)),
(UUID(), 1, 1, '2023-09-23', (SELECT TeamId FROM Teams WHERE TeamName = 'Luton'), (SELECT TeamId FROM Teams WHERE TeamName = 'Wolves'), (SELECT GameweekId FROM Gameweeks WHERE GameweekNumber = 6)),
(UUID(), 2, 0, '2023-09-23', (SELECT TeamId FROM Teams WHERE TeamName = 'Manchester City'), (SELECT TeamId FROM Teams WHERE TeamName = 'Nottingham'), (SELECT GameweekId FROM Gameweeks WHERE GameweekNumber = 6));

INSERT INTO Matches (MatchId, HomeTeamGoals, AwayTeamGoals, MatchDate, HomeTeamId, AwayTeamId, GameweekId)
VALUES
(UUID(), 0, 2, '2023-10-02', (SELECT TeamId FROM Teams WHERE TeamName = 'Fulham'), (SELECT TeamId FROM Teams WHERE TeamName = 'Chelsea'), (SELECT GameweekId FROM Gameweeks WHERE GameweekNumber = 7)),
(UUID(), 1, 1, '2023-10-01', (SELECT TeamId FROM Teams WHERE TeamName = 'Nottingham'), (SELECT TeamId FROM Teams WHERE TeamName = 'Brentford'), (SELECT GameweekId FROM Gameweeks WHERE GameweekNumber = 7)),
(UUID(), 2, 1, '2023-09-30', (SELECT TeamId FROM Teams WHERE TeamName = 'Tottenham'), (SELECT TeamId FROM Teams WHERE TeamName = 'Liverpool'), (SELECT GameweekId FROM Gameweeks WHERE GameweekNumber = 7)),
(UUID(), 0, 4, '2023-09-30', (SELECT TeamId FROM Teams WHERE TeamName = 'Bournemouth'), (SELECT TeamId FROM Teams WHERE TeamName = 'Arsenal'), (SELECT GameweekId FROM Gameweeks WHERE GameweekNumber = 7)),
(UUID(), 1, 2, '2023-09-30', (SELECT TeamId FROM Teams WHERE TeamName = 'Everton'), (SELECT TeamId FROM Teams WHERE TeamName = 'Luton'), (SELECT GameweekId FROM Gameweeks WHERE GameweekNumber = 7)),
(UUID(), 0, 1, '2023-09-30', (SELECT TeamId FROM Teams WHERE TeamName = 'Manchester Utd'), (SELECT TeamId FROM Teams WHERE TeamName = 'Crystal Palace'), (SELECT GameweekId FROM Gameweeks WHERE GameweekNumber = 7)),
(UUID(), 2, 0, '2023-09-30', (SELECT TeamId FROM Teams WHERE TeamName = 'Newcastle'), (SELECT TeamId FROM Teams WHERE TeamName = 'Burnley'), (SELECT GameweekId FROM Gameweeks WHERE GameweekNumber = 7)),
(UUID(), 2, 0, '2023-09-30', (SELECT TeamId FROM Teams WHERE TeamName = 'West Ham'), (SELECT TeamId FROM Teams WHERE TeamName = 'Sheffield Utd'), (SELECT GameweekId FROM Gameweeks WHERE GameweekNumber = 7)),
(UUID(), 2, 1, '2023-09-30', (SELECT TeamId FROM Teams WHERE TeamName = 'Wolves'), (SELECT TeamId FROM Teams WHERE TeamName = 'Manchester City'), (SELECT GameweekId FROM Gameweeks WHERE GameweekNumber = 7)),
(UUID(), 6, 1, '2023-09-30', (SELECT TeamId FROM Teams WHERE TeamName = 'Aston Villa'), (SELECT TeamId FROM Teams WHERE TeamName = 'Brighton'), (SELECT GameweekId FROM Gameweeks WHERE GameweekNumber = 7));

INSERT INTO Matches (MatchId, HomeTeamGoals, AwayTeamGoals, MatchDate, HomeTeamId, AwayTeamId, GameweekId)
VALUES
(UUID(), 1, 0, '2023-10-08', (SELECT TeamId FROM Teams WHERE TeamName = 'Arsenal'), (SELECT TeamId FROM Teams WHERE TeamName = 'Manchester City'), (SELECT GameweekId FROM Gameweeks WHERE GameweekNumber = 8)),
(UUID(), 2, 2, '2023-10-08', (SELECT TeamId FROM Teams WHERE TeamName = 'Brighton'), (SELECT TeamId FROM Teams WHERE TeamName = 'Liverpool'), (SELECT GameweekId FROM Gameweeks WHERE GameweekNumber = 8)),
(UUID(), 2, 2, '2023-10-08', (SELECT TeamId FROM Teams WHERE TeamName = 'West Ham'), (SELECT TeamId FROM Teams WHERE TeamName = 'Newcastle'), (SELECT GameweekId FROM Gameweeks WHERE GameweekNumber = 8)),
(UUID(), 1, 1, '2023-10-08', (SELECT TeamId FROM Teams WHERE TeamName = 'Wolves'), (SELECT TeamId FROM Teams WHERE TeamName = 'Aston Villa'), (SELECT GameweekId FROM Gameweeks WHERE GameweekNumber = 8)),
(UUID(), 0, 0, '2023-10-07', (SELECT TeamId FROM Teams WHERE TeamName = 'Crystal Palace'), (SELECT TeamId FROM Teams WHERE TeamName = 'Nottingham'), (SELECT GameweekId FROM Gameweeks WHERE GameweekNumber = 8)),
(UUID(), 1, 4, '2023-10-07', (SELECT TeamId FROM Teams WHERE TeamName = 'Burnley'), (SELECT TeamId FROM Teams WHERE TeamName = 'Chelsea'), (SELECT GameweekId FROM Gameweeks WHERE GameweekNumber = 8)),
(UUID(), 3, 0, '2023-10-07', (SELECT TeamId FROM Teams WHERE TeamName = 'Everton'), (SELECT TeamId FROM Teams WHERE TeamName = 'Bournemouth'), (SELECT GameweekId FROM Gameweeks WHERE GameweekNumber = 8)),
(UUID(), 3, 1, '2023-10-07', (SELECT TeamId FROM Teams WHERE TeamName = 'Fulham'), (SELECT TeamId FROM Teams WHERE TeamName = 'Sheffield Utd'), (SELECT GameweekId FROM Gameweeks WHERE GameweekNumber = 8)),
(UUID(), 2, 1, '2023-10-07', (SELECT TeamId FROM Teams WHERE TeamName = 'Manchester Utd'), (SELECT TeamId FROM Teams WHERE TeamName = 'Brentford'), (SELECT GameweekId FROM Gameweeks WHERE GameweekNumber = 8)),
(UUID(), 0, 1, '2023-10-07', (SELECT TeamId FROM Teams WHERE TeamName = 'Luton'), (SELECT TeamId FROM Teams WHERE TeamName = 'Tottenham'), (SELECT GameweekId FROM Gameweeks WHERE GameweekNumber = 8));

INSERT INTO Matches (MatchId, HomeTeamGoals, AwayTeamGoals, MatchDate, HomeTeamId, AwayTeamId, GameweekId)
VALUES
(UUID(), 2, 0, '2023-10-23', (SELECT TeamId FROM Teams WHERE TeamName = 'Tottenham'), (SELECT TeamId FROM Teams WHERE TeamName = 'Fulham'), (SELECT GameweekId FROM Gameweeks WHERE GameweekNumber = 9)),
(UUID(), 4, 1, '2023-10-22', (SELECT TeamId FROM Teams WHERE TeamName = 'Aston Villa'), (SELECT TeamId FROM Teams WHERE TeamName = 'West Ham'), (SELECT GameweekId FROM Gameweeks WHERE GameweekNumber = 9)),
(UUID(), 1, 2, '2023-10-21', (SELECT TeamId FROM Teams WHERE TeamName = 'Sheffield Utd'), (SELECT TeamId FROM Teams WHERE TeamName = 'Manchester Utd'), (SELECT GameweekId FROM Gameweeks WHERE GameweekNumber = 9)),
(UUID(), 2, 2, '2023-10-21', (SELECT TeamId FROM Teams WHERE TeamName = 'Chelsea'), (SELECT TeamId FROM Teams WHERE TeamName = 'Arsenal'), (SELECT GameweekId FROM Gameweeks WHERE GameweekNumber = 9)),
(UUID(), 1, 2, '2023-10-21', (SELECT TeamId FROM Teams WHERE TeamName = 'Bournemouth'), (SELECT TeamId FROM Teams WHERE TeamName = 'Wolves'), (SELECT GameweekId FROM Gameweeks WHERE GameweekNumber = 9)),
(UUID(), 3, 0, '2023-10-21', (SELECT TeamId FROM Teams WHERE TeamName = 'Brentford'), (SELECT TeamId FROM Teams WHERE TeamName = 'Burnley'), (SELECT GameweekId FROM Gameweeks WHERE GameweekNumber = 9)),
(UUID(), 2, 1, '2023-10-21', (SELECT TeamId FROM Teams WHERE TeamName = 'Manchester City'), (SELECT TeamId FROM Teams WHERE TeamName = 'Brighton'), (SELECT GameweekId FROM Gameweeks WHERE GameweekNumber = 9)),
(UUID(), 4, 0, '2023-10-21', (SELECT TeamId FROM Teams WHERE TeamName = 'Newcastle'), (SELECT TeamId FROM Teams WHERE TeamName = 'Crystal Palace'), (SELECT GameweekId FROM Gameweeks WHERE GameweekNumber = 9)),
(UUID(), 2, 2, '2023-10-21', (SELECT TeamId FROM Teams WHERE TeamName = 'Nottingham'), (SELECT TeamId FROM Teams WHERE TeamName = 'Luton'), (SELECT GameweekId FROM Gameweeks WHERE GameweekNumber = 9)),
(UUID(), 2, 0, '2023-10-21', (SELECT TeamId FROM Teams WHERE TeamName = 'Liverpool'), (SELECT TeamId FROM Teams WHERE TeamName = 'Everton'), (SELECT GameweekId FROM Gameweeks WHERE GameweekNumber = 9));

INSERT INTO Matches (MatchId, HomeTeamGoals, AwayTeamGoals, MatchDate, HomeTeamId, AwayTeamId, GameweekId)
VALUES
(UUID(), 0, 3, '2023-10-29', (SELECT TeamId FROM Teams WHERE TeamName = 'Manchester Utd'), (SELECT TeamId FROM Teams WHERE TeamName = 'Manchester City'), (SELECT GameweekId FROM Gameweeks WHERE GameweekNumber = 10)),
(UUID(), 3, 1, '2023-10-29', (SELECT TeamId FROM Teams WHERE TeamName = 'Aston Villa'), (SELECT TeamId FROM Teams WHERE TeamName = 'Luton'), (SELECT GameweekId FROM Gameweeks WHERE GameweekNumber = 10)),
(UUID(), 1, 1, '2023-10-29', (SELECT TeamId FROM Teams WHERE TeamName = 'Brighton'), (SELECT TeamId FROM Teams WHERE TeamName = 'Fulham'), (SELECT GameweekId FROM Gameweeks WHERE GameweekNumber = 10)),
(UUID(), 3, 0, '2023-10-29', (SELECT TeamId FROM Teams WHERE TeamName = 'Liverpool'), (SELECT TeamId FROM Teams WHERE TeamName = 'Nottingham'), (SELECT GameweekId FROM Gameweeks WHERE GameweekNumber = 10)),
(UUID(), 0, 1, '2023-10-29', (SELECT TeamId FROM Teams WHERE TeamName = 'West Ham'), (SELECT TeamId FROM Teams WHERE TeamName = 'Everton'), (SELECT GameweekId FROM Gameweeks WHERE GameweekNumber = 10)),
(UUID(), 2, 2, '2023-10-28', (SELECT TeamId FROM Teams WHERE TeamName = 'Wolves'), (SELECT TeamId FROM Teams WHERE TeamName = 'Newcastle'), (SELECT GameweekId FROM Gameweeks WHERE GameweekNumber = 10)),
(UUID(), 5, 0, '2023-10-28', (SELECT TeamId FROM Teams WHERE TeamName = 'Arsenal'), (SELECT TeamId FROM Teams WHERE TeamName = 'Sheffield Utd'), (SELECT GameweekId FROM Gameweeks WHERE GameweekNumber = 10)),
(UUID(), 2, 1, '2023-10-28', (SELECT TeamId FROM Teams WHERE TeamName = 'Bournemouth'), (SELECT TeamId FROM Teams WHERE TeamName = 'Burnley'), (SELECT GameweekId FROM Gameweeks WHERE GameweekNumber = 10)),
(UUID(), 0, 2, '2023-10-28', (SELECT TeamId FROM Teams WHERE TeamName = 'Chelsea'), (SELECT TeamId FROM Teams WHERE TeamName = 'Brentford'), (SELECT GameweekId FROM Gameweeks WHERE GameweekNumber = 10)),
(UUID(), 1, 2, '2023-10-27', (SELECT TeamId FROM Teams WHERE TeamName = 'Crystal Palace'), (SELECT TeamId FROM Teams WHERE TeamName = 'Tottenham'), (SELECT GameweekId FROM Gameweeks WHERE GameweekNumber = 10));

INSERT INTO Matches (MatchId, HomeTeamGoals, AwayTeamGoals, MatchDate, HomeTeamId, AwayTeamId, GameweekId)
VALUES
(UUID(), 1, 4, '2023-11-06', (SELECT TeamId FROM Teams WHERE TeamName = 'Tottenham'), (SELECT TeamId FROM Teams WHERE TeamName = 'Chelsea'), (SELECT GameweekId FROM Gameweeks WHERE GameweekNumber = 11)),
(UUID(), 1, 1, '2023-11-05', (SELECT TeamId FROM Teams WHERE TeamName = 'Luton'), (SELECT TeamId FROM Teams WHERE TeamName = 'Liverpool'), (SELECT GameweekId FROM Gameweeks WHERE GameweekNumber = 11)),
(UUID(), 2, 0, '2023-11-05', (SELECT TeamId FROM Teams WHERE TeamName = 'Nottingham'), (SELECT TeamId FROM Teams WHERE TeamName = 'Aston Villa'), (SELECT GameweekId FROM Gameweeks WHERE GameweekNumber = 11)),
(UUID(), 1, 0, '2023-11-04', (SELECT TeamId FROM Teams WHERE TeamName = 'Newcastle'), (SELECT TeamId FROM Teams WHERE TeamName = 'Arsenal'), (SELECT GameweekId FROM Gameweeks WHERE GameweekNumber = 11)),
(UUID(), 3, 2, '2023-11-04', (SELECT TeamId FROM Teams WHERE TeamName = 'Brentford'), (SELECT TeamId FROM Teams WHERE TeamName = 'West Ham'), (SELECT GameweekId FROM Gameweeks WHERE GameweekNumber = 11)),
(UUID(), 0, 2, '2023-11-04', (SELECT TeamId FROM Teams WHERE TeamName = 'Burnley'), (SELECT TeamId FROM Teams WHERE TeamName = 'Crystal Palace'), (SELECT GameweekId FROM Gameweeks WHERE GameweekNumber = 11)),
(UUID(), 1, 1, '2023-11-04', (SELECT TeamId FROM Teams WHERE TeamName = 'Everton'), (SELECT TeamId FROM Teams WHERE TeamName = 'Brighton'), (SELECT GameweekId FROM Gameweeks WHERE GameweekNumber = 11)),
(UUID(), 6, 1, '2023-11-04', (SELECT TeamId FROM Teams WHERE TeamName = 'Manchester City'), (SELECT TeamId FROM Teams WHERE TeamName = 'Bournemouth'), (SELECT GameweekId FROM Gameweeks WHERE GameweekNumber = 11)),
(UUID(), 2, 1, '2023-11-04', (SELECT TeamId FROM Teams WHERE TeamName = 'Sheffield Utd'), (SELECT TeamId FROM Teams WHERE TeamName = 'Wolves'), (SELECT GameweekId FROM Gameweeks WHERE GameweekNumber = 11)),
(UUID(), 0, 1, '2023-11-04', (SELECT TeamId FROM Teams WHERE TeamName = 'Fulham'), (SELECT TeamId FROM Teams WHERE TeamName = 'Manchester Utd'), (SELECT GameweekId FROM Gameweeks WHERE GameweekNumber = 11));

INSERT INTO Matches (MatchId, HomeTeamGoals, AwayTeamGoals, MatchDate, HomeTeamId, AwayTeamId, GameweekId)
VALUES
(UUID(), 4, 4, '2023-11-12', (SELECT TeamId FROM Teams WHERE TeamName = 'Chelsea'), (SELECT TeamId FROM Teams WHERE TeamName = 'Manchester City'), (SELECT GameweekId FROM Gameweeks WHERE GameweekNumber = 12)),
(UUID(), 3, 1, '2023-11-12', (SELECT TeamId FROM Teams WHERE TeamName = 'Aston Villa'), (SELECT TeamId FROM Teams WHERE TeamName = 'Fulham'), (SELECT GameweekId FROM Gameweeks WHERE GameweekNumber = 12)),
(UUID(), 1, 1, '2023-11-12', (SELECT TeamId FROM Teams WHERE TeamName = 'Brighton'), (SELECT TeamId FROM Teams WHERE TeamName = 'Sheffield Utd'), (SELECT GameweekId FROM Gameweeks WHERE GameweekNumber = 12)),
(UUID(), 3, 0, '2023-11-12', (SELECT TeamId FROM Teams WHERE TeamName = 'Liverpool'), (SELECT TeamId FROM Teams WHERE TeamName = 'Brentford'), (SELECT GameweekId FROM Gameweeks WHERE GameweekNumber = 12)),
(UUID(), 3, 2, '2023-11-12', (SELECT TeamId FROM Teams WHERE TeamName = 'West Ham'), (SELECT TeamId FROM Teams WHERE TeamName = 'Nottingham'), (SELECT GameweekId FROM Gameweeks WHERE GameweekNumber = 12)),
(UUID(), 2, 0, '2023-11-11', (SELECT TeamId FROM Teams WHERE TeamName = 'Bournemouth'), (SELECT TeamId FROM Teams WHERE TeamName = 'Newcastle'), (SELECT GameweekId FROM Gameweeks WHERE GameweekNumber = 12)),
(UUID(), 3, 1, '2023-11-11', (SELECT TeamId FROM Teams WHERE TeamName = 'Arsenal'), (SELECT TeamId FROM Teams WHERE TeamName = 'Burnley'), (SELECT GameweekId FROM Gameweeks WHERE GameweekNumber = 12)),
(UUID(), 2, 3, '2023-11-11', (SELECT TeamId FROM Teams WHERE TeamName = 'Crystal Palace'), (SELECT TeamId FROM Teams WHERE TeamName = 'Everton'), (SELECT GameweekId FROM Gameweeks WHERE GameweekNumber = 12)),
(UUID(), 1, 0, '2023-11-11', (SELECT TeamId FROM Teams WHERE TeamName = 'Manchester Utd'), (SELECT TeamId FROM Teams WHERE TeamName = 'Luton'), (SELECT GameweekId FROM Gameweeks WHERE GameweekNumber = 12)),
(UUID(), 2, 1, '2023-11-11', (SELECT TeamId FROM Teams WHERE TeamName = 'Wolves'), (SELECT TeamId FROM Teams WHERE TeamName = 'Tottenham'), (SELECT GameweekId FROM Gameweeks WHERE GameweekNumber = 12));

INSERT INTO Matches (MatchId, HomeTeamGoals, AwayTeamGoals, MatchDate, HomeTeamId, AwayTeamId, GameweekId)
VALUES
(UUID(), 0, 3, '2023-11-26', (SELECT TeamId FROM Teams WHERE TeamName = 'Everton'), (SELECT TeamId FROM Teams WHERE TeamName = 'Manchester Utd'), (SELECT GameweekId FROM Gameweeks WHERE GameweekNumber = 13)),
(UUID(), 1, 2, '2023-11-26', (SELECT TeamId FROM Teams WHERE TeamName = 'Tottenham'), (SELECT TeamId FROM Teams WHERE TeamName = 'Aston Villa'), (SELECT GameweekId FROM Gameweeks WHERE GameweekNumber = 13)),
(UUID(), 0, 1, '2023-11-25', (SELECT TeamId FROM Teams WHERE TeamName = 'Brentford'), (SELECT TeamId FROM Teams WHERE TeamName = 'Arsenal'), (SELECT GameweekId FROM Gameweeks WHERE GameweekNumber = 13)),
(UUID(), 1, 2, '2023-11-25', (SELECT TeamId FROM Teams WHERE TeamName = 'Burnley'), (SELECT TeamId FROM Teams WHERE TeamName = 'West Ham'), (SELECT GameweekId FROM Gameweeks WHERE GameweekNumber = 13)),
(UUID(), 2, 1, '2023-11-25', (SELECT TeamId FROM Teams WHERE TeamName = 'Luton'), (SELECT TeamId FROM Teams WHERE TeamName = 'Crystal Palace'), (SELECT GameweekId FROM Gameweeks WHERE GameweekNumber = 13)),
(UUID(), 4, 1, '2023-11-25', (SELECT TeamId FROM Teams WHERE TeamName = 'Newcastle'), (SELECT TeamId FROM Teams WHERE TeamName = 'Chelsea'), (SELECT GameweekId FROM Gameweeks WHERE GameweekNumber = 13)),
(UUID(), 2, 3, '2023-11-25', (SELECT TeamId FROM Teams WHERE TeamName = 'Nottingham'), (SELECT TeamId FROM Teams WHERE TeamName = 'Brighton'), (SELECT GameweekId FROM Gameweeks WHERE GameweekNumber = 13)),
(UUID(), 1, 3, '2023-11-25', (SELECT TeamId FROM Teams WHERE TeamName = 'Sheffield Utd'), (SELECT TeamId FROM Teams WHERE TeamName = 'Bournemouth'), (SELECT GameweekId FROM Gameweeks WHERE GameweekNumber = 13)),
(UUID(), 1, 1, '2023-11-25', (SELECT TeamId FROM Teams WHERE TeamName = 'Manchester City'), (SELECT TeamId FROM Teams WHERE TeamName = 'Liverpool'), (SELECT GameweekId FROM Gameweeks WHERE GameweekNumber = 13)),
(UUID(), NULL, NULL, '2023-11-27', (SELECT TeamId FROM Teams WHERE TeamName = 'Fulham'), (SELECT TeamId FROM Teams WHERE TeamName = 'Wolves'), (SELECT GameweekId FROM Gameweeks WHERE GameweekNumber = 13));

INSERT INTO Matches (MatchId, HomeTeamGoals, AwayTeamGoals, MatchDate, HomeTeamId, AwayTeamId, GameweekId)
VALUES
(UUID(), NULL, NULL, '2023-12-02', (SELECT TeamId FROM Teams WHERE TeamName = 'Arsenal'), (SELECT TeamId FROM Teams WHERE TeamName = 'Wolves'), (SELECT GameweekId FROM Gameweeks WHERE GameweekNumber = 14)),
(UUID(), NULL, NULL, '2023-12-02', (SELECT TeamId FROM Teams WHERE TeamName = 'Brentford'), (SELECT TeamId FROM Teams WHERE TeamName = 'Luton'), (SELECT GameweekId FROM Gameweeks WHERE GameweekNumber = 14)),
(UUID(), NULL, NULL, '2023-12-02', (SELECT TeamId FROM Teams WHERE TeamName = 'Burnley'), (SELECT TeamId FROM Teams WHERE TeamName = 'Sheffield Utd'), (SELECT GameweekId FROM Gameweeks WHERE GameweekNumber = 14)),
(UUID(), NULL, NULL, '2023-12-02', (SELECT TeamId FROM Teams WHERE TeamName = 'Nottingham'), (SELECT TeamId FROM Teams WHERE TeamName = 'Everton'), (SELECT GameweekId FROM Gameweeks WHERE GameweekNumber = 14)),
(UUID(), NULL, NULL, '2023-12-02', (SELECT TeamId FROM Teams WHERE TeamName = 'Newcastle'), (SELECT TeamId FROM Teams WHERE TeamName = 'Manchester Utd'), (SELECT GameweekId FROM Gameweeks WHERE GameweekNumber = 14)),
(UUID(), NULL, NULL, '2023-12-03', (SELECT TeamId FROM Teams WHERE TeamName = 'Bournemouth'), (SELECT TeamId FROM Teams WHERE TeamName = 'Aston Villa'), (SELECT GameweekId FROM Gameweeks WHERE GameweekNumber = 14)),
(UUID(), NULL, NULL, '2023-12-03', (SELECT TeamId FROM Teams WHERE TeamName = 'Chelsea'), (SELECT TeamId FROM Teams WHERE TeamName = 'Brighton'), (SELECT GameweekId FROM Gameweeks WHERE GameweekNumber = 14)),
(UUID(), NULL, NULL, '2023-12-03', (SELECT TeamId FROM Teams WHERE TeamName = 'Liverpool'), (SELECT TeamId FROM Teams WHERE TeamName = 'Fulham'), (SELECT GameweekId FROM Gameweeks WHERE GameweekNumber = 14)),
(UUID(), NULL, NULL, '2023-12-03', (SELECT TeamId FROM Teams WHERE TeamName = 'West Ham'), (SELECT TeamId FROM Teams WHERE TeamName = 'Crystal Palace'), (SELECT GameweekId FROM Gameweeks WHERE GameweekNumber = 14)),
(UUID(), NULL, NULL, '2023-12-03', (SELECT TeamId FROM Teams WHERE TeamName = 'Manchester City'), (SELECT TeamId FROM Teams WHERE TeamName = 'Tottenham'), (SELECT GameweekId FROM Gameweeks WHERE GameweekNumber = 14));

INSERT INTO Matches (MatchId, HomeTeamGoals, AwayTeamGoals, MatchDate, HomeTeamId, AwayTeamId, GameweekId)
VALUES
(UUID(), NULL, NULL, '2023-12-05', (SELECT TeamId FROM Teams WHERE TeamName = 'Wolves'), (SELECT TeamId FROM Teams WHERE TeamName = 'Burnley'), (SELECT GameweekId FROM Gameweeks WHERE GameweekNumber = 15)),
(UUID(), NULL, NULL, '2023-12-05', (SELECT TeamId FROM Teams WHERE TeamName = 'Luton'), (SELECT TeamId FROM Teams WHERE TeamName = 'Arsenal'), (SELECT GameweekId FROM Gameweeks WHERE GameweekNumber = 15)),
(UUID(), NULL, NULL, '2023-12-06', (SELECT TeamId FROM Teams WHERE TeamName = 'Brighton'), (SELECT TeamId FROM Teams WHERE TeamName = 'Brentford'), (SELECT GameweekId FROM Gameweeks WHERE GameweekNumber = 15)),
(UUID(), NULL, NULL, '2023-12-06', (SELECT TeamId FROM Teams WHERE TeamName = 'Crystal Palace'), (SELECT TeamId FROM Teams WHERE TeamName = 'Bournemouth'), (SELECT GameweekId FROM Gameweeks WHERE GameweekNumber = 15)),
(UUID(), NULL, NULL, '2023-12-06', (SELECT TeamId FROM Teams WHERE TeamName = 'Fulham'), (SELECT TeamId FROM Teams WHERE TeamName = 'Nottingham'), (SELECT GameweekId FROM Gameweeks WHERE GameweekNumber = 15)),
(UUID(), NULL, NULL, '2023-12-06', (SELECT TeamId FROM Teams WHERE TeamName = 'Sheffield Utd'), (SELECT TeamId FROM Teams WHERE TeamName = 'Liverpool'), (SELECT GameweekId FROM Gameweeks WHERE GameweekNumber = 15)),
(UUID(), NULL, NULL, '2023-12-06', (SELECT TeamId FROM Teams WHERE TeamName = 'Aston Villa'), (SELECT TeamId FROM Teams WHERE TeamName = 'Manchester City'), (SELECT GameweekId FROM Gameweeks WHERE GameweekNumber = 15)),
(UUID(), NULL, NULL, '2023-12-06', (SELECT TeamId FROM Teams WHERE TeamName = 'Manchester Utd'), (SELECT TeamId FROM Teams WHERE TeamName = 'Chelsea'), (SELECT GameweekId FROM Gameweeks WHERE GameweekNumber = 15)),
(UUID(), NULL, NULL, '2023-12-07', (SELECT TeamId FROM Teams WHERE TeamName = 'Everton'), (SELECT TeamId FROM Teams WHERE TeamName = 'Newcastle'), (SELECT GameweekId FROM Gameweeks WHERE GameweekNumber = 15)),
(UUID(), NULL, NULL, '2023-12-07', (SELECT TeamId FROM Teams WHERE TeamName = 'Tottenham'), (SELECT TeamId FROM Teams WHERE TeamName = 'West Ham'), (SELECT GameweekId FROM Gameweeks WHERE GameweekNumber = 15));

INSERT INTO Matches (MatchId, HomeTeamGoals, AwayTeamGoals, MatchDate, HomeTeamId, AwayTeamId, GameweekId)
VALUES
(UUID(), NULL, NULL, '2023-12-09', (SELECT TeamId FROM Teams WHERE TeamName = 'Crystal Palace'), (SELECT TeamId FROM Teams WHERE TeamName = 'Liverpool'), (SELECT GameweekId FROM Gameweeks WHERE GameweekNumber = 16)),
(UUID(), NULL, NULL, '2023-12-09', (SELECT TeamId FROM Teams WHERE TeamName = 'Brighton'), (SELECT TeamId FROM Teams WHERE TeamName = 'Burnley'), (SELECT GameweekId FROM Gameweeks WHERE GameweekNumber = 16)),
(UUID(), NULL, NULL, '2023-12-09', (SELECT TeamId FROM Teams WHERE TeamName = 'Manchester Utd'), (SELECT TeamId FROM Teams WHERE TeamName = 'Bournemouth'), (SELECT GameweekId FROM Gameweeks WHERE GameweekNumber = 16)),
(UUID(), NULL, NULL, '2023-12-09', (SELECT TeamId FROM Teams WHERE TeamName = 'Sheffield Utd'), (SELECT TeamId FROM Teams WHERE TeamName = 'Brentford'), (SELECT GameweekId FROM Gameweeks WHERE GameweekNumber = 16)),
(UUID(), NULL, NULL, '2023-12-09', (SELECT TeamId FROM Teams WHERE TeamName = 'Wolves'), (SELECT TeamId FROM Teams WHERE TeamName = 'Nottingham'), (SELECT GameweekId FROM Gameweeks WHERE GameweekNumber = 16)),
(UUID(), NULL, NULL, '2023-12-09', (SELECT TeamId FROM Teams WHERE TeamName = 'Aston Villa'), (SELECT TeamId FROM Teams WHERE TeamName = 'Arsenal'), (SELECT GameweekId FROM Gameweeks WHERE GameweekNumber = 16)),
(UUID(), NULL, NULL, '2023-12-10', (SELECT TeamId FROM Teams WHERE TeamName = 'Everton'), (SELECT TeamId FROM Teams WHERE TeamName = 'Chelsea'), (SELECT GameweekId FROM Gameweeks WHERE GameweekNumber = 16)),
(UUID(), NULL, NULL, '2023-12-10', (SELECT TeamId FROM Teams WHERE TeamName = 'Fulham'), (SELECT TeamId FROM Teams WHERE TeamName = 'West Ham'), (SELECT GameweekId FROM Gameweeks WHERE GameweekNumber = 16)),
(UUID(), NULL, NULL, '2023-12-10', (SELECT TeamId FROM Teams WHERE TeamName = 'Luton'), (SELECT TeamId FROM Teams WHERE TeamName = 'Manchester City'), (SELECT GameweekId FROM Gameweeks WHERE GameweekNumber = 16)),
(UUID(), NULL, NULL, '2023-12-10', (SELECT TeamId FROM Teams WHERE TeamName = 'Tottenham'), (SELECT TeamId FROM Teams WHERE TeamName = 'Newcastle'), (SELECT GameweekId FROM Gameweeks WHERE GameweekNumber = 16));

INSERT INTO Matches (MatchId, HomeTeamGoals, AwayTeamGoals, MatchDate, HomeTeamId, AwayTeamId, GameweekId)
VALUES
(UUID(), NULL, NULL, '2023-12-15', (SELECT TeamId FROM Teams WHERE TeamName = 'Nottingham'), (SELECT TeamId FROM Teams WHERE TeamName = 'Tottenham'), (SELECT GameweekId FROM Gameweeks WHERE GameweekNumber = 17)),
(UUID(), NULL, NULL, '2023-12-16', (SELECT TeamId FROM Teams WHERE TeamName = 'Bournemouth'), (SELECT TeamId FROM Teams WHERE TeamName = 'Luton'), (SELECT GameweekId FROM Gameweeks WHERE GameweekNumber = 17)),
(UUID(), NULL, NULL, '2023-12-16', (SELECT TeamId FROM Teams WHERE TeamName = 'Chelsea'), (SELECT TeamId FROM Teams WHERE TeamName = 'Sheffield Utd'), (SELECT GameweekId FROM Gameweeks WHERE GameweekNumber = 17)),
(UUID(), NULL, NULL, '2023-12-16', (SELECT TeamId FROM Teams WHERE TeamName = 'Manchester City'), (SELECT TeamId FROM Teams WHERE TeamName = 'Crystal Palace'), (SELECT GameweekId FROM Gameweeks WHERE GameweekNumber = 17)),
(UUID(), NULL, NULL, '2023-12-16', (SELECT TeamId FROM Teams WHERE TeamName = 'Newcastle'), (SELECT TeamId FROM Teams WHERE TeamName = 'Fulham'), (SELECT GameweekId FROM Gameweeks WHERE GameweekNumber = 17)),
(UUID(), NULL, NULL, '2023-12-16', (SELECT TeamId FROM Teams WHERE TeamName = 'Burnley'), (SELECT TeamId FROM Teams WHERE TeamName = 'Everton'), (SELECT GameweekId FROM Gameweeks WHERE GameweekNumber = 17)),
(UUID(), NULL, NULL, '2023-12-17', (SELECT TeamId FROM Teams WHERE TeamName = 'Arsenal'), (SELECT TeamId FROM Teams WHERE TeamName = 'Brighton'), (SELECT GameweekId FROM Gameweeks WHERE GameweekNumber = 17)),
(UUID(), NULL, NULL, '2023-12-17', (SELECT TeamId FROM Teams WHERE TeamName = 'Brentford'), (SELECT TeamId FROM Teams WHERE TeamName = 'Aston Villa'), (SELECT GameweekId FROM Gameweeks WHERE GameweekNumber = 17)),
(UUID(), NULL, NULL, '2023-12-17', (SELECT TeamId FROM Teams WHERE TeamName = 'West Ham'), (SELECT TeamId FROM Teams WHERE TeamName = 'Wolves'), (SELECT GameweekId FROM Gameweeks WHERE GameweekNumber = 17)),
(UUID(), NULL, NULL, '2023-12-17', (SELECT TeamId FROM Teams WHERE TeamName = 'Liverpool'), (SELECT TeamId FROM Teams WHERE TeamName = 'Manchester Utd'), (SELECT GameweekId FROM Gameweeks WHERE GameweekNumber = 17));

INSERT INTO Matches (MatchId, HomeTeamGoals, AwayTeamGoals, MatchDate, HomeTeamId, AwayTeamId, GameweekId)
VALUES
(UUID(), NULL, NULL, '2023-12-21', (SELECT TeamId FROM Teams WHERE TeamName = 'Crystal Palace'), (SELECT TeamId FROM Teams WHERE TeamName = 'Brighton'), (SELECT GameweekId FROM Gameweeks WHERE GameweekNumber = 18)),
(UUID(), NULL, NULL, '2023-12-22', (SELECT TeamId FROM Teams WHERE TeamName = 'Aston Villa'), (SELECT TeamId FROM Teams WHERE TeamName = 'Sheffield Utd'), (SELECT GameweekId FROM Gameweeks WHERE GameweekNumber = 18)),
(UUID(), NULL, NULL, '2023-12-23', (SELECT TeamId FROM Teams WHERE TeamName = 'West Ham'), (SELECT TeamId FROM Teams WHERE TeamName = 'Manchester Utd'), (SELECT GameweekId FROM Gameweeks WHERE GameweekNumber = 18)),
(UUID(), NULL, NULL, '2023-12-23', (SELECT TeamId FROM Teams WHERE TeamName = 'Fulham'), (SELECT TeamId FROM Teams WHERE TeamName = 'Burnley'), (SELECT GameweekId FROM Gameweeks WHERE GameweekNumber = 18)),
(UUID(), NULL, NULL, '2023-12-23', (SELECT TeamId FROM Teams WHERE TeamName = 'Luton'), (SELECT TeamId FROM Teams WHERE TeamName = 'Newcastle'), (SELECT GameweekId FROM Gameweeks WHERE GameweekNumber = 18)),
(UUID(), NULL, NULL, '2023-12-23', (SELECT TeamId FROM Teams WHERE TeamName = 'Manchester City'), (SELECT TeamId FROM Teams WHERE TeamName = 'Brentford'), (SELECT GameweekId FROM Gameweeks WHERE GameweekNumber = 18)),
(UUID(), NULL, NULL, '2023-12-23', (SELECT TeamId FROM Teams WHERE TeamName = 'Nottingham'), (SELECT TeamId FROM Teams WHERE TeamName = 'Bournemouth'), (SELECT GameweekId FROM Gameweeks WHERE GameweekNumber = 18)),
(UUID(), NULL, NULL, '2023-12-23', (SELECT TeamId FROM Teams WHERE TeamName = 'Tottenham'), (SELECT TeamId FROM Teams WHERE TeamName = 'Everton'), (SELECT GameweekId FROM Gameweeks WHERE GameweekNumber = 18)),
(UUID(), NULL, NULL, '2023-12-23', (SELECT TeamId FROM Teams WHERE TeamName = 'Liverpool'), (SELECT TeamId FROM Teams WHERE TeamName = 'Arsenal'), (SELECT GameweekId FROM Gameweeks WHERE GameweekNumber = 18)),
(UUID(), NULL, NULL, '2023-12-24', (SELECT TeamId FROM Teams WHERE TeamName = 'Wolves'), (SELECT TeamId FROM Teams WHERE TeamName = 'Chelsea'), (SELECT GameweekId FROM Gameweeks WHERE GameweekNumber = 18));

INSERT INTO Matches (MatchId, HomeTeamGoals, AwayTeamGoals, MatchDate, HomeTeamId, AwayTeamId, GameweekId)
VALUES
(UUID(), NULL, NULL, '2023-12-26', (SELECT TeamId FROM Teams WHERE TeamName = 'Newcastle'), (SELECT TeamId FROM Teams WHERE TeamName = 'Nottingham'), (SELECT GameweekId FROM Gameweeks WHERE GameweekNumber = 19)),
(UUID(), NULL, NULL, '2023-12-26', (SELECT TeamId FROM Teams WHERE TeamName = 'Bournemouth'), (SELECT TeamId FROM Teams WHERE TeamName = 'Fulham'), (SELECT GameweekId FROM Gameweeks WHERE GameweekNumber = 19)),
(UUID(), NULL, NULL, '2023-12-26', (SELECT TeamId FROM Teams WHERE TeamName = 'Sheffield Utd'), (SELECT TeamId FROM Teams WHERE TeamName = 'Luton'), (SELECT GameweekId FROM Gameweeks WHERE GameweekNumber = 19)),
(UUID(), NULL, NULL, '2023-12-26', (SELECT TeamId FROM Teams WHERE TeamName = 'Burnley'), (SELECT TeamId FROM Teams WHERE TeamName = 'Liverpool'), (SELECT GameweekId FROM Gameweeks WHERE GameweekNumber = 19)),
(UUID(), NULL, NULL, '2023-12-26', (SELECT TeamId FROM Teams WHERE TeamName = 'Manchester Utd'), (SELECT TeamId FROM Teams WHERE TeamName = 'Aston Villa'), (SELECT GameweekId FROM Gameweeks WHERE GameweekNumber = 19)),
(UUID(), NULL, NULL, '2023-12-27', (SELECT TeamId FROM Teams WHERE TeamName = 'Brentford'), (SELECT TeamId FROM Teams WHERE TeamName = 'Wolves'), (SELECT GameweekId FROM Gameweeks WHERE GameweekNumber = 19)),
(UUID(), NULL, NULL, '2023-12-27', (SELECT TeamId FROM Teams WHERE TeamName = 'Chelsea'), (SELECT TeamId FROM Teams WHERE TeamName = 'Crystal Palace'), (SELECT GameweekId FROM Gameweeks WHERE GameweekNumber = 19)),
(UUID(), NULL, NULL, '2023-12-27', (SELECT TeamId FROM Teams WHERE TeamName = 'Everton'), (SELECT TeamId FROM Teams WHERE TeamName = 'Manchester City'), (SELECT GameweekId FROM Gameweeks WHERE GameweekNumber = 19)),
(UUID(), NULL, NULL, '2023-12-28', (SELECT TeamId FROM Teams WHERE TeamName = 'Brighton'), (SELECT TeamId FROM Teams WHERE TeamName = 'Tottenham'), (SELECT GameweekId FROM Gameweeks WHERE GameweekNumber = 19)),
(UUID(), NULL, NULL, '2023-12-28', (SELECT TeamId FROM Teams WHERE TeamName = 'Arsenal'), (SELECT TeamId FROM Teams WHERE TeamName = 'West Ham'), (SELECT GameweekId FROM Gameweeks WHERE GameweekNumber = 19));

INSERT INTO Matches (MatchId, HomeTeamGoals, AwayTeamGoals, MatchDate, HomeTeamId, AwayTeamId, GameweekId)
VALUES
(UUID(), NULL, NULL, '2023-12-30', (SELECT TeamId FROM Teams WHERE TeamName = 'Luton'), (SELECT TeamId FROM Teams WHERE TeamName = 'Chelsea'), (SELECT GameweekId FROM Gameweeks WHERE GameweekNumber = 20)),
(UUID(), NULL, NULL, '2023-12-30', (SELECT TeamId FROM Teams WHERE TeamName = 'Aston Villa'), (SELECT TeamId FROM Teams WHERE TeamName = 'Burnley'), (SELECT GameweekId FROM Gameweeks WHERE GameweekNumber = 20)),
(UUID(), NULL, NULL, '2023-12-30', (SELECT TeamId FROM Teams WHERE TeamName = 'Crystal Palace'), (SELECT TeamId FROM Teams WHERE TeamName = 'Brentford'), (SELECT GameweekId FROM Gameweeks WHERE GameweekNumber = 20)),
(UUID(), NULL, NULL, '2023-12-30', (SELECT TeamId FROM Teams WHERE TeamName = 'Manchester City'), (SELECT TeamId FROM Teams WHERE TeamName = 'Sheffield Utd'), (SELECT GameweekId FROM Gameweeks WHERE GameweekNumber = 20)),
(UUID(), NULL, NULL, '2023-12-30', (SELECT TeamId FROM Teams WHERE TeamName = 'Wolves'), (SELECT TeamId FROM Teams WHERE TeamName = 'Everton'), (SELECT GameweekId FROM Gameweeks WHERE GameweekNumber = 20)),
(UUID(), NULL, NULL, '2023-12-30', (SELECT TeamId FROM Teams WHERE TeamName = 'Nottingham'), (SELECT TeamId FROM Teams WHERE TeamName = 'Manchester Utd'), (SELECT GameweekId FROM Gameweeks WHERE GameweekNumber = 20)),
(UUID(), NULL, NULL, '2023-12-31', (SELECT TeamId FROM Teams WHERE TeamName = 'Fulham'), (SELECT TeamId FROM Teams WHERE TeamName = 'Arsenal'), (SELECT GameweekId FROM Gameweeks WHERE GameweekNumber = 20)),
(UUID(), NULL, NULL, '2023-12-31', (SELECT TeamId FROM Teams WHERE TeamName = 'Tottenham'), (SELECT TeamId FROM Teams WHERE TeamName = 'Bournemouth'), (SELECT GameweekId FROM Gameweeks WHERE GameweekNumber = 20)),
(UUID(), NULL, NULL, '2023-01-01', (SELECT TeamId FROM Teams WHERE TeamName = 'Liverpool'), (SELECT TeamId FROM Teams WHERE TeamName = 'Newcastle'), (SELECT GameweekId FROM Gameweeks WHERE GameweekNumber = 20)),
(UUID(), NULL, NULL, '2023-01-02', (SELECT TeamId FROM Teams WHERE TeamName = 'West Ham'), (SELECT TeamId FROM Teams WHERE TeamName = 'Brighton'), (SELECT GameweekId FROM Gameweeks WHERE GameweekNumber = 20));

INSERT INTO Matches (MatchId, HomeTeamGoals, AwayTeamGoals, MatchDate, HomeTeamId, AwayTeamId, GameweekId)
VALUES
(UUID(), NULL, NULL, '2023-01-13', (SELECT TeamId FROM Teams WHERE TeamName = 'Chelsea'), (SELECT TeamId FROM Teams WHERE TeamName = 'Fulham'), (SELECT GameweekId FROM Gameweeks WHERE GameweekNumber = 21)),
(UUID(), NULL, NULL, '2023-01-13', (SELECT TeamId FROM Teams WHERE TeamName = 'Newcastle'), (SELECT TeamId FROM Teams WHERE TeamName = 'Manchester City'), (SELECT GameweekId FROM Gameweeks WHERE GameweekNumber = 21)),
(UUID(), NULL, NULL, '2023-01-14', (SELECT TeamId FROM Teams WHERE TeamName = 'Everton'), (SELECT TeamId FROM Teams WHERE TeamName = 'Aston Villa'), (SELECT GameweekId FROM Gameweeks WHERE GameweekNumber = 21)),
(UUID(), NULL, NULL, '2023-01-14', (SELECT TeamId FROM Teams WHERE TeamName = 'Manchester Utd'), (SELECT TeamId FROM Teams WHERE TeamName = 'Tottenham'), (SELECT GameweekId FROM Gameweeks WHERE GameweekNumber = 21)),
(UUID(), NULL, NULL, '2023-01-15', (SELECT TeamId FROM Teams WHERE TeamName = 'Burnley'), (SELECT TeamId FROM Teams WHERE TeamName = 'Luton'), (SELECT GameweekId FROM Gameweeks WHERE GameweekNumber = 21)),
(UUID(), NULL, NULL, '2023-01-20', (SELECT TeamId FROM Teams WHERE TeamName = 'Arsenal'), (SELECT TeamId FROM Teams WHERE TeamName = 'Crystal Palace'), (SELECT GameweekId FROM Gameweeks WHERE GameweekNumber = 21)),
(UUID(), NULL, NULL, '2023-01-20', (SELECT TeamId FROM Teams WHERE TeamName = 'Brentford'), (SELECT TeamId FROM Teams WHERE TeamName = 'Nottingham'), (SELECT GameweekId FROM Gameweeks WHERE GameweekNumber = 21)),
(UUID(), NULL, NULL, '2023-01-21', (SELECT TeamId FROM Teams WHERE TeamName = 'Sheffield Utd'), (SELECT TeamId FROM Teams WHERE TeamName = 'West Ham'), (SELECT GameweekId FROM Gameweeks WHERE GameweekNumber = 21)),
(UUID(), NULL, NULL, '2023-01-21', (SELECT TeamId FROM Teams WHERE TeamName = 'Bournemouth'), (SELECT TeamId FROM Teams WHERE TeamName = 'Liverpool'), (SELECT GameweekId FROM Gameweeks WHERE GameweekNumber = 21)),
(UUID(), NULL, NULL, '2023-01-22', (SELECT TeamId FROM Teams WHERE TeamName = 'Brighton'), (SELECT TeamId FROM Teams WHERE TeamName = 'Wolves'), (SELECT GameweekId FROM Gameweeks WHERE GameweekNumber = 21));

INSERT INTO Matches (MatchId, HomeTeamGoals, AwayTeamGoals, MatchDate, HomeTeamId, AwayTeamId, GameweekId)
VALUES
(UUID(), NULL, NULL, '2023-01-30', (SELECT TeamId FROM Teams WHERE TeamName = 'Aston Villa'), (SELECT TeamId FROM Teams WHERE TeamName = 'Newcastle'), (SELECT GameweekId FROM Gameweeks WHERE GameweekNumber = 22)),
(UUID(), NULL, NULL, '2023-01-30', (SELECT TeamId FROM Teams WHERE TeamName = 'Fulham'), (SELECT TeamId FROM Teams WHERE TeamName = 'Everton'), (SELECT GameweekId FROM Gameweeks WHERE GameweekNumber = 22)),
(UUID(), NULL, NULL, '2023-01-30', (SELECT TeamId FROM Teams WHERE TeamName = 'Luton'), (SELECT TeamId FROM Teams WHERE TeamName = 'Brighton'), (SELECT GameweekId FROM Gameweeks WHERE GameweekNumber = 22)),
(UUID(), NULL, NULL, '2023-01-30', (SELECT TeamId FROM Teams WHERE TeamName = 'Nottingham'), (SELECT TeamId FROM Teams WHERE TeamName = 'Arsenal'), (SELECT GameweekId FROM Gameweeks WHERE GameweekNumber = 22)),
(UUID(), NULL, NULL, '2023-01-30', (SELECT TeamId FROM Teams WHERE TeamName = 'Tottenham'), (SELECT TeamId FROM Teams WHERE TeamName = 'Brentford'), (SELECT GameweekId FROM Gameweeks WHERE GameweekNumber = 22)),
(UUID(), NULL, NULL, '2023-01-30', (SELECT TeamId FROM Teams WHERE TeamName = 'West Ham'), (SELECT TeamId FROM Teams WHERE TeamName = 'Bournemouth'), (SELECT GameweekId FROM Gameweeks WHERE GameweekNumber = 22)),
(UUID(), NULL, NULL, '2023-01-30', (SELECT TeamId FROM Teams WHERE TeamName = 'Wolves'), (SELECT TeamId FROM Teams WHERE TeamName = 'Manchester Utd'), (SELECT GameweekId FROM Gameweeks WHERE GameweekNumber = 22)),
(UUID(), NULL, NULL, '2023-01-30', (SELECT TeamId FROM Teams WHERE TeamName = 'Crystal Palace'), (SELECT TeamId FROM Teams WHERE TeamName = 'Sheffield Utd'), (SELECT GameweekId FROM Gameweeks WHERE GameweekNumber = 22)),
(UUID(), NULL, NULL, '2023-01-31', (SELECT TeamId FROM Teams WHERE TeamName = 'Liverpool'), (SELECT TeamId FROM Teams WHERE TeamName = 'Chelsea'), (SELECT GameweekId FROM Gameweeks WHERE GameweekNumber = 22)),
(UUID(), NULL, NULL, '2023-01-31', (SELECT TeamId FROM Teams WHERE TeamName = 'Manchester City'), (SELECT TeamId FROM Teams WHERE TeamName = 'Burnley'), (SELECT GameweekId FROM Gameweeks WHERE GameweekNumber = 22));

INSERT INTO Matches (MatchId, HomeTeamGoals, AwayTeamGoals, MatchDate, HomeTeamId, AwayTeamId, GameweekId)
VALUES
(UUID(), NULL, NULL, '2023-02-03', (SELECT TeamId FROM Teams WHERE TeamName = 'Arsenal'), (SELECT TeamId FROM Teams WHERE TeamName = 'Liverpool'), (SELECT GameweekId FROM Gameweeks WHERE GameweekNumber = 23)),
(UUID(), NULL, NULL, '2023-02-03', (SELECT TeamId FROM Teams WHERE TeamName = 'Bournemouth'), (SELECT TeamId FROM Teams WHERE TeamName = 'Nottingham'), (SELECT GameweekId FROM Gameweeks WHERE GameweekNumber = 23)),
(UUID(), NULL, NULL, '2023-02-03', (SELECT TeamId FROM Teams WHERE TeamName = 'Brentford'), (SELECT TeamId FROM Teams WHERE TeamName = 'Manchester City'), (SELECT GameweekId FROM Gameweeks WHERE GameweekNumber = 23)),
(UUID(), NULL, NULL, '2023-02-03', (SELECT TeamId FROM Teams WHERE TeamName = 'Brighton'), (SELECT TeamId FROM Teams WHERE TeamName = 'Crystal Palace'), (SELECT GameweekId FROM Gameweeks WHERE GameweekNumber = 23)),
(UUID(), NULL, NULL, '2023-02-03', (SELECT TeamId FROM Teams WHERE TeamName = 'Burnley'), (SELECT TeamId FROM Teams WHERE TeamName = 'Fulham'), (SELECT GameweekId FROM Gameweeks WHERE GameweekNumber = 23)),
(UUID(), NULL, NULL, '2023-02-03', (SELECT TeamId FROM Teams WHERE TeamName = 'Chelsea'), (SELECT TeamId FROM Teams WHERE TeamName = 'Wolves'), (SELECT GameweekId FROM Gameweeks WHERE GameweekNumber = 23)),
(UUID(), NULL, NULL, '2023-02-03', (SELECT TeamId FROM Teams WHERE TeamName = 'Everton'), (SELECT TeamId FROM Teams WHERE TeamName = 'Tottenham'), (SELECT GameweekId FROM Gameweeks WHERE GameweekNumber = 23)),
(UUID(), NULL, NULL, '2023-02-03', (SELECT TeamId FROM Teams WHERE TeamName = 'Manchester Utd'), (SELECT TeamId FROM Teams WHERE TeamName = 'West Ham'), (SELECT GameweekId FROM Gameweeks WHERE GameweekNumber = 23)),
(UUID(), NULL, NULL, '2023-02-03', (SELECT TeamId FROM Teams WHERE TeamName = 'Newcastle'), (SELECT TeamId FROM Teams WHERE TeamName = 'Luton'), (SELECT GameweekId FROM Gameweeks WHERE GameweekNumber = 23)),
(UUID(), NULL, NULL, '2023-02-03', (SELECT TeamId FROM Teams WHERE TeamName = 'Sheffield Utd'), (SELECT TeamId FROM Teams WHERE TeamName = 'Aston Villa'), (SELECT GameweekId FROM Gameweeks WHERE GameweekNumber = 23));

INSERT INTO Matches (MatchId, HomeTeamGoals, AwayTeamGoals, MatchDate, HomeTeamId, AwayTeamId, GameweekId)
VALUES
(UUID(), NULL, NULL, '2023-02-10', (SELECT TeamId FROM Teams WHERE TeamName = 'Aston Villa'), (SELECT TeamId FROM Teams WHERE TeamName = 'Manchester Utd'), (SELECT GameweekId FROM Gameweeks WHERE GameweekNumber = 24)),
(UUID(), NULL, NULL, '2023-02-10', (SELECT TeamId FROM Teams WHERE TeamName = 'Crystal Palace'), (SELECT TeamId FROM Teams WHERE TeamName = 'Chelsea'), (SELECT GameweekId FROM Gameweeks WHERE GameweekNumber = 24)),
(UUID(), NULL, NULL, '2023-02-10', (SELECT TeamId FROM Teams WHERE TeamName = 'Fulham'), (SELECT TeamId FROM Teams WHERE TeamName = 'Bournemouth'), (SELECT GameweekId FROM Gameweeks WHERE GameweekNumber = 24)),
(UUID(), NULL, NULL, '2023-02-10', (SELECT TeamId FROM Teams WHERE TeamName = 'Liverpool'), (SELECT TeamId FROM Teams WHERE TeamName = 'Burnley'), (SELECT GameweekId FROM Gameweeks WHERE GameweekNumber = 24)),
(UUID(), NULL, NULL, '2023-02-10', (SELECT TeamId FROM Teams WHERE TeamName = 'Luton'), (SELECT TeamId FROM Teams WHERE TeamName = 'Sheffield Utd'), (SELECT GameweekId FROM Gameweeks WHERE GameweekNumber = 24)),
(UUID(), NULL, NULL, '2023-02-10', (SELECT TeamId FROM Teams WHERE TeamName = 'Manchester City'), (SELECT TeamId FROM Teams WHERE TeamName = 'Everton'), (SELECT GameweekId FROM Gameweeks WHERE GameweekNumber = 24)),
(UUID(), NULL, NULL, '2023-02-10', (SELECT TeamId FROM Teams WHERE TeamName = 'Nottingham'), (SELECT TeamId FROM Teams WHERE TeamName = 'Newcastle'), (SELECT GameweekId FROM Gameweeks WHERE GameweekNumber = 24)),
(UUID(), NULL, NULL, '2023-02-10', (SELECT TeamId FROM Teams WHERE TeamName = 'Tottenham'), (SELECT TeamId FROM Teams WHERE TeamName = 'Brighton'), (SELECT GameweekId FROM Gameweeks WHERE GameweekNumber = 24)),
(UUID(), NULL, NULL, '2023-02-10', (SELECT TeamId FROM Teams WHERE TeamName = 'West Ham'), (SELECT TeamId FROM Teams WHERE TeamName = 'Arsenal'), (SELECT GameweekId FROM Gameweeks WHERE GameweekNumber = 24)),
(UUID(), NULL, NULL, '2023-02-10', (SELECT TeamId FROM Teams WHERE TeamName = 'Wolves'), (SELECT TeamId FROM Teams WHERE TeamName = 'Brentford'), (SELECT GameweekId FROM Gameweeks WHERE GameweekNumber = 24));

INSERT INTO Matches (MatchId, HomeTeamGoals, AwayTeamGoals, MatchDate, HomeTeamId, AwayTeamId, GameweekId)
VALUES
(UUID(), NULL, NULL, '2023-02-17', (SELECT TeamId FROM Teams WHERE TeamName = 'Brentford'), (SELECT TeamId FROM Teams WHERE TeamName = 'Liverpool'), (SELECT GameweekId FROM Gameweeks WHERE GameweekNumber = 25)),
(UUID(), NULL, NULL, '2023-02-17', (SELECT TeamId FROM Teams WHERE TeamName = 'Burnley'), (SELECT TeamId FROM Teams WHERE TeamName = 'Arsenal'), (SELECT GameweekId FROM Gameweeks WHERE GameweekNumber = 25)),
(UUID(), NULL, NULL, '2023-02-17', (SELECT TeamId FROM Teams WHERE TeamName = 'Everton'), (SELECT TeamId FROM Teams WHERE TeamName = 'Crystal Palace'), (SELECT GameweekId FROM Gameweeks WHERE GameweekNumber = 25)),
(UUID(), NULL, NULL, '2023-02-17', (SELECT TeamId FROM Teams WHERE TeamName = 'Fulham'), (SELECT TeamId FROM Teams WHERE TeamName = 'Aston Villa'), (SELECT GameweekId FROM Gameweeks WHERE GameweekNumber = 25)),
(UUID(), NULL, NULL, '2023-02-17', (SELECT TeamId FROM Teams WHERE TeamName = 'Luton'), (SELECT TeamId FROM Teams WHERE TeamName = 'Manchester Utd'), (SELECT GameweekId FROM Gameweeks WHERE GameweekNumber = 25)),
(UUID(), NULL, NULL, '2023-02-17', (SELECT TeamId FROM Teams WHERE TeamName = 'Manchester City'), (SELECT TeamId FROM Teams WHERE TeamName = 'Chelsea'), (SELECT GameweekId FROM Gameweeks WHERE GameweekNumber = 25)),
(UUID(), NULL, NULL, '2023-02-17', (SELECT TeamId FROM Teams WHERE TeamName = 'Newcastle'), (SELECT TeamId FROM Teams WHERE TeamName = 'Bournemouth'), (SELECT GameweekId FROM Gameweeks WHERE GameweekNumber = 25)),
(UUID(), NULL, NULL, '2023-02-17', (SELECT TeamId FROM Teams WHERE TeamName = 'Nottingham'), (SELECT TeamId FROM Teams WHERE TeamName = 'West Ham'), (SELECT GameweekId FROM Gameweeks WHERE GameweekNumber = 25)),
(UUID(), NULL, NULL, '2023-02-17', (SELECT TeamId FROM Teams WHERE TeamName = 'Sheffield Utd'), (SELECT TeamId FROM Teams WHERE TeamName = 'Brighton'), (SELECT GameweekId FROM Gameweeks WHERE GameweekNumber = 25)),
(UUID(), NULL, NULL, '2023-02-17', (SELECT TeamId FROM Teams WHERE TeamName = 'Tottenham'), (SELECT TeamId FROM Teams WHERE TeamName = 'Wolves'), (SELECT GameweekId FROM Gameweeks WHERE GameweekNumber = 25));

INSERT INTO Matches (MatchId, HomeTeamGoals, AwayTeamGoals, MatchDate, HomeTeamId, AwayTeamId, GameweekId)
VALUES
(UUID(), NULL, NULL, '2023-02-24', (SELECT TeamId FROM Teams WHERE TeamName = 'Arsenal'), (SELECT TeamId FROM Teams WHERE TeamName = 'Newcastle'), (SELECT GameweekId FROM Gameweeks WHERE GameweekNumber = 26)),
(UUID(), NULL, NULL, '2023-02-24', (SELECT TeamId FROM Teams WHERE TeamName = 'Aston Villa'), (SELECT TeamId FROM Teams WHERE TeamName = 'Nottingham'), (SELECT GameweekId FROM Gameweeks WHERE GameweekNumber = 26)),
(UUID(), NULL, NULL, '2023-02-24', (SELECT TeamId FROM Teams WHERE TeamName = 'Bournemouth'), (SELECT TeamId FROM Teams WHERE TeamName = 'Manchester City'), (SELECT GameweekId FROM Gameweeks WHERE GameweekNumber = 26)),
(UUID(), NULL, NULL, '2023-02-24', (SELECT TeamId FROM Teams WHERE TeamName = 'Brighton'), (SELECT TeamId FROM Teams WHERE TeamName = 'Everton'), (SELECT GameweekId FROM Gameweeks WHERE GameweekNumber = 26)),
(UUID(), NULL, NULL, '2023-02-24', (SELECT TeamId FROM Teams WHERE TeamName = 'Chelsea'), (SELECT TeamId FROM Teams WHERE TeamName = 'Tottenham'), (SELECT GameweekId FROM Gameweeks WHERE GameweekNumber = 26)),
(UUID(), NULL, NULL, '2023-02-24', (SELECT TeamId FROM Teams WHERE TeamName = 'Crystal Palace'), (SELECT TeamId FROM Teams WHERE TeamName = 'Burnley'), (SELECT GameweekId FROM Gameweeks WHERE GameweekNumber = 26)),
(UUID(), NULL, NULL, '2023-02-24', (SELECT TeamId FROM Teams WHERE TeamName = 'Liverpool'), (SELECT TeamId FROM Teams WHERE TeamName = 'Luton'), (SELECT GameweekId FROM Gameweeks WHERE GameweekNumber = 26)),
(UUID(), NULL, NULL, '2023-02-24', (SELECT TeamId FROM Teams WHERE TeamName = 'Manchester Utd'), (SELECT TeamId FROM Teams WHERE TeamName = 'Fulham'), (SELECT GameweekId FROM Gameweeks WHERE GameweekNumber = 26)),
(UUID(), NULL, NULL, '2023-02-24', (SELECT TeamId FROM Teams WHERE TeamName = 'West Ham'), (SELECT TeamId FROM Teams WHERE TeamName = 'Brentford'), (SELECT GameweekId FROM Gameweeks WHERE GameweekNumber = 26)),
(UUID(), NULL, NULL, '2023-02-24', (SELECT TeamId FROM Teams WHERE TeamName = 'Wolves'), (SELECT TeamId FROM Teams WHERE TeamName = 'Sheffield Utd'), (SELECT GameweekId FROM Gameweeks WHERE GameweekNumber = 26));

INSERT INTO Matches (MatchId, HomeTeamGoals, AwayTeamGoals, MatchDate, HomeTeamId, AwayTeamId, GameweekId)
VALUES
(UUID(), NULL, NULL, '2023-03-02', (SELECT TeamId FROM Teams WHERE TeamName = 'Brentford'), (SELECT TeamId FROM Teams WHERE TeamName = 'Chelsea'), (SELECT GameweekId FROM Gameweeks WHERE GameweekNumber = 27)),
(UUID(), NULL, NULL, '2023-03-02', (SELECT TeamId FROM Teams WHERE TeamName = 'Burnley'), (SELECT TeamId FROM Teams WHERE TeamName = 'Bournemouth'), (SELECT GameweekId FROM Gameweeks WHERE GameweekNumber = 27)),
(UUID(), NULL, NULL, '2023-03-02', (SELECT TeamId FROM Teams WHERE TeamName = 'Everton'), (SELECT TeamId FROM Teams WHERE TeamName = 'West Ham'), (SELECT GameweekId FROM Gameweeks WHERE GameweekNumber = 27)),
(UUID(), NULL, NULL, '2023-03-02', (SELECT TeamId FROM Teams WHERE TeamName = 'Fulham'), (SELECT TeamId FROM Teams WHERE TeamName = 'Brighton'), (SELECT GameweekId FROM Gameweeks WHERE GameweekNumber = 27)),
(UUID(), NULL, NULL, '2023-03-02', (SELECT TeamId FROM Teams WHERE TeamName = 'Luton'), (SELECT TeamId FROM Teams WHERE TeamName = 'Aston Villa'), (SELECT GameweekId FROM Gameweeks WHERE GameweekNumber = 27)),
(UUID(), NULL, NULL, '2023-03-02', (SELECT TeamId FROM Teams WHERE TeamName = 'Manchester City'), (SELECT TeamId FROM Teams WHERE TeamName = 'Manchester Utd'), (SELECT GameweekId FROM Gameweeks WHERE GameweekNumber = 27)),
(UUID(), NULL, NULL, '2023-03-02', (SELECT TeamId FROM Teams WHERE TeamName = 'Newcastle'), (SELECT TeamId FROM Teams WHERE TeamName = 'Wolves'), (SELECT GameweekId FROM Gameweeks WHERE GameweekNumber = 27)),
(UUID(), NULL, NULL, '2023-03-02', (SELECT TeamId FROM Teams WHERE TeamName = 'Nottingham'), (SELECT TeamId FROM Teams WHERE TeamName = 'Liverpool'), (SELECT GameweekId FROM Gameweeks WHERE GameweekNumber = 27)),
(UUID(), NULL, NULL, '2023-03-02', (SELECT TeamId FROM Teams WHERE TeamName = 'Sheffield Utd'), (SELECT TeamId FROM Teams WHERE TeamName = 'Arsenal'), (SELECT GameweekId FROM Gameweeks WHERE GameweekNumber = 27)),
(UUID(), NULL, NULL, '2023-03-02', (SELECT TeamId FROM Teams WHERE TeamName = 'Tottenham'), (SELECT TeamId FROM Teams WHERE TeamName = 'Crystal Palace'), (SELECT GameweekId FROM Gameweeks WHERE GameweekNumber = 27));

INSERT INTO Matches (MatchId, HomeTeamGoals, AwayTeamGoals, MatchDate, HomeTeamId, AwayTeamId, GameweekId)
VALUES
(UUID(), NULL, NULL, '2023-03-09', (SELECT TeamId FROM Teams WHERE TeamName = 'Arsenal'), (SELECT TeamId FROM Teams WHERE TeamName = 'Brentford'), (SELECT GameweekId FROM Gameweeks WHERE GameweekNumber = 28)),
(UUID(), NULL, NULL, '2023-03-09', (SELECT TeamId FROM Teams WHERE TeamName = 'Aston Villa'), (SELECT TeamId FROM Teams WHERE TeamName = 'Tottenham'), (SELECT GameweekId FROM Gameweeks WHERE GameweekNumber = 28)),
(UUID(), NULL, NULL, '2023-03-09', (SELECT TeamId FROM Teams WHERE TeamName = 'Bournemouth'), (SELECT TeamId FROM Teams WHERE TeamName = 'Sheffield Utd'), (SELECT GameweekId FROM Gameweeks WHERE GameweekNumber = 28)),
(UUID(), NULL, NULL, '2023-03-09', (SELECT TeamId FROM Teams WHERE TeamName = 'Brighton'), (SELECT TeamId FROM Teams WHERE TeamName = 'Nottingham'), (SELECT GameweekId FROM Gameweeks WHERE GameweekNumber = 28)),
(UUID(), NULL, NULL, '2023-03-09', (SELECT TeamId FROM Teams WHERE TeamName = 'Chelsea'), (SELECT TeamId FROM Teams WHERE TeamName = 'Newcastle'), (SELECT GameweekId FROM Gameweeks WHERE GameweekNumber = 28)),
(UUID(), NULL, NULL, '2023-03-09', (SELECT TeamId FROM Teams WHERE TeamName = 'Crystal Palace'), (SELECT TeamId FROM Teams WHERE TeamName = 'Luton'), (SELECT GameweekId FROM Gameweeks WHERE GameweekNumber = 28)),
(UUID(), NULL, NULL, '2023-03-09', (SELECT TeamId FROM Teams WHERE TeamName = 'Liverpool'), (SELECT TeamId FROM Teams WHERE TeamName = 'Manchester City'), (SELECT GameweekId FROM Gameweeks WHERE GameweekNumber = 28)),
(UUID(), NULL, NULL, '2023-03-09', (SELECT TeamId FROM Teams WHERE TeamName = 'Manchester Utd'), (SELECT TeamId FROM Teams WHERE TeamName = 'Everton'), (SELECT GameweekId FROM Gameweeks WHERE GameweekNumber = 28)),
(UUID(), NULL, NULL, '2023-03-09', (SELECT TeamId FROM Teams WHERE TeamName = 'West Ham'), (SELECT TeamId FROM Teams WHERE TeamName = 'Burnley'), (SELECT GameweekId FROM Gameweeks WHERE GameweekNumber = 28)),
(UUID(), NULL, NULL, '2023-03-09', (SELECT TeamId FROM Teams WHERE TeamName = 'Wolves'), (SELECT TeamId FROM Teams WHERE TeamName = 'Fulham'), (SELECT GameweekId FROM Gameweeks WHERE GameweekNumber = 28));

INSERT INTO Matches (MatchId, HomeTeamGoals, AwayTeamGoals, MatchDate, HomeTeamId, AwayTeamId, GameweekId)
VALUES
(UUID(), NULL, NULL, '2023-03-16', (SELECT TeamId FROM Teams WHERE TeamName = 'Arsenal'), (SELECT TeamId FROM Teams WHERE TeamName = 'Chelsea'), (SELECT GameweekId FROM Gameweeks WHERE GameweekNumber = 29)),
(UUID(), NULL, NULL, '2023-03-16', (SELECT TeamId FROM Teams WHERE TeamName = 'Brighton'), (SELECT TeamId FROM Teams WHERE TeamName = 'Manchester City'), (SELECT GameweekId FROM Gameweeks WHERE GameweekNumber = 29)),
(UUID(), NULL, NULL, '2023-03-16', (SELECT TeamId FROM Teams WHERE TeamName = 'Burnley'), (SELECT TeamId FROM Teams WHERE TeamName = 'Brentford'), (SELECT GameweekId FROM Gameweeks WHERE GameweekNumber = 29)),
(UUID(), NULL, NULL, '2023-03-16', (SELECT TeamId FROM Teams WHERE TeamName = 'Crystal Palace'), (SELECT TeamId FROM Teams WHERE TeamName = 'Newcastle'), (SELECT GameweekId FROM Gameweeks WHERE GameweekNumber = 29)),
(UUID(), NULL, NULL, '2023-03-16', (SELECT TeamId FROM Teams WHERE TeamName = 'Everton'), (SELECT TeamId FROM Teams WHERE TeamName = 'Liverpool'), (SELECT GameweekId FROM Gameweeks WHERE GameweekNumber = 29)),
(UUID(), NULL, NULL, '2023-03-16', (SELECT TeamId FROM Teams WHERE TeamName = 'Fulham'), (SELECT TeamId FROM Teams WHERE TeamName = 'Tottenham'), (SELECT GameweekId FROM Gameweeks WHERE GameweekNumber = 29)),
(UUID(), NULL, NULL, '2023-03-16', (SELECT TeamId FROM Teams WHERE TeamName = 'Luton'), (SELECT TeamId FROM Teams WHERE TeamName = 'Nottingham'), (SELECT GameweekId FROM Gameweeks WHERE GameweekNumber = 29)),
(UUID(), NULL, NULL, '2023-03-16', (SELECT TeamId FROM Teams WHERE TeamName = 'Manchester Utd'), (SELECT TeamId FROM Teams WHERE TeamName = 'Sheffield Utd'), (SELECT GameweekId FROM Gameweeks WHERE GameweekNumber = 29)),
(UUID(), NULL, NULL, '2023-03-16', (SELECT TeamId FROM Teams WHERE TeamName = 'West Ham'), (SELECT TeamId FROM Teams WHERE TeamName = 'Aston Villa'), (SELECT GameweekId FROM Gameweeks WHERE GameweekNumber = 29)),
(UUID(), NULL, NULL, '2023-03-16', (SELECT TeamId FROM Teams WHERE TeamName = 'Wolves'), (SELECT TeamId FROM Teams WHERE TeamName = 'Bournemouth'), (SELECT GameweekId FROM Gameweeks WHERE GameweekNumber = 29));

INSERT INTO Matches (MatchId, HomeTeamGoals, AwayTeamGoals, MatchDate, HomeTeamId, AwayTeamId, GameweekId)
VALUES
(UUID(), NULL, NULL, '2023-03-30', (SELECT TeamId FROM Teams WHERE TeamName = 'Aston Villa'), (SELECT TeamId FROM Teams WHERE TeamName = 'Wolves'), (SELECT GameweekId FROM Gameweeks WHERE GameweekNumber = 30)),
(UUID(), NULL, NULL, '2023-03-30', (SELECT TeamId FROM Teams WHERE TeamName = 'Bournemouth'), (SELECT TeamId FROM Teams WHERE TeamName = 'Everton'), (SELECT GameweekId FROM Gameweeks WHERE GameweekNumber = 30)),
(UUID(), NULL, NULL, '2023-03-30', (SELECT TeamId FROM Teams WHERE TeamName = 'Brentford'), (SELECT TeamId FROM Teams WHERE TeamName = 'Manchester Utd'), (SELECT GameweekId FROM Gameweeks WHERE GameweekNumber = 30)),
(UUID(), NULL, NULL, '2023-03-30', (SELECT TeamId FROM Teams WHERE TeamName = 'Chelsea'), (SELECT TeamId FROM Teams WHERE TeamName = 'Burnley'), (SELECT GameweekId FROM Gameweeks WHERE GameweekNumber = 30)),
(UUID(), NULL, NULL, '2023-03-30', (SELECT TeamId FROM Teams WHERE TeamName = 'Liverpool'), (SELECT TeamId FROM Teams WHERE TeamName = 'Brighton'), (SELECT GameweekId FROM Gameweeks WHERE GameweekNumber = 30)),
(UUID(), NULL, NULL, '2023-03-30', (SELECT TeamId FROM Teams WHERE TeamName = 'Manchester City'), (SELECT TeamId FROM Teams WHERE TeamName = 'Arsenal'), (SELECT GameweekId FROM Gameweeks WHERE GameweekNumber = 30)),
(UUID(), NULL, NULL, '2023-03-30', (SELECT TeamId FROM Teams WHERE TeamName = 'Newcastle'), (SELECT TeamId FROM Teams WHERE TeamName = 'West Ham'), (SELECT GameweekId FROM Gameweeks WHERE GameweekNumber = 30)),
(UUID(), NULL, NULL, '2023-03-30', (SELECT TeamId FROM Teams WHERE TeamName = 'Nottingham'), (SELECT TeamId FROM Teams WHERE TeamName = 'Crystal Palace'), (SELECT GameweekId FROM Gameweeks WHERE GameweekNumber = 30)),
(UUID(), NULL, NULL, '2023-03-30', (SELECT TeamId FROM Teams WHERE TeamName = 'Sheffield Utd'), (SELECT TeamId FROM Teams WHERE TeamName = 'Fulham'), (SELECT GameweekId FROM Gameweeks WHERE GameweekNumber = 30)),
(UUID(), NULL, NULL, '2023-03-30', (SELECT TeamId FROM Teams WHERE TeamName = 'Tottenham'), (SELECT TeamId FROM Teams WHERE TeamName = 'Luton'), (SELECT GameweekId FROM Gameweeks WHERE GameweekNumber = 30));

INSERT INTO Matches (MatchId, HomeTeamGoals, AwayTeamGoals, MatchDate, HomeTeamId, AwayTeamId, GameweekId)
VALUES
(UUID(), NULL, NULL, '2023-04-02', (SELECT TeamId FROM Teams WHERE TeamName = 'Arsenal'), (SELECT TeamId FROM Teams WHERE TeamName = 'Luton'), (SELECT GameweekId FROM Gameweeks WHERE GameweekNumber = 31)),
(UUID(), NULL, NULL, '2023-04-02', (SELECT TeamId FROM Teams WHERE TeamName = 'Bournemouth'), (SELECT TeamId FROM Teams WHERE TeamName = 'Crystal Palace'), (SELECT GameweekId FROM Gameweeks WHERE GameweekNumber = 31)),
(UUID(), NULL, NULL, '2023-04-02', (SELECT TeamId FROM Teams WHERE TeamName = 'Brentford'), (SELECT TeamId FROM Teams WHERE TeamName = 'Brighton'), (SELECT GameweekId FROM Gameweeks WHERE GameweekNumber = 31)),
(UUID(), NULL, NULL, '2023-04-02', (SELECT TeamId FROM Teams WHERE TeamName = 'Burnley'), (SELECT TeamId FROM Teams WHERE TeamName = 'Wolves'), (SELECT GameweekId FROM Gameweeks WHERE GameweekNumber = 31)),
(UUID(), NULL, NULL, '2023-04-02', (SELECT TeamId FROM Teams WHERE TeamName = 'Nottingham'), (SELECT TeamId FROM Teams WHERE TeamName = 'Fulham'), (SELECT GameweekId FROM Gameweeks WHERE GameweekNumber = 31)),
(UUID(), NULL, NULL, '2023-04-02', (SELECT TeamId FROM Teams WHERE TeamName = 'West Ham'), (SELECT TeamId FROM Teams WHERE TeamName = 'Tottenham'), (SELECT GameweekId FROM Gameweeks WHERE GameweekNumber = 31)),
(UUID(), NULL, NULL, '2023-04-03', (SELECT TeamId FROM Teams WHERE TeamName = 'Chelsea'), (SELECT TeamId FROM Teams WHERE TeamName = 'Manchester Utd'), (SELECT GameweekId FROM Gameweeks WHERE GameweekNumber = 31)),
(UUID(), NULL, NULL, '2023-04-03', (SELECT TeamId FROM Teams WHERE TeamName = 'Newcastle'), (SELECT TeamId FROM Teams WHERE TeamName = 'Everton'), (SELECT GameweekId FROM Gameweeks WHERE GameweekNumber = 31)),
(UUID(), NULL, NULL, '2023-04-03', (SELECT TeamId FROM Teams WHERE TeamName = 'Liverpool'), (SELECT TeamId FROM Teams WHERE TeamName = 'Sheffield Utd'), (SELECT GameweekId FROM Gameweeks WHERE GameweekNumber = 31)),
(UUID(), NULL, NULL, '2023-04-03', (SELECT TeamId FROM Teams WHERE TeamName = 'Manchester City'), (SELECT TeamId FROM Teams WHERE TeamName = 'Aston Villa'), (SELECT GameweekId FROM Gameweeks WHERE GameweekNumber = 31));

INSERT INTO Matches (MatchId, HomeTeamGoals, AwayTeamGoals, MatchDate, HomeTeamId, AwayTeamId, GameweekId)
VALUES
(UUID(), NULL, NULL, '2023-04-06', (SELECT TeamId FROM Teams WHERE TeamName = 'Aston Villa'), (SELECT TeamId FROM Teams WHERE TeamName = 'Brentford'), (SELECT GameweekId FROM Gameweeks WHERE GameweekNumber = 32)),
(UUID(), NULL, NULL, '2023-04-06', (SELECT TeamId FROM Teams WHERE TeamName = 'Brighton'), (SELECT TeamId FROM Teams WHERE TeamName = 'Arsenal'), (SELECT GameweekId FROM Gameweeks WHERE GameweekNumber = 32)),
(UUID(), NULL, NULL, '2023-04-06', (SELECT TeamId FROM Teams WHERE TeamName = 'Crystal Palace'), (SELECT TeamId FROM Teams WHERE TeamName = 'Manchester City'), (SELECT GameweekId FROM Gameweeks WHERE GameweekNumber = 32)),
(UUID(), NULL, NULL, '2023-04-06', (SELECT TeamId FROM Teams WHERE TeamName = 'Everton'), (SELECT TeamId FROM Teams WHERE TeamName = 'Burnley'), (SELECT GameweekId FROM Gameweeks WHERE GameweekNumber = 32)),
(UUID(), NULL, NULL, '2023-04-06', (SELECT TeamId FROM Teams WHERE TeamName = 'Fulham'), (SELECT TeamId FROM Teams WHERE TeamName = 'Newcastle'), (SELECT GameweekId FROM Gameweeks WHERE GameweekNumber = 32)),
(UUID(), NULL, NULL, '2023-04-06', (SELECT TeamId FROM Teams WHERE TeamName = 'Luton'), (SELECT TeamId FROM Teams WHERE TeamName = 'Bournemouth'), (SELECT GameweekId FROM Gameweeks WHERE GameweekNumber = 32)),
(UUID(), NULL, NULL, '2023-04-06', (SELECT TeamId FROM Teams WHERE TeamName = 'Manchester Utd'), (SELECT TeamId FROM Teams WHERE TeamName = 'Liverpool'), (SELECT GameweekId FROM Gameweeks WHERE GameweekNumber = 32)),
(UUID(), NULL, NULL, '2023-04-06', (SELECT TeamId FROM Teams WHERE TeamName = 'Sheffield Utd'), (SELECT TeamId FROM Teams WHERE TeamName = 'Chelsea'), (SELECT GameweekId FROM Gameweeks WHERE GameweekNumber = 32)),
(UUID(), NULL, NULL, '2023-04-06', (SELECT TeamId FROM Teams WHERE TeamName = 'Tottenham'), (SELECT TeamId FROM Teams WHERE TeamName = 'Nottingham'), (SELECT GameweekId FROM Gameweeks WHERE GameweekNumber = 32)),
(UUID(), NULL, NULL, '2023-04-06', (SELECT TeamId FROM Teams WHERE TeamName = 'Wolves'), (SELECT TeamId FROM Teams WHERE TeamName = 'West Ham'), (SELECT GameweekId FROM Gameweeks WHERE GameweekNumber = 32));

INSERT INTO Matches (MatchId, HomeTeamGoals, AwayTeamGoals, MatchDate, HomeTeamId, AwayTeamId, GameweekId)
VALUES
(UUID(), NULL, NULL, '2023-04-13', (SELECT TeamId FROM Teams WHERE TeamName = 'Arsenal'), (SELECT TeamId FROM Teams WHERE TeamName = 'Aston Villa'), (SELECT GameweekId FROM Gameweeks WHERE GameweekNumber = 33)),
(UUID(), NULL, NULL, '2023-04-13', (SELECT TeamId FROM Teams WHERE TeamName = 'Bournemouth'), (SELECT TeamId FROM Teams WHERE TeamName = 'Manchester Utd'), (SELECT GameweekId FROM Gameweeks WHERE GameweekNumber = 33)),
(UUID(), NULL, NULL, '2023-04-13', (SELECT TeamId FROM Teams WHERE TeamName = 'Brentford'), (SELECT TeamId FROM Teams WHERE TeamName = 'Sheffield Utd'), (SELECT GameweekId FROM Gameweeks WHERE GameweekNumber = 33)),
(UUID(), NULL, NULL, '2023-04-13', (SELECT TeamId FROM Teams WHERE TeamName = 'Burnley'), (SELECT TeamId FROM Teams WHERE TeamName = 'Brighton'), (SELECT GameweekId FROM Gameweeks WHERE GameweekNumber = 33)),
(UUID(), NULL, NULL, '2023-04-13', (SELECT TeamId FROM Teams WHERE TeamName = 'Chelsea'), (SELECT TeamId FROM Teams WHERE TeamName = 'Everton'), (SELECT GameweekId FROM Gameweeks WHERE GameweekNumber = 33)),
(UUID(), NULL, NULL, '2023-04-13', (SELECT TeamId FROM Teams WHERE TeamName = 'Liverpool'), (SELECT TeamId FROM Teams WHERE TeamName = 'Crystal Palace'), (SELECT GameweekId FROM Gameweeks WHERE GameweekNumber = 33)),
(UUID(), NULL, NULL, '2023-04-13', (SELECT TeamId FROM Teams WHERE TeamName = 'Manchester City'), (SELECT TeamId FROM Teams WHERE TeamName = 'Luton'), (SELECT GameweekId FROM Gameweeks WHERE GameweekNumber = 33)),
(UUID(), NULL, NULL, '2023-04-13', (SELECT TeamId FROM Teams WHERE TeamName = 'Newcastle'), (SELECT TeamId FROM Teams WHERE TeamName = 'Tottenham'), (SELECT GameweekId FROM Gameweeks WHERE GameweekNumber = 33)),
(UUID(), NULL, NULL, '2023-04-13', (SELECT TeamId FROM Teams WHERE TeamName = 'Nottingham'), (SELECT TeamId FROM Teams WHERE TeamName = 'Wolves'), (SELECT GameweekId FROM Gameweeks WHERE GameweekNumber = 33)),
(UUID(), NULL, NULL, '2023-04-13', (SELECT TeamId FROM Teams WHERE TeamName = 'West Ham'), (SELECT TeamId FROM Teams WHERE TeamName = 'Fulham'), (SELECT GameweekId FROM Gameweeks WHERE GameweekNumber = 33));

INSERT INTO Matches (MatchId, HomeTeamGoals, AwayTeamGoals, MatchDate, HomeTeamId, AwayTeamId, GameweekId)
VALUES
(UUID(), NULL, NULL, '2023-04-20', (SELECT TeamId FROM Teams WHERE TeamName = 'Aston Villa'), (SELECT TeamId FROM Teams WHERE TeamName = 'Bournemouth'), (SELECT GameweekId FROM Gameweeks WHERE GameweekNumber = 34)),
(UUID(), NULL, NULL, '2023-04-20', (SELECT TeamId FROM Teams WHERE TeamName = 'Brighton'), (SELECT TeamId FROM Teams WHERE TeamName = 'Chelsea'), (SELECT GameweekId FROM Gameweeks WHERE GameweekNumber = 34)),
(UUID(), NULL, NULL, '2023-04-20', (SELECT TeamId FROM Teams WHERE TeamName = 'Crystal Palace'), (SELECT TeamId FROM Teams WHERE TeamName = 'West Ham'), (SELECT GameweekId FROM Gameweeks WHERE GameweekNumber = 34)),
(UUID(), NULL, NULL, '2023-04-20', (SELECT TeamId FROM Teams WHERE TeamName = 'Everton'), (SELECT TeamId FROM Teams WHERE TeamName = 'Nottingham'), (SELECT GameweekId FROM Gameweeks WHERE GameweekNumber = 34)),
(UUID(), NULL, NULL, '2023-04-20', (SELECT TeamId FROM Teams WHERE TeamName = 'Fulham'), (SELECT TeamId FROM Teams WHERE TeamName = 'Liverpool'), (SELECT GameweekId FROM Gameweeks WHERE GameweekNumber = 34)),
(UUID(), NULL, NULL, '2023-04-20', (SELECT TeamId FROM Teams WHERE TeamName = 'Luton'), (SELECT TeamId FROM Teams WHERE TeamName = 'Brentford'), (SELECT GameweekId FROM Gameweeks WHERE GameweekNumber = 34)),
(UUID(), NULL, NULL, '2023-04-20', (SELECT TeamId FROM Teams WHERE TeamName = 'Manchester Utd'), (SELECT TeamId FROM Teams WHERE TeamName = 'Newcastle'), (SELECT GameweekId FROM Gameweeks WHERE GameweekNumber = 34)),
(UUID(), NULL, NULL, '2023-04-20', (SELECT TeamId FROM Teams WHERE TeamName = 'Sheffield Utd'), (SELECT TeamId FROM Teams WHERE TeamName = 'Burnley'), (SELECT GameweekId FROM Gameweeks WHERE GameweekNumber = 34)),
(UUID(), NULL, NULL, '2023-04-20', (SELECT TeamId FROM Teams WHERE TeamName = 'Tottenham'), (SELECT TeamId FROM Teams WHERE TeamName = 'Manchester City'), (SELECT GameweekId FROM Gameweeks WHERE GameweekNumber = 34)),
(UUID(), NULL, NULL, '2023-04-20', (SELECT TeamId FROM Teams WHERE TeamName = 'Wolves'), (SELECT TeamId FROM Teams WHERE TeamName = 'Arsenal'), (SELECT GameweekId FROM Gameweeks WHERE GameweekNumber = 34));

INSERT INTO Matches (MatchId, HomeTeamGoals, AwayTeamGoals, MatchDate, HomeTeamId, AwayTeamId, GameweekId)
VALUES
(UUID(), NULL, NULL, '2023-04-27', (SELECT TeamId FROM Teams WHERE TeamName = 'Aston Villa'), (SELECT TeamId FROM Teams WHERE TeamName = 'Chelsea'), (SELECT GameweekId FROM Gameweeks WHERE GameweekNumber = 35)),
(UUID(), NULL, NULL, '2023-04-27', (SELECT TeamId FROM Teams WHERE TeamName = 'Bournemouth'), (SELECT TeamId FROM Teams WHERE TeamName = 'Brighton'), (SELECT GameweekId FROM Gameweeks WHERE GameweekNumber = 35)),
(UUID(), NULL, NULL, '2023-04-27', (SELECT TeamId FROM Teams WHERE TeamName = 'Everton'), (SELECT TeamId FROM Teams WHERE TeamName = 'Brentford'), (SELECT GameweekId FROM Gameweeks WHERE GameweekNumber = 35)),
(UUID(), NULL, NULL, '2023-04-27', (SELECT TeamId FROM Teams WHERE TeamName = 'Fulham'), (SELECT TeamId FROM Teams WHERE TeamName = 'Crystal Palace'), (SELECT GameweekId FROM Gameweeks WHERE GameweekNumber = 35)),
(UUID(), NULL, NULL, '2023-04-27', (SELECT TeamId FROM Teams WHERE TeamName = 'Manchester Utd'), (SELECT TeamId FROM Teams WHERE TeamName = 'Burnley'), (SELECT GameweekId FROM Gameweeks WHERE GameweekNumber = 35)),
(UUID(), NULL, NULL, '2023-04-27', (SELECT TeamId FROM Teams WHERE TeamName = 'Newcastle'), (SELECT TeamId FROM Teams WHERE TeamName = 'Sheffield Utd'), (SELECT GameweekId FROM Gameweeks WHERE GameweekNumber = 35)),
(UUID(), NULL, NULL, '2023-04-27', (SELECT TeamId FROM Teams WHERE TeamName = 'Nottingham'), (SELECT TeamId FROM Teams WHERE TeamName = 'Manchester City'), (SELECT GameweekId FROM Gameweeks WHERE GameweekNumber = 35)),
(UUID(), NULL, NULL, '2023-04-27', (SELECT TeamId FROM Teams WHERE TeamName = 'Tottenham'), (SELECT TeamId FROM Teams WHERE TeamName = 'Arsenal'), (SELECT GameweekId FROM Gameweeks WHERE GameweekNumber = 35)),
(UUID(), NULL, NULL, '2023-04-27', (SELECT TeamId FROM Teams WHERE TeamName = 'West Ham'), (SELECT TeamId FROM Teams WHERE TeamName = 'Liverpool'), (SELECT GameweekId FROM Gameweeks WHERE GameweekNumber = 35)),
(UUID(), NULL, NULL, '2023-04-27', (SELECT TeamId FROM Teams WHERE TeamName = 'Wolves'), (SELECT TeamId FROM Teams WHERE TeamName = 'Luton'), (SELECT GameweekId FROM Gameweeks WHERE GameweekNumber = 35));

INSERT INTO Matches (MatchId, HomeTeamGoals, AwayTeamGoals, MatchDate, HomeTeamId, AwayTeamId, GameweekId)
VALUES
(UUID(), NULL, NULL, '2023-05-04', (SELECT TeamId FROM Teams WHERE TeamName = 'Arsenal'), (SELECT TeamId FROM Teams WHERE TeamName = 'Bournemouth'), (SELECT GameweekId FROM Gameweeks WHERE GameweekNumber = 36)),
(UUID(), NULL, NULL, '2023-05-04', (SELECT TeamId FROM Teams WHERE TeamName = 'Brentford'), (SELECT TeamId FROM Teams WHERE TeamName = 'Fulham'), (SELECT GameweekId FROM Gameweeks WHERE GameweekNumber = 36)),
(UUID(), NULL, NULL, '2023-05-04', (SELECT TeamId FROM Teams WHERE TeamName = 'Brighton'), (SELECT TeamId FROM Teams WHERE TeamName = 'Aston Villa'), (SELECT GameweekId FROM Gameweeks WHERE GameweekNumber = 36)),
(UUID(), NULL, NULL, '2023-05-04', (SELECT TeamId FROM Teams WHERE TeamName = 'Burnley'), (SELECT TeamId FROM Teams WHERE TeamName = 'Newcastle'), (SELECT GameweekId FROM Gameweeks WHERE GameweekNumber = 36)),
(UUID(), NULL, NULL, '2023-05-04', (SELECT TeamId FROM Teams WHERE TeamName = 'Chelsea'), (SELECT TeamId FROM Teams WHERE TeamName = 'West Ham'), (SELECT GameweekId FROM Gameweeks WHERE GameweekNumber = 36)),
(UUID(), NULL, NULL, '2023-05-04', (SELECT TeamId FROM Teams WHERE TeamName = 'Crystal Palace'), (SELECT TeamId FROM Teams WHERE TeamName = 'Manchester Utd'), (SELECT GameweekId FROM Gameweeks WHERE GameweekNumber = 36)),
(UUID(), NULL, NULL, '2023-05-04', (SELECT TeamId FROM Teams WHERE TeamName = 'Liverpool'), (SELECT TeamId FROM Teams WHERE TeamName = 'Tottenham'), (SELECT GameweekId FROM Gameweeks WHERE GameweekNumber = 36)),
(UUID(), NULL, NULL, '2023-05-04', (SELECT TeamId FROM Teams WHERE TeamName = 'Luton'), (SELECT TeamId FROM Teams WHERE TeamName = 'Everton'), (SELECT GameweekId FROM Gameweeks WHERE GameweekNumber = 36)),
(UUID(), NULL, NULL, '2023-05-04', (SELECT TeamId FROM Teams WHERE TeamName = 'Manchester City'), (SELECT TeamId FROM Teams WHERE TeamName = 'Wolves'), (SELECT GameweekId FROM Gameweeks WHERE GameweekNumber = 36)),
(UUID(), NULL, NULL, '2023-05-04', (SELECT TeamId FROM Teams WHERE TeamName = 'Sheffield Utd'), (SELECT TeamId FROM Teams WHERE TeamName = 'Nottingham'), (SELECT GameweekId FROM Gameweeks WHERE GameweekNumber = 36));

INSERT INTO Matches (MatchId, HomeTeamGoals, AwayTeamGoals, MatchDate, HomeTeamId, AwayTeamId, GameweekId)
VALUES
(UUID(), NULL, NULL, '2023-05-11', (SELECT TeamId FROM Teams WHERE TeamName = 'Aston Villa'), (SELECT TeamId FROM Teams WHERE TeamName = 'Liverpool'), (SELECT GameweekId FROM Gameweeks WHERE GameweekNumber = 37)),
(UUID(), NULL, NULL, '2023-05-11', (SELECT TeamId FROM Teams WHERE TeamName = 'Bournemouth'), (SELECT TeamId FROM Teams WHERE TeamName = 'Brentford'), (SELECT GameweekId FROM Gameweeks WHERE GameweekNumber = 37)),
(UUID(), NULL, NULL, '2023-05-11', (SELECT TeamId FROM Teams WHERE TeamName = 'Everton'), (SELECT TeamId FROM Teams WHERE TeamName = 'Sheffield Utd'), (SELECT GameweekId FROM Gameweeks WHERE GameweekNumber = 37)),
(UUID(), NULL, NULL, '2023-05-11', (SELECT TeamId FROM Teams WHERE TeamName = 'Fulham'), (SELECT TeamId FROM Teams WHERE TeamName = 'Manchester City'), (SELECT GameweekId FROM Gameweeks WHERE GameweekNumber = 37)),
(UUID(), NULL, NULL, '2023-05-11', (SELECT TeamId FROM Teams WHERE TeamName = 'Manchester Utd'), (SELECT TeamId FROM Teams WHERE TeamName = 'Arsenal'), (SELECT GameweekId FROM Gameweeks WHERE GameweekNumber = 37)),
(UUID(), NULL, NULL, '2023-05-11', (SELECT TeamId FROM Teams WHERE TeamName = 'Newcastle'), (SELECT TeamId FROM Teams WHERE TeamName = 'Brighton'), (SELECT GameweekId FROM Gameweeks WHERE GameweekNumber = 37)),
(UUID(), NULL, NULL, '2023-05-11', (SELECT TeamId FROM Teams WHERE TeamName = 'Nottingham'), (SELECT TeamId FROM Teams WHERE TeamName = 'Chelsea'), (SELECT GameweekId FROM Gameweeks WHERE GameweekNumber = 37)),
(UUID(), NULL, NULL, '2023-05-11', (SELECT TeamId FROM Teams WHERE TeamName = 'Tottenham'), (SELECT TeamId FROM Teams WHERE TeamName = 'Burnley'), (SELECT GameweekId FROM Gameweeks WHERE GameweekNumber = 37)),
(UUID(), NULL, NULL, '2023-05-11', (SELECT TeamId FROM Teams WHERE TeamName = 'West Ham'), (SELECT TeamId FROM Teams WHERE TeamName = 'Luton'), (SELECT GameweekId FROM Gameweeks WHERE GameweekNumber = 37)),
(UUID(), NULL, NULL, '2023-05-11', (SELECT TeamId FROM Teams WHERE TeamName = 'Wolves'), (SELECT TeamId FROM Teams WHERE TeamName = 'Crystal Palace'), (SELECT GameweekId FROM Gameweeks WHERE GameweekNumber = 37));

INSERT INTO Matches (MatchId, HomeTeamGoals, AwayTeamGoals, MatchDate, HomeTeamId, AwayTeamId, GameweekId)
VALUES
(UUID(), NULL, NULL, '2023-05-19', (SELECT TeamId FROM Teams WHERE TeamName = 'Arsenal'), (SELECT TeamId FROM Teams WHERE TeamName = 'Everton'), (SELECT GameweekId FROM Gameweeks WHERE GameweekNumber = 38)),
(UUID(), NULL, NULL, '2023-05-19', (SELECT TeamId FROM Teams WHERE TeamName = 'Brentford'), (SELECT TeamId FROM Teams WHERE TeamName = 'Newcastle'), (SELECT GameweekId FROM Gameweeks WHERE GameweekNumber = 38)),
(UUID(), NULL, NULL, '2023-05-19', (SELECT TeamId FROM Teams WHERE TeamName = 'Brighton'), (SELECT TeamId FROM Teams WHERE TeamName = 'Manchester Utd'), (SELECT GameweekId FROM Gameweeks WHERE GameweekNumber = 38)),
(UUID(), NULL, NULL, '2023-05-19', (SELECT TeamId FROM Teams WHERE TeamName = 'Burnley'), (SELECT TeamId FROM Teams WHERE TeamName = 'Nottingham'), (SELECT GameweekId FROM Gameweeks WHERE GameweekNumber = 38)),
(UUID(), NULL, NULL, '2023-05-19', (SELECT TeamId FROM Teams WHERE TeamName = 'Chelsea'), (SELECT TeamId FROM Teams WHERE TeamName = 'Bournemouth'), (SELECT GameweekId FROM Gameweeks WHERE GameweekNumber = 38)),
(UUID(), NULL, NULL, '2023-05-19', (SELECT TeamId FROM Teams WHERE TeamName = 'Crystal Palace'), (SELECT TeamId FROM Teams WHERE TeamName = 'Aston Villa'), (SELECT GameweekId FROM Gameweeks WHERE GameweekNumber = 38)),
(UUID(), NULL, NULL, '2023-05-19', (SELECT TeamId FROM Teams WHERE TeamName = 'Liverpool'), (SELECT TeamId FROM Teams WHERE TeamName = 'Wolves'), (SELECT GameweekId FROM Gameweeks WHERE GameweekNumber = 38)),
(UUID(), NULL, NULL, '2023-05-19', (SELECT TeamId FROM Teams WHERE TeamName = 'Luton'), (SELECT TeamId FROM Teams WHERE TeamName = 'Fulham'), (SELECT GameweekId FROM Gameweeks WHERE GameweekNumber = 38)),
(UUID(), NULL, NULL, '2023-05-19', (SELECT TeamId FROM Teams WHERE TeamName = 'Manchester City'), (SELECT TeamId FROM Teams WHERE TeamName = 'West Ham'), (SELECT GameweekId FROM Gameweeks WHERE GameweekNumber = 38)),
(UUID(), NULL, NULL, '2023-05-19', (SELECT TeamId FROM Teams WHERE TeamName = 'Sheffield Utd'), (SELECT TeamId FROM Teams WHERE TeamName = 'Tottenham'), (SELECT GameweekId FROM Gameweeks WHERE GameweekNumber = 38));
