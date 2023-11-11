INSERT INTO Teams (TeamId, TeamName)
VALUES
(UUID(), 'Arsenal'),
(UUID(), 'Aston Villa'),
(UUID(), 'Brighton & Hove Albion'),
(UUID(), 'Burnley'),
(UUID(), 'Chelsea'),
(UUID(), 'Crystal Palace'),
(UUID(), 'Everton'),
(UUID(), 'Fulham'),
(UUID(), 'Leeds United'),
(UUID(), 'Leicester City'),
(UUID(), 'Liverpool'),
(UUID(), 'Manchester City'),
(UUID(), 'Manchester United'),
(UUID(), 'Newcastle United'),
(UUID(), 'Sheffield United'),
(UUID(), 'Southampton'),
(UUID(), 'Tottenham Hotspur'),
(UUID(), 'West Bromwich Albion'),
(UUID(), 'Bournemouth'),
(UUID(), 'Luton Town'),
(UUID(), 'Nottingham Forest'),
(UUID(), 'West Ham United'),
(UUID(), 'Wolverhampton Wanderers');

INSERT INTO Seasons (SeasonId, StartYear, EndYear)
VALUES
    (UUID(), 2020,2021);

INSERT INTO Gameweeks (GameweekId, GameweekNumber, SeasonId)
VALUES
    (UUID(), 1, (SELECT SeasonId FROM Seasons WHERE StartYear = 2020 and EndYear = 2021)),
    (UUID(), 2, (SELECT SeasonId FROM Seasons WHERE StartYear = 2020 and EndYear = 2021)),
    (UUID(), 3, (SELECT SeasonId FROM Seasons WHERE StartYear = 2020 and EndYear = 2021)),
    (UUID(), 4, (SELECT SeasonId FROM Seasons WHERE StartYear = 2020 and EndYear = 2021)),
    (UUID(), 5, (SELECT SeasonId FROM Seasons WHERE StartYear = 2020 and EndYear = 2021)),
    (UUID(), 6, (SELECT SeasonId FROM Seasons WHERE StartYear = 2020 and EndYear = 2021)),
    (UUID(), 7, (SELECT SeasonId FROM Seasons WHERE StartYear = 2020 and EndYear = 2021)),
    (UUID(), 8, (SELECT SeasonId FROM Seasons WHERE StartYear = 2020 and EndYear = 2021)),
    (UUID(), 9, (SELECT SeasonId FROM Seasons WHERE StartYear = 2020 and EndYear = 2021)),
    (UUID(), 10, (SELECT SeasonId FROM Seasons WHERE StartYear = 2020 and EndYear = 2021));


-- Inserting Matches for Gameweek 1
INSERT INTO Matches (MatchId, HomeTeamGoals, AwayTeamGoals, MatchDate, HomeTeamId, AwayTeamId, GameweekId)
VALUES
(UUID(), 2, 2, '2020-09-12', (SELECT TeamId FROM Teams WHERE TeamName = 'Liverpool'), (SELECT TeamId FROM Teams WHERE TeamName = 'Leeds United'), (SELECT GameweekId FROM Gameweeks WHERE GameweekNumber = 1)),
(UUID(), 1, 3, '2020-09-12', (SELECT TeamId FROM Teams WHERE TeamName = 'West Ham United'), (SELECT TeamId FROM Teams WHERE TeamName = 'Newcastle United'), (SELECT GameweekId FROM Gameweeks WHERE GameweekNumber = 1)),
(UUID(), 0, 2, '2020-09-12', (SELECT TeamId FROM Teams WHERE TeamName = 'West Bromwich Albion'), (SELECT TeamId FROM Teams WHERE TeamName = 'Leicester City'), (SELECT GameweekId FROM Gameweeks WHERE GameweekNumber = 1)),
(UUID(), 3, 1, '2020-09-13', (SELECT TeamId FROM Teams WHERE TeamName = 'Tottenham Hotspur'), (SELECT TeamId FROM Teams WHERE TeamName = 'Everton'), (SELECT GameweekId FROM Gameweeks WHERE GameweekNumber = 1)),
(UUID(), 2, 0, '2020-09-13', (SELECT TeamId FROM Teams WHERE TeamName = 'Sheffield United'), (SELECT TeamId FROM Teams WHERE TeamName = 'Wolverhampton Wanderers'), (SELECT GameweekId FROM Gameweeks WHERE GameweekNumber = 1)),
(UUID(), 1, 1, '2020-09-13', (SELECT TeamId FROM Teams WHERE TeamName = 'Brighton & Hove Albion'), (SELECT TeamId FROM Teams WHERE TeamName = 'Chelsea'), (SELECT GameweekId FROM Gameweeks WHERE GameweekNumber = 1)),
(UUID(), 3, 0, '2020-09-14', (SELECT TeamId FROM Teams WHERE TeamName = 'Manchester United'), (SELECT TeamId FROM Teams WHERE TeamName = 'Southampton'), (SELECT GameweekId FROM Gameweeks WHERE GameweekNumber = 1)),
(UUID(), 4, 1, '2020-09-14', (SELECT TeamId FROM Teams WHERE TeamName = 'Manchester City'), (SELECT TeamId FROM Teams WHERE TeamName = 'Aston Villa'), (SELECT GameweekId FROM Gameweeks WHERE GameweekNumber = 1)),
(UUID(), 2, 0, '2020-09-15', (SELECT TeamId FROM Teams WHERE TeamName = 'Arsenal'), (SELECT TeamId FROM Teams WHERE TeamName = 'Burnley'), (SELECT GameweekId FROM Gameweeks WHERE GameweekNumber = 1)),
(UUID(), 1, 2, '2020-09-15', (SELECT TeamId FROM Teams WHERE TeamName = 'Fulham'), (SELECT TeamId FROM Teams WHERE TeamName = 'Crystal Palace'), (SELECT GameweekId FROM Gameweeks WHERE GameweekNumber = 1));

-- Inserting Matches for Gameweek 2
INSERT INTO Matches (MatchId, HomeTeamGoals, AwayTeamGoals, MatchDate, HomeTeamId, AwayTeamId, GameweekId)
VALUES
(UUID(), 2, 0, '2020-09-19', (SELECT TeamId FROM Teams WHERE TeamName = 'Leeds United'), (SELECT TeamId FROM Teams WHERE TeamName = 'Fulham'), (SELECT GameweekId FROM Gameweeks WHERE GameweekNumber = 2)),
(UUID(), 1, 3, '2020-09-19', (SELECT TeamId FROM Teams WHERE TeamName = 'Manchester United'), (SELECT TeamId FROM Teams WHERE TeamName = 'Crystal Palace'), (SELECT GameweekId FROM Gameweeks WHERE GameweekNumber = 2)),
(UUID(), 1, 1, '2020-09-20', (SELECT TeamId FROM Teams WHERE TeamName = 'Everton'), (SELECT TeamId FROM Teams WHERE TeamName = 'West Bromwich Albion'), (SELECT GameweekId FROM Gameweeks WHERE GameweekNumber = 2)),
(UUID(), 0, 2, '2020-09-20', (SELECT TeamId FROM Teams WHERE TeamName = 'Sheffield United'), (SELECT TeamId FROM Teams WHERE TeamName = 'Wolverhampton Wanderers'), (SELECT GameweekId FROM Gameweeks WHERE GameweekNumber = 2)),
(UUID(), 1, 1, '2020-09-20', (SELECT TeamId FROM Teams WHERE TeamName = 'Brighton & Hove Albion'), (SELECT TeamId FROM Teams WHERE TeamName = 'Chelsea'), (SELECT GameweekId FROM Gameweeks WHERE GameweekNumber = 2)),
(UUID(), 2, 3, '2020-09-21', (SELECT TeamId FROM Teams WHERE TeamName = 'Aston Villa'), (SELECT TeamId FROM Teams WHERE TeamName = 'Tottenham Hotspur'), (SELECT GameweekId FROM Gameweeks WHERE GameweekNumber = 2)),
(UUID(), 1, 1, '2020-09-21', (SELECT TeamId FROM Teams WHERE TeamName = 'West Ham United'), (SELECT TeamId FROM Teams WHERE TeamName = 'Newcastle United'), (SELECT GameweekId FROM Gameweeks WHERE GameweekNumber = 2)),
(UUID(), 0, 4, '2020-09-21', (SELECT TeamId FROM Teams WHERE TeamName = 'Burnley'), (SELECT TeamId FROM Teams WHERE TeamName = 'Liverpool'), (SELECT GameweekId FROM Gameweeks WHERE GameweekNumber = 2)),
(UUID(), 1, 1, '2020-09-21', (SELECT TeamId FROM Teams WHERE TeamName = 'Leicester City'), (SELECT TeamId FROM Teams WHERE TeamName = 'Manchester City'), (SELECT GameweekId FROM Gameweeks WHERE GameweekNumber = 2)),
(UUID(), 1, 1, '2020-09-22', (SELECT TeamId FROM Teams WHERE TeamName = 'Southampton'), (SELECT TeamId FROM Teams WHERE TeamName = 'Arsenal'), (SELECT GameweekId FROM Gameweeks WHERE GameweekNumber = 2));

-- Inserting Matches for Gameweek 3
INSERT INTO Matches (MatchId, HomeTeamGoals, AwayTeamGoals, MatchDate, HomeTeamId, AwayTeamId, GameweekId)
VALUES
(UUID(), 2, 1, '2020-09-26', (SELECT TeamId FROM Teams WHERE TeamName = 'West Ham United'), (SELECT TeamId FROM Teams WHERE TeamName = 'Wolverhampton Wanderers'), (SELECT GameweekId FROM Gameweeks WHERE GameweekNumber = 3)),
(UUID(), 3, 0, '2020-09-26', (SELECT TeamId FROM Teams WHERE TeamName = 'Chelsea'), (SELECT TeamId FROM Teams WHERE TeamName = 'Crystal Palace'), (SELECT GameweekId FROM Gameweeks WHERE GameweekNumber = 3)),
(UUID(), 2, 1, '2020-09-27', (SELECT TeamId FROM Teams WHERE TeamName = 'Tottenham Hotspur'), (SELECT TeamId FROM Teams WHERE TeamName = 'Newcastle United'), (SELECT GameweekId FROM Gameweeks WHERE GameweekNumber = 3)),
(UUID(), 1, 2, '2020-09-27', (SELECT TeamId FROM Teams WHERE TeamName = 'Fulham'), (SELECT TeamId FROM Teams WHERE TeamName = 'Aston Villa'), (SELECT GameweekId FROM Gameweeks WHERE GameweekNumber = 3)),
(UUID(), 0, 0, '2020-09-27', (SELECT TeamId FROM Teams WHERE TeamName = 'Burnley'), (SELECT TeamId FROM Teams WHERE TeamName = 'Southampton'), (SELECT GameweekId FROM Gameweeks WHERE GameweekNumber = 3)),
(UUID(), 2, 0, '2020-09-28', (SELECT TeamId FROM Teams WHERE TeamName = 'Leeds United'), (SELECT TeamId FROM Teams WHERE TeamName = 'Manchester United'), (SELECT GameweekId FROM Gameweeks WHERE GameweekNumber = 3)),
(UUID(), 1, 1, '2020-09-28', (SELECT TeamId FROM Teams WHERE TeamName = 'West Bromwich Albion'), (SELECT TeamId FROM Teams WHERE TeamName = 'Everton'), (SELECT GameweekId FROM Gameweeks WHERE GameweekNumber = 3)),
(UUID(), 1, 2, '2020-09-28', (SELECT TeamId FROM Teams WHERE TeamName = 'Leicester City'), (SELECT TeamId FROM Teams WHERE TeamName = 'Arsenal'), (SELECT GameweekId FROM Gameweeks WHERE GameweekNumber = 3)),
(UUID(), 0, 3, '2020-09-29', (SELECT TeamId FROM Teams WHERE TeamName = 'Manchester City'), (SELECT TeamId FROM Teams WHERE TeamName = 'Brighton & Hove Albion'), (SELECT GameweekId FROM Gameweeks WHERE GameweekNumber = 3)),
(UUID(), 1, 2, '2020-09-29', (SELECT TeamId FROM Teams WHERE TeamName = 'Liverpool'), (SELECT TeamId FROM Teams WHERE TeamName = 'Sheffield United'), (SELECT GameweekId FROM Gameweeks WHERE GameweekNumber = 3));

-- Inserting Matches for Gameweek 4
INSERT INTO Matches (MatchId, HomeTeamGoals, AwayTeamGoals, MatchDate, HomeTeamId, AwayTeamId, GameweekId)
VALUES
(UUID(), 1, 1, '2020-10-03', (SELECT TeamId FROM Teams WHERE TeamName = 'Wolverhampton Wanderers'), (SELECT TeamId FROM Teams WHERE TeamName = 'Fulham'), (SELECT GameweekId FROM Gameweeks WHERE GameweekNumber = 4)),
(UUID(), 2, 0, '2020-10-03', (SELECT TeamId FROM Teams WHERE TeamName = 'Arsenal'), (SELECT TeamId FROM Teams WHERE TeamName = 'Sheffield United'), (SELECT GameweekId FROM Gameweeks WHERE GameweekNumber = 4)),
(UUID(), 0, 3, '2020-10-04', (SELECT TeamId FROM Teams WHERE TeamName = 'Crystal Palace'), (SELECT TeamId FROM Teams WHERE TeamName = 'Leeds United'), (SELECT GameweekId FROM Gameweeks WHERE GameweekNumber = 4)),
(UUID(), 1, 0, '2020-10-04', (SELECT TeamId FROM Teams WHERE TeamName = 'West Ham United'), (SELECT TeamId FROM Teams WHERE TeamName = 'Burnley'), (SELECT GameweekId FROM Gameweeks WHERE GameweekNumber = 4)),
(UUID(), 3, 2, '2020-10-04', (SELECT TeamId FROM Teams WHERE TeamName = 'Newcastle United'), (SELECT TeamId FROM Teams WHERE TeamName = 'Brighton & Hove Albion'), (SELECT GameweekId FROM Gameweeks WHERE GameweekNumber = 4)),
(UUID(), 2, 1, '2020-10-05', (SELECT TeamId FROM Teams WHERE TeamName = 'Southampton'), (SELECT TeamId FROM Teams WHERE TeamName = 'West Bromwich Albion'), (SELECT GameweekId FROM Gameweeks WHERE GameweekNumber = 4)),
(UUID(), 0, 2, '2020-10-05', (SELECT TeamId FROM Teams WHERE TeamName = 'Chelsea'), (SELECT TeamId FROM Teams WHERE TeamName = 'Leicester City'), (SELECT GameweekId FROM Gameweeks WHERE GameweekNumber = 4)),
(UUID(), 2, 2, '2020-10-06', (SELECT TeamId FROM Teams WHERE TeamName = 'Aston Villa'), (SELECT TeamId FROM Teams WHERE TeamName = 'Manchester City'), (SELECT GameweekId FROM Gameweeks WHERE GameweekNumber = 4)),
(UUID(), 1, 3, '2020-10-06', (SELECT TeamId FROM Teams WHERE TeamName = 'Manchester United'), (SELECT TeamId FROM Teams WHERE TeamName = 'Tottenham Hotspur'), (SELECT GameweekId FROM Gameweeks WHERE GameweekNumber = 4)),
(UUID(), 0, 1, '2020-10-07', (SELECT TeamId FROM Teams WHERE TeamName = 'Liverpool'), (SELECT TeamId FROM Teams WHERE TeamName = 'Everton'), (SELECT GameweekId FROM Gameweeks WHERE GameweekNumber = 4));

-- Inserting Matches for Gameweek 5 (10 matches)
INSERT INTO Matches (MatchId, HomeTeamGoals, AwayTeamGoals, MatchDate, HomeTeamId, AwayTeamId, GameweekId)
VALUES
(UUID(), 2, 0, '2020-10-10', (SELECT TeamId FROM Teams WHERE TeamName = 'Arsenal'), (SELECT TeamId FROM Teams WHERE TeamName = 'Brighton & Hove Albion'), (SELECT GameweekId FROM Gameweeks WHERE GameweekNumber = 5)),
(UUID(), 1, 2, '2020-10-10', (SELECT TeamId FROM Teams WHERE TeamName = 'Leeds United'), (SELECT TeamId FROM Teams WHERE TeamName = 'Manchester City'), (SELECT GameweekId FROM Gameweeks WHERE GameweekNumber = 5)),
(UUID(), 1, 0, '2020-10-11', (SELECT TeamId FROM Teams WHERE TeamName = 'Leicester City'), (SELECT TeamId FROM Teams WHERE TeamName = 'Wolverhampton Wanderers'), (SELECT GameweekId FROM Gameweeks WHERE GameweekNumber = 5)),
(UUID(), 0, 2, '2020-10-11', (SELECT TeamId FROM Teams WHERE TeamName = 'Everton'), (SELECT TeamId FROM Teams WHERE TeamName = 'Liverpool'), (SELECT GameweekId FROM Gameweeks WHERE GameweekNumber = 5)),
(UUID(), 3, 1, '2020-10-11', (SELECT TeamId FROM Teams WHERE TeamName = 'Tottenham Hotspur'), (SELECT TeamId FROM Teams WHERE TeamName = 'West Ham United'), (SELECT GameweekId FROM Gameweeks WHERE GameweekNumber = 5)),
(UUID(), 2, 1, '2020-10-12', (SELECT TeamId FROM Teams WHERE TeamName = 'Aston Villa'), (SELECT TeamId FROM Teams WHERE TeamName = 'Fulham'), (SELECT GameweekId FROM Gameweeks WHERE GameweekNumber = 5)),
(UUID(), 1, 0, '2020-10-12', (SELECT TeamId FROM Teams WHERE TeamName = 'Sheffield United'), (SELECT TeamId FROM Teams WHERE TeamName = 'Newcastle United'), (SELECT GameweekId FROM Gameweeks WHERE GameweekNumber = 5)),
(UUID(), 2, 2, '2020-10-13', (SELECT TeamId FROM Teams WHERE TeamName = 'Burnley'), (SELECT TeamId FROM Teams WHERE TeamName = 'Crystal Palace'), (SELECT GameweekId FROM Gameweeks WHERE GameweekNumber = 5)),
(UUID(), 1, 1, '2020-10-13', (SELECT TeamId FROM Teams WHERE TeamName = 'Manchester United'), (SELECT TeamId FROM Teams WHERE TeamName = 'Southampton'), (SELECT GameweekId FROM Gameweeks WHERE GameweekNumber = 5)),
(UUID(), 0, 3, '2020-10-14', (SELECT TeamId FROM Teams WHERE TeamName = 'West Bromwich Albion'), (SELECT TeamId FROM Teams WHERE TeamName = 'Chelsea'), (SELECT GameweekId FROM Gameweeks WHERE GameweekNumber = 5));

-- Inserting Matches for Gameweek 6 (10 matches)
INSERT INTO Matches (MatchId, HomeTeamGoals, AwayTeamGoals, MatchDate, HomeTeamId, AwayTeamId, GameweekId)
VALUES
(UUID(), 1, 1, '2020-10-17', (SELECT TeamId FROM Teams WHERE TeamName = 'West Ham United'), (SELECT TeamId FROM Teams WHERE TeamName = 'Manchester City'), (SELECT GameweekId FROM Gameweeks WHERE GameweekNumber = 6)),
(UUID(), 2, 0, '2020-10-17', (SELECT TeamId FROM Teams WHERE TeamName = 'Chelsea'), (SELECT TeamId FROM Teams WHERE TeamName = 'Southampton'), (SELECT GameweekId FROM Gameweeks WHERE GameweekNumber = 6)),
(UUID(), 1, 0, '2020-10-18', (SELECT TeamId FROM Teams WHERE TeamName = 'Wolverhampton Wanderers'), (SELECT TeamId FROM Teams WHERE TeamName = 'Fulham'), (SELECT GameweekId FROM Gameweeks WHERE GameweekNumber = 6)),
(UUID(), 0, 1, '2020-10-18', (SELECT TeamId FROM Teams WHERE TeamName = 'Newcastle United'), (SELECT TeamId FROM Teams WHERE TeamName = 'Burnley'), (SELECT GameweekId FROM Gameweeks WHERE GameweekNumber = 6)),
(UUID(), 2, 2, '2020-10-18', (SELECT TeamId FROM Teams WHERE TeamName = 'West Bromwich Albion'), (SELECT TeamId FROM Teams WHERE TeamName = 'Leeds United'), (SELECT GameweekId FROM Gameweeks WHERE GameweekNumber = 6)),
(UUID(), 0, 3, '2020-10-19', (SELECT TeamId FROM Teams WHERE TeamName = 'Crystal Palace'), (SELECT TeamId FROM Teams WHERE TeamName = 'Everton'), (SELECT GameweekId FROM Gameweeks WHERE GameweekNumber = 6)),
(UUID(), 1, 1, '2020-10-19', (SELECT TeamId FROM Teams WHERE TeamName = 'Tottenham Hotspur'), (SELECT TeamId FROM Teams WHERE TeamName = 'Brighton & Hove Albion'), (SELECT GameweekId FROM Gameweeks WHERE GameweekNumber = 6)),
(UUID(), 2, 3, '2020-10-20', (SELECT TeamId FROM Teams WHERE TeamName = 'Manchester United'), (SELECT TeamId FROM Teams WHERE TeamName = 'Arsenal'), (SELECT GameweekId FROM Gameweeks WHERE GameweekNumber = 6)),
(UUID(), 3, 1, '2020-10-20', (SELECT TeamId FROM Teams WHERE TeamName = 'Leicester City'), (SELECT TeamId FROM Teams WHERE TeamName = 'Sheffield United'), (SELECT GameweekId FROM Gameweeks WHERE GameweekNumber = 6)),
(UUID(), 0, 0, '2020-10-21', (SELECT TeamId FROM Teams WHERE TeamName = 'Liverpool'), (SELECT TeamId FROM Teams WHERE TeamName = 'Aston Villa'), (SELECT GameweekId FROM Gameweeks WHERE GameweekNumber = 6));

-- Inserting Matches for Gameweek 7 (10 matches)
INSERT INTO Matches (MatchId, HomeTeamGoals, AwayTeamGoals, MatchDate, HomeTeamId, AwayTeamId, GameweekId)
VALUES
(UUID(), 2, 1, '2020-10-24', (SELECT TeamId FROM Teams WHERE TeamName = 'Arsenal'), (SELECT TeamId FROM Teams WHERE TeamName = 'Leicester City'), (SELECT GameweekId FROM Gameweeks WHERE GameweekNumber = 7)),
(UUID(), 0, 1, '2020-10-24', (SELECT TeamId FROM Teams WHERE TeamName = 'Brighton & Hove Albion'), (SELECT TeamId FROM Teams WHERE TeamName = 'West Bromwich Albion'), (SELECT GameweekId FROM Gameweeks WHERE GameweekNumber = 7)),
(UUID(), 1, 3, '2020-10-25', (SELECT TeamId FROM Teams WHERE TeamName = 'Burnley'), (SELECT TeamId FROM Teams WHERE TeamName = 'Manchester United'), (SELECT GameweekId FROM Gameweeks WHERE GameweekNumber = 7)),
(UUID(), 1, 0, '2020-10-25', (SELECT TeamId FROM Teams WHERE TeamName = 'Crystal Palace'), (SELECT TeamId FROM Teams WHERE TeamName = 'Wolverhampton Wanderers'), (SELECT GameweekId FROM Gameweeks WHERE GameweekNumber = 7)),
(UUID(), 2, 2, '2020-10-25', (SELECT TeamId FROM Teams WHERE TeamName = 'Fulham'), (SELECT TeamId FROM Teams WHERE TeamName = 'Sheffield United'), (SELECT GameweekId FROM Gameweeks WHERE GameweekNumber = 7)),
(UUID(), 0, 3, '2020-10-26', (SELECT TeamId FROM Teams WHERE TeamName = 'Leeds United'), (SELECT TeamId FROM Teams WHERE TeamName = 'Chelsea'), (SELECT GameweekId FROM Gameweeks WHERE GameweekNumber = 7)),
(UUID(), 1, 2, '2020-10-26', (SELECT TeamId FROM Teams WHERE TeamName = 'Liverpool'), (SELECT TeamId FROM Teams WHERE TeamName = 'Tottenham Hotspur'), (SELECT GameweekId FROM Gameweeks WHERE GameweekNumber = 7)),
(UUID(), 3, 0, '2020-10-27', (SELECT TeamId FROM Teams WHERE TeamName = 'Manchester City'), (SELECT TeamId FROM Teams WHERE TeamName = 'Newcastle United'), (SELECT GameweekId FROM Gameweeks WHERE GameweekNumber = 7)),
(UUID(), 2, 0, '2020-10-27', (SELECT TeamId FROM Teams WHERE TeamName = 'Southampton'), (SELECT TeamId FROM Teams WHERE TeamName = 'Aston Villa'), (SELECT GameweekId FROM Gameweeks WHERE GameweekNumber = 7)),
(UUID(), 0, 1, '2020-10-28', (SELECT TeamId FROM Teams WHERE TeamName = 'West Ham United'), (SELECT TeamId FROM Teams WHERE TeamName = 'Everton'), (SELECT GameweekId FROM Gameweeks WHERE GameweekNumber = 7));



-- Inserting Matches for Gameweek 8 (10 matches)
INSERT INTO Matches (MatchId, HomeTeamGoals, AwayTeamGoals, MatchDate, HomeTeamId, AwayTeamId, GameweekId)
VALUES
(UUID(), 0, 1, '2020-10-31', (SELECT TeamId FROM Teams WHERE TeamName = 'Aston Villa'), (SELECT TeamId FROM Teams WHERE TeamName = 'Southampton'), (SELECT GameweekId FROM Gameweeks WHERE GameweekNumber = 8)),
(UUID(), 2, 0, '2020-10-31', (SELECT TeamId FROM Teams WHERE TeamName = 'Brighton & Hove Albion'), (SELECT TeamId FROM Teams WHERE TeamName = 'Burnley'), (SELECT GameweekId FROM Gameweeks WHERE GameweekNumber = 8)),
(UUID(), 1, 2, '2020-11-01', (SELECT TeamId FROM Teams WHERE TeamName = 'Chelsea'), (SELECT TeamId FROM Teams WHERE TeamName = 'Tottenham Hotspur'), (SELECT GameweekId FROM Gameweeks WHERE GameweekNumber = 8)),
(UUID(), 1, 1, '2020-11-01', (SELECT TeamId FROM Teams WHERE TeamName = 'Everton'), (SELECT TeamId FROM Teams WHERE TeamName = 'Leeds United'), (SELECT GameweekId FROM Gameweeks WHERE GameweekNumber = 8)),
(UUID(), 3, 0, '2020-11-01', (SELECT TeamId FROM Teams WHERE TeamName = 'Leicester City'), (SELECT TeamId FROM Teams WHERE TeamName = 'Crystal Palace'), (SELECT GameweekId FROM Gameweeks WHERE GameweekNumber = 8)),
(UUID(), 2, 1, '2020-11-02', (SELECT TeamId FROM Teams WHERE TeamName = 'Liverpool'), (SELECT TeamId FROM Teams WHERE TeamName = 'West Ham United'), (SELECT GameweekId FROM Gameweeks WHERE GameweekNumber = 8)),
(UUID(), 1, 1, '2020-11-02', (SELECT TeamId FROM Teams WHERE TeamName = 'Manchester City'), (SELECT TeamId FROM Teams WHERE TeamName = 'Fulham'), (SELECT GameweekId FROM Gameweeks WHERE GameweekNumber = 8)),
(UUID(), 0, 2, '2020-11-03', (SELECT TeamId FROM Teams WHERE TeamName = 'Newcastle United'), (SELECT TeamId FROM Teams WHERE TeamName = 'Arsenal'), (SELECT GameweekId FROM Gameweeks WHERE GameweekNumber = 8)),
(UUID(), 2, 0, '2020-11-03', (SELECT TeamId FROM Teams WHERE TeamName = 'Sheffield United'), (SELECT TeamId FROM Teams WHERE TeamName = 'Manchester United'), (SELECT GameweekId FROM Gameweeks WHERE GameweekNumber = 8)),
(UUID(), 2, 3, '2020-11-04', (SELECT TeamId FROM Teams WHERE TeamName = 'West Bromwich Albion'), (SELECT TeamId FROM Teams WHERE TeamName = 'Wolverhampton Wanderers'), (SELECT GameweekId FROM Gameweeks WHERE GameweekNumber = 8));

-- Inserting Matches for Gameweek 9 (10 matches)
INSERT INTO Matches (MatchId, HomeTeamGoals, AwayTeamGoals, MatchDate, HomeTeamId, AwayTeamId, GameweekId)
VALUES
(UUID(), 1, 1, '2020-11-07', (SELECT TeamId FROM Teams WHERE TeamName = 'Arsenal'), (SELECT TeamId FROM Teams WHERE TeamName = 'Aston Villa'), (SELECT GameweekId FROM Gameweeks WHERE GameweekNumber = 9)),
(UUID(), 1, 0, '2020-11-07', (SELECT TeamId FROM Teams WHERE TeamName = 'Brighton & Hove Albion'), (SELECT TeamId FROM Teams WHERE TeamName = 'Everton'), (SELECT GameweekId FROM Gameweeks WHERE GameweekNumber = 9)),
(UUID(), 2, 0, '2020-11-08', (SELECT TeamId FROM Teams WHERE TeamName = 'Burnley'), (SELECT TeamId FROM Teams WHERE TeamName = 'Leeds United'), (SELECT GameweekId FROM Gameweeks WHERE GameweekNumber = 9)),
(UUID(), 0, 3, '2020-11-08', (SELECT TeamId FROM Teams WHERE TeamName = 'Crystal Palace'), (SELECT TeamId FROM Teams WHERE TeamName = 'Liverpool'), (SELECT GameweekId FROM Gameweeks WHERE GameweekNumber = 9)),
(UUID(), 1, 2, '2020-11-08', (SELECT TeamId FROM Teams WHERE TeamName = 'Fulham'), (SELECT TeamId FROM Teams WHERE TeamName = 'Leicester City'), (SELECT GameweekId FROM Gameweeks WHERE GameweekNumber = 9)),
(UUID(), 0, 1, '2020-11-09', (SELECT TeamId FROM Teams WHERE TeamName = 'Manchester City'), (SELECT TeamId FROM Teams WHERE TeamName = 'Tottenham Hotspur'), (SELECT GameweekId FROM Gameweeks WHERE GameweekNumber = 9)),
(UUID(), 2, 1, '2020-11-09', (SELECT TeamId FROM Teams WHERE TeamName = 'Manchester United'), (SELECT TeamId FROM Teams WHERE TeamName = 'West Ham United'), (SELECT GameweekId FROM Gameweeks WHERE GameweekNumber = 9)),
(UUID(), 1, 2, '2020-11-10', (SELECT TeamId FROM Teams WHERE TeamName = 'Newcastle United'), (SELECT TeamId FROM Teams WHERE TeamName = 'Sheffield United'), (SELECT GameweekId FROM Gameweeks WHERE GameweekNumber = 9)),
(UUID(), 1, 1, '2020-11-10', (SELECT TeamId FROM Teams WHERE TeamName = 'Southampton'), (SELECT TeamId FROM Teams WHERE TeamName = 'West Bromwich Albion'), (SELECT GameweekId FROM Gameweeks WHERE GameweekNumber = 9)),
(UUID(), 0, 2, '2020-11-11', (SELECT TeamId FROM Teams WHERE TeamName = 'Wolverhampton Wanderers'), (SELECT TeamId FROM Teams WHERE TeamName = 'Chelsea'), (SELECT GameweekId FROM Gameweeks WHERE GameweekNumber = 9));

-- Inserting Matches for Gameweek 10 (10 matches)
INSERT INTO Matches (MatchId, HomeTeamGoals, AwayTeamGoals, MatchDate, HomeTeamId, AwayTeamId, GameweekId)
VALUES
(UUID(), 1, 2, '2020-11-14', (SELECT TeamId FROM Teams WHERE TeamName = 'Arsenal'), (SELECT TeamId FROM Teams WHERE TeamName = 'Wolverhampton Wanderers'), (SELECT GameweekId FROM Gameweeks WHERE GameweekNumber = 10)),
(UUID(), 2, 0, '2020-11-14', (SELECT TeamId FROM Teams WHERE TeamName = 'Brighton & Hove Albion'), (SELECT TeamId FROM Teams WHERE TeamName = 'Leeds United'), (SELECT GameweekId FROM Gameweeks WHERE GameweekNumber = 10)),
(UUID(), 2, 1, '2020-11-15', (SELECT TeamId FROM Teams WHERE TeamName = 'Burnley'), (SELECT TeamId FROM Teams WHERE TeamName = 'Crystal Palace'), (SELECT GameweekId FROM Gameweeks WHERE GameweekNumber = 10)),
(UUID(), 1, 1, '2020-11-15', (SELECT TeamId FROM Teams WHERE TeamName = 'Chelsea'), (SELECT TeamId FROM Teams WHERE TeamName = 'Everton'), (SELECT GameweekId FROM Gameweeks WHERE GameweekNumber = 10)),
(UUID(), 0, 3, '2020-11-15', (SELECT TeamId FROM Teams WHERE TeamName = 'Fulham'), (SELECT TeamId FROM Teams WHERE TeamName = 'Manchester United'), (SELECT GameweekId FROM Gameweeks WHERE GameweekNumber = 10)),
(UUID(), 1, 2, '2020-11-16', (SELECT TeamId FROM Teams WHERE TeamName = 'Leicester City'), (SELECT TeamId FROM Teams WHERE TeamName = 'Southampton'), (SELECT GameweekId FROM Gameweeks WHERE GameweekNumber = 10)),
(UUID(), 3, 0, '2020-11-16', (SELECT TeamId FROM Teams WHERE TeamName = 'Liverpool'), (SELECT TeamId FROM Teams WHERE TeamName = 'Newcastle United'), (SELECT GameweekId FROM Gameweeks WHERE GameweekNumber = 10)),
(UUID(), 2, 1, '2020-11-17', (SELECT TeamId FROM Teams WHERE TeamName = 'Manchester City'), (SELECT TeamId FROM Teams WHERE TeamName = 'Sheffield United'), (SELECT GameweekId FROM Gameweeks WHERE GameweekNumber = 10)),
(UUID(), 1, 0, '2020-11-17', (SELECT TeamId FROM Teams WHERE TeamName = 'Tottenham Hotspur'), (SELECT TeamId FROM Teams WHERE TeamName = 'West Bromwich Albion'), (SELECT GameweekId FROM Gameweeks WHERE GameweekNumber = 10)),
(UUID(), 2, 2, '2020-11-18', (SELECT TeamId FROM Teams WHERE TeamName = 'West Ham United'), (SELECT TeamId FROM Teams WHERE TeamName = 'Aston Villa'), (SELECT GameweekId FROM Gameweeks WHERE GameweekNumber = 10));

