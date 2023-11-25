CREATE TABLE Users (
    UserId VARCHAR(255) PRIMARY KEY,
    Username NVARCHAR(255),
    Email NVARCHAR(255),
    Password NVARCHAR(255),
    Role INT,
    Salt NVARCHAR(255)
);

CREATE TABLE Teams (
    TeamId VARCHAR(255) PRIMARY KEY,
    TeamName NVARCHAR(255)
);

CREATE TABLE Seasons (
    SeasonId VARCHAR(255) PRIMARY KEY,
    StartYear INT,
    EndYear INT
);

CREATE TABLE Gameweeks (
    GameweekId VARCHAR(255) PRIMARY KEY,
    GameweekNumber INT,
    ExternalId BIGINT,
    SeasonId VARCHAR(255),
    FOREIGN KEY (SeasonId) REFERENCES Seasons(SeasonId) ON DELETE CASCADE
);

CREATE TABLE Matches (
    MatchId VARCHAR(255) PRIMARY KEY,
    HomeTeamGoals INT,
    AwayTeamGoals INT,
    MatchDate DATETIME,
    HomeTeamId VARCHAR(255),
    AwayTeamId VARCHAR(255),
    GameweekId VARCHAR(255),
    FOREIGN KEY (HomeTeamId) REFERENCES Teams(TeamId) ON DELETE CASCADE,
    FOREIGN KEY (AwayTeamId) REFERENCES Teams(TeamId) ON DELETE CASCADE,
    FOREIGN KEY (GameweekId) REFERENCES Gameweeks(GameweekId) ON DELETE CASCADE
);

CREATE TABLE MatchPredictions (
    MatchPredictionId VARCHAR(255) PRIMARY KEY,
    HomeTeamGoalPrediction INT,
    AwayTeamGoalPrediction INT,
    UserId VARCHAR(255),
    MatchId VARCHAR(255),
    FOREIGN KEY (UserId) REFERENCES Users(UserId) ON DELETE CASCADE,
    FOREIGN KEY (MatchId) REFERENCES Matches(MatchId) ON DELETE CASCADE
);