INSERT INTO Teams (TeamId, TeamName)
VALUES
(NEWID(), 'Arsenal'),
(NEWID(), 'Aston Villa'),
(NEWID(), 'Brighton & Hove Albion'),
(NEWID(), 'Burnley'),
(NEWID(), 'Chelsea'),
(NEWID(), 'Crystal Palace'),
(NEWID(), 'Everton'),
(NEWID(), 'Fulham'),
(NEWID(), 'Leeds United'),
(NEWID(), 'Leicester City'),
(NEWID(), 'Liverpool'),
(NEWID(), 'Manchester City'),
(NEWID(), 'Manchester United'),
(NEWID(), 'Newcastle United'),
(NEWID(), 'Sheffield United'),
(NEWID(), 'Southampton'),
(NEWID(), 'Tottenham Hotspur'),
(NEWID(), 'West Bromwich Albion'),
(NEWID(), 'Bournemouth'),
(NEWID(), 'Luton Town'),
(NEWID(), 'Nottingham Forest'),
(NEWID(), 'West Ham United'),
(NEWID(), 'Wolverhampton Wanderers')

-- Fetching Team IDs
DECLARE @AstonVillaId UNIQUEIDENTIFIER = (SELECT TeamId FROM Teams WHERE TeamName = 'Aston Villa');
DECLARE @ArsenalId UNIQUEIDENTIFIER = (SELECT TeamId FROM Teams WHERE TeamName = 'Arsenal');
DECLARE @BrightonId UNIQUEIDENTIFIER = (SELECT TeamId FROM Teams WHERE TeamName = 'Brighton & Hove Albion');
DECLARE @BurnleyId UNIQUEIDENTIFIER = (SELECT TeamId FROM Teams WHERE TeamName = 'Burnley');
DECLARE @ChelseaId UNIQUEIDENTIFIER = (SELECT TeamId FROM Teams WHERE TeamName = 'Chelsea');
DECLARE @CrystalPalaceId UNIQUEIDENTIFIER = (SELECT TeamId FROM Teams WHERE TeamName = 'Crystal Palace');
DECLARE @EvertonId UNIQUEIDENTIFIER = (SELECT TeamId FROM Teams WHERE TeamName = 'Everton');
DECLARE @FulhamId UNIQUEIDENTIFIER = (SELECT TeamId FROM Teams WHERE TeamName = 'Fulham');
DECLARE @LeedsId UNIQUEIDENTIFIER = (SELECT TeamId FROM Teams WHERE TeamName = 'Leeds United');
DECLARE @LeicesterId UNIQUEIDENTIFIER = (SELECT TeamId FROM Teams WHERE TeamName = 'Leicester City');
DECLARE @LiverpoolId UNIQUEIDENTIFIER = (SELECT TeamId FROM Teams WHERE TeamName = 'Liverpool');
DECLARE @ManCityId UNIQUEIDENTIFIER = (SELECT TeamId FROM Teams WHERE TeamName = 'Manchester City');
DECLARE @ManUtdId UNIQUEIDENTIFIER = (SELECT TeamId FROM Teams WHERE TeamName = 'Manchester United');
DECLARE @NewcastleId UNIQUEIDENTIFIER = (SELECT TeamId FROM Teams WHERE TeamName = 'Newcastle United');
DECLARE @SheffieldId UNIQUEIDENTIFIER = (SELECT TeamId FROM Teams WHERE TeamName = 'Sheffield United');
DECLARE @SouthamptonId UNIQUEIDENTIFIER = (SELECT TeamId FROM Teams WHERE TeamName = 'Southampton');
DECLARE @SpursId UNIQUEIDENTIFIER = (SELECT TeamId FROM Teams WHERE TeamName = 'Tottenham Hotspur');
DECLARE @WestBromId UNIQUEIDENTIFIER = (SELECT TeamId FROM Teams WHERE TeamName = 'West Bromwich Albion');
DECLARE @WestHamId UNIQUEIDENTIFIER = (SELECT TeamId FROM Teams WHERE TeamName = 'West Ham United');
DECLARE @WolvesId UNIQUEIDENTIFIER = (SELECT TeamId FROM Teams WHERE TeamName = 'Wolverhampton Wanderers');


INSERT INTO Matches (MatchId, HomeTeamGoals, AwayTeamGoals, MatchDate, HomeTeamId, AwayTeamId, GameweekId)
VALUES
(NEWID(), 2, 2, '2020-09-12', @LiverpoolId, @LeedsId, @Gameweek1Id),
(NEWID(), 1, 3, '2020-09-12', @WestHamId, @NewcastleId, @Gameweek1Id),
(NEWID(), 0, 2, '2020-09-12', @WestBromId, @LeicesterId, @Gameweek1Id),
(NEWID(), 3, 1, '2020-09-13', @SpursId, @EvertonId, @Gameweek1Id),
(NEWID(), 2, 0, '2020-09-13', @SheffieldId, @WolvesId, @Gameweek1Id),
(NEWID(), 1, 1, '2020-09-13', @BrightonId, @ChelseaId, @Gameweek1Id),
(NEWID(), 3, 0, '2020-09-14', @ManUtdId, @SouthamptonId, @Gameweek1Id),
(NEWID(), 4, 1, '2020-09-14', @ManCityId, @AstonVillaId, @Gameweek1Id);
(NEWID(), 2, 0, '2020-09-15', @ArsenalId, @BurnleyId, @Gameweek1Id);
(NEWID(), 1, 2, '2020-09-15', @FulhamId, @CrystalPalaceId, @Gameweek1Id);

-- Inserting Matches for Gameweek 2 (10 matches)
INSERT INTO Matches (MatchId, HomeTeamGoals, AwayTeamGoals, MatchDate, HomeTeamId, AwayTeamId, GameweekId)
VALUES
(NEWID(), 2, 0, '2020-09-19', @LeedsId, @FulhamId, @Gameweek2Id),
(NEWID(), 1, 3, '2020-09-19', @ManUtdId, @CrystalPalaceId, @Gameweek2Id),
(NEWID(), 1, 1, '2020-09-20', @EvertonId, @WestBromId, @Gameweek2Id),
(NEWID(), 0, 2, '2020-09-20', @SheffieldId, @WolvesId, @Gameweek2Id),
(NEWID(), 1, 1, '2020-09-20', @BrightonId, @ChelseaId, @Gameweek2Id),
(NEWID(), 2, 3, '2020-09-21', @AstonVillaId, @SpursId, @Gameweek2Id),
(NEWID(), 1, 1, '2020-09-21', @WestHamId, @NewcastleId, @Gameweek2Id),
(NEWID(), 0, 4, '2020-09-21', @BurnleyId, @LiverpoolId, @Gameweek2Id),
(NEWID(), 1, 1, '2020-09-21', @LeicesterId, @ManCityId, @Gameweek2Id),
(NEWID(), 1, 1, '2020-09-22', @SouthamptonId, @ArsenalId, @Gameweek2Id);

-- Continuing from previous script

-- Inserting Matches for Gameweek 3 (10 matches)
INSERT INTO Matches (MatchId, HomeTeamGoals, AwayTeamGoals, MatchDate, HomeTeamId, AwayTeamId, GameweekId)
VALUES
(NEWID(), 2, 1, '2020-09-26', @WestHamId, @WolvesId, @Gameweek3Id),
(NEWID(), 3, 0, '2020-09-26', @ChelseaId, @CrystalPalaceId, @Gameweek3Id),
(NEWID(), 2, 1, '2020-09-27', @TottenhamId, @NewcastleId, @Gameweek3Id),
(NEWID(), 1, 2, '2020-09-27', @FulhamId, @AstonVillaId, @Gameweek3Id),
(NEWID(), 0, 0, '2020-09-27', @BurnleyId, @SouthamptonId, @Gameweek3Id),
(NEWID(), 2, 0, '2020-09-28', @LeedsId, @ManUtdId, @Gameweek3Id),
(NEWID(), 1, 1, '2020-09-28', @WestBromId, @EvertonId, @Gameweek3Id),
(NEWID(), 1, 2, '2020-09-28', @LeicesterId, @ArsenalId, @Gameweek3Id),
(NEWID(), 0, 3, '2020-09-29', @ManCityId, @BrightonId, @Gameweek3Id),
(NEWID(), 1, 2, '2020-09-29', @LiverpoolId, @SheffieldId, @Gameweek3Id);

-- Continuing from previous script

-- Inserting Matches for Gameweek 4 (10 matches)
INSERT INTO Matches (MatchId, HomeTeamGoals, AwayTeamGoals, MatchDate, HomeTeamId, AwayTeamId, GameweekId)
VALUES
(NEWID(), 1, 1, '2020-10-03', @WolvesId, @FulhamId, @Gameweek4Id),
(NEWID(), 2, 0, '2020-10-03', @ArsenalId, @SheffieldId, @Gameweek4Id),
(NEWID(), 0, 3, '2020-10-04', @CrystalPalaceId, @LeedsId, @Gameweek4Id),
(NEWID(), 1, 0, '2020-10-04', @WestHamId, @BurnleyId, @Gameweek4Id),
(NEWID(), 3, 2, '2020-10-04', @NewcastleId, @BrightonId, @Gameweek4Id),
(NEWID(), 2, 1, '2020-10-05', @SouthamptonId, @WestBromId, @Gameweek4Id),
(NEWID(), 0, 2, '2020-10-05', @ChelseaId, @LeicesterId, @Gameweek4Id),
(NEWID(), 2, 2, '2020-10-06', @AstonVillaId, @ManCityId, @Gameweek4Id),
(NEWID(), 1, 3, '2020-10-06', @ManUtdId, @TottenhamId, @Gameweek4Id),
(NEWID(), 0, 1, '2020-10-07', @LiverpoolId, @EvertonId, @Gameweek4Id);

-- Continuing from previous script

-- Inserting Matches for Gameweek 5 (10 matches)
INSERT INTO Matches (MatchId, HomeTeamGoals, AwayTeamGoals, MatchDate, HomeTeamId, AwayTeamId, GameweekId)
VALUES
(NEWID(), 2, 0, '2020-10-10', @ArsenalId, @BrightonId, @Gameweek5Id),
(NEWID(), 1, 2, '2020-10-10', @LeedsId, @ManCityId, @Gameweek5Id),
(NEWID(), 1, 0, '2020-10-11', @LeicesterId, @WolvesId, @Gameweek5Id),
(NEWID(), 0, 2, '2020-10-11', @EvertonId, @LiverpoolId, @Gameweek5Id),
(NEWID(), 3, 1, '2020-10-11', @TottenhamId, @WestHamId, @Gameweek5Id),
(NEWID(), 2, 1, '2020-10-12', @AstonVillaId, @FulhamId, @Gameweek5Id),
(NEWID(), 1, 0, '2020-10-12', @SheffieldId, @NewcastleId, @Gameweek5Id),
(NEWID(), 2, 2, '2020-10-13', @BurnleyId, @CrystalPalaceId, @Gameweek5Id),
(NEWID(), 1, 1, '2020-10-13', @ManUtdId, @SouthamptonId, @Gameweek5Id),
(NEWID(), 0, 3, '2020-10-14', @WestBromId, @ChelseaId, @Gameweek5Id);

-- Continuing from previous script

-- Inserting Matches for Gameweek 6 (10 matches)
INSERT INTO Matches (MatchId, HomeTeamGoals, AwayTeamGoals, MatchDate, HomeTeamId, AwayTeamId, GameweekId)
VALUES
(NEWID(), 1, 1, '2020-10-17', @WestHamId, @ManCityId, @Gameweek6Id),
(NEWID(), 2, 0, '2020-10-17', @ChelseaId, @SouthamptonId, @Gameweek6Id),
(NEWID(), 1, 0, '2020-10-18', @WolvesId, @FulhamId, @Gameweek6Id),
(NEWID(), 0, 1, '2020-10-18', @NewcastleId, @BurnleyId, @Gameweek6Id),
(NEWID(), 2, 2, '2020-10-18', @WestBromId, @LeedsId, @Gameweek6Id),
(NEWID(), 0, 3, '2020-10-19', @CrystalPalaceId, @EvertonId, @Gameweek6Id),
(NEWID(), 1, 1, '2020-10-19', @TottenhamId, @BrightonId, @Gameweek6Id),
(NEWID(), 2, 3, '2020-10-20', @ManUtdId, @ArsenalId, @Gameweek6Id),
(NEWID(), 3, 1, '2020-10-20', @LeicesterId, @SheffieldId, @Gameweek6Id),
(NEWID(), 0, 0, '2020-10-21', @LiverpoolId, @AstonVillaId, @Gameweek6Id);


-- Continuing from previous script

-- Inserting Matches for Gameweek 7 (10 matches)
INSERT INTO Matches (MatchId, HomeTeamGoals, AwayTeamGoals, MatchDate, HomeTeamId, AwayTeamId, GameweekId)
VALUES
(NEWID(), 2, 1, '2020-10-24', @ArsenalId, @LeicesterId, @Gameweek7Id),
(NEWID(), 0, 1, '2020-10-24', @BrightonId, @WestBromId, @Gameweek7Id),
(NEWID(), 1, 3, '2020-10-25', @BurnleyId, @ManUtdId, @Gameweek7Id),
(NEWID(), 1, 0, '2020-10-25', @CrystalPalaceId, @WolvesId, @Gameweek7Id),
(NEWID(), 2, 2, '2020-10-25', @FulhamId, @SheffieldId, @Gameweek7Id),
(NEWID(), 0, 3, '2020-10-26', @LeedsId, @ChelseaId, @Gameweek7Id),
(NEWID(), 1, 2, '2020-10-26', @LiverpoolId, @TottenhamId, @Gameweek7Id),
(NEWID(), 3, 0, '2020-10-27', @ManCityId, @NewcastleId, @Gameweek7Id),
(NEWID(), 2, 0, '2020-10-27', @SouthamptonId, @AstonVillaId, @Gameweek7Id),
(NEWID(), 0, 1, '2020-10-28', @WestHamId, @EvertonId, @Gameweek7Id);


-- Continuing from previous script

-- Inserting Matches for Gameweek 8 (10 matches)
INSERT INTO Matches (MatchId, HomeTeamGoals, AwayTeamGoals, MatchDate, HomeTeamId, AwayTeamId, GameweekId)
VALUES
(NEWID(), 0, 1, '2020-10-31', @AstonVillaId, @SouthamptonId, @Gameweek8Id),
(NEWID(), 2, 0, '2020-10-31', @BrightonId, @BurnleyId, @Gameweek8Id),
(NEWID(), 1, 2, '2020-11-01', @ChelseaId, @TottenhamId, @Gameweek8Id),
(NEWID(), 1, 1, '2020-11-01', @EvertonId, @LeedsId, @Gameweek8Id),
(NEWID(), 3, 0, '2020-11-01', @LeicesterId, @CrystalPalaceId, @Gameweek8Id),
(NEWID(), 2, 1, '2020-11-02', @LiverpoolId, @WestHamId, @Gameweek8Id),
(NEWID(), 1, 1, '2020-11-02', @ManCityId, @FulhamId, @Gameweek8Id),
(NEWID(), 0, 2, '2020-11-03', @NewcastleId, @ArsenalId, @Gameweek8Id),
(NEWID(), 2, 0, '2020-11-03', @SheffieldId, @ManUtdId, @Gameweek8Id),
(NEWID(), 2, 3, '2020-11-04', @WestBromId, @WolvesId, @Gameweek8Id);


-- Continuing from previous script

-- Inserting Matches for Gameweek 9 (10 matches)
INSERT INTO Matches (MatchId, HomeTeamGoals, AwayTeamGoals, MatchDate, HomeTeamId, AwayTeamId, GameweekId)
VALUES
(NEWID(), 1, 1, '2020-11-07', @ArsenalId, @AstonVillaId, @Gameweek9Id),
(NEWID(), 1, 0, '2020-11-07', @BrightonId, @EvertonId, @Gameweek9Id),
(NEWID(), 2, 0, '2020-11-08', @BurnleyId, @LeedsId, @Gameweek9Id),
(NEWID(), 0, 3, '2020-11-08', @CrystalPalaceId, @LiverpoolId, @Gameweek9Id),
(NEWID(), 1, 2, '2020-11-08', @FulhamId, @LeicesterId, @Gameweek9Id),
(NEWID(), 0, 1, '2020-11-09', @ManCityId, @TottenhamId, @Gameweek9Id),
(NEWID(), 2, 1, '2020-11-09', @ManUtdId, @WestHamId, @Gameweek9Id),
(NEWID(), 1, 2, '2020-11-10', @NewcastleId, @SheffieldId, @Gameweek9Id),
(NEWID(), 1, 1, '2020-11-10', @SouthamptonId, @WestBromId, @Gameweek9Id),
(NEWID(), 0, 2, '2020-11-11', @WolvesId, @ChelseaId, @Gameweek9Id);


-- Continuing from previous script

-- Inserting Matches for Gameweek 10 (10 matches)
INSERT INTO Matches (MatchId, HomeTeamGoals, AwayTeamGoals, MatchDate, HomeTeamId, AwayTeamId, GameweekId)
VALUES
(NEWID(), 1, 2, '2020-11-14', @ArsenalId, @WolvesId, @Gameweek10Id),
(NEWID(), 2, 0, '2020-11-14', @BrightonId, @LeedsId, @Gameweek10Id),
(NEWID(), 2, 1, '2020-11-15', @BurnleyId, @CrystalPalaceId, @Gameweek10Id),
(NEWID(), 1, 1, '2020-11-15', @ChelseaId, @EvertonId, @Gameweek10Id),
(NEWID(), 0, 3, '2020-11-15', @FulhamId, @ManUtdId, @Gameweek10Id),
(NEWID(), 1, 2, '2020-11-16', @LeicesterId, @SouthamptonId, @Gameweek10Id),
(NEWID(), 3, 0, '2020-11-16', @LiverpoolId, @NewcastleId, @Gameweek10Id),
(NEWID(), 2, 1, '2020-11-17', @ManCityId, @SheffieldId, @Gameweek10Id),
(NEWID(), 1, 0, '2020-11-17', @TottenhamId, @WestBromId, @Gameweek10Id),
(NEWID(), 2, 2, '2020-11-18', @WestHamId, @AstonVillaId, @Gameweek10Id);
