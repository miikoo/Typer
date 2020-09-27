using Microsoft.EntityFrameworkCore;
using System;
using Microsoft.Extensions.DependencyInjection;
using System.Text;
using Typer.Infrastructure.Entities;

namespace Typer.Infrastructure
{
    public class TyperContext : DbContext
    {
        public TyperContext(DbContextOptions<TyperContext> options) : base(options)
        {
        }

        public TyperContext()
        {

        }


        public DbSet<DbMatch> Matches { get; set; }
        public DbSet<DbGameweek> Gameweeks { get; set; }
        public DbSet<DbSeason> Seasons { get; set; }
        public DbSet<DbTeam> Teams { get; set; }
        public DbSet<DbMatchPrediction> MatchPredictions { get; set; }
        public DbSet<DbUser> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {

            // Matches
            builder
                .Entity<DbMatch>()
                .HasKey(x => x.MatchId);
            builder
                .Entity<DbMatch>()
                .HasOne(x => x.Gameweek)
                .WithMany(x => x.Matches)
                .HasForeignKey(x => x.GameweekId);
            builder
                .Entity<DbMatch>()
                .HasMany(x => x.MatchPredictions)
                .WithOne(x => x.Match)
                .HasForeignKey(x => x.MatchId);
            builder
                .Entity<DbMatch>()
                .HasOne(x => x.AwayTeam)
                .WithMany(x => x.MatchesAsAwayTeam);
            builder
                .Entity<DbMatch>()
                .HasOne(x => x.HomeTeam)
                .WithMany(x => x.MatchesAsHomeTeam);

            // Gameweeks
            builder
                .Entity<DbGameweek>()
                .HasKey(x => x.GameweekId);
            builder
                .Entity<DbGameweek>()
                .HasOne(x => x.Season)
                .WithMany(x => x.Gameweeks);
            builder
                .Entity<DbGameweek>()
                .HasMany(x => x.Matches)
                .WithOne(x => x.Gameweek)
                .HasForeignKey(x => x.GameweekId);

            //Seasons
            builder
                .Entity<DbSeason>()
                .HasKey(x => x.SeasonId);
            builder
                .Entity<DbSeason>()
                .HasMany(x => x.Gameweeks)
                .WithOne(x => x.Season)
                .HasForeignKey(x => x.SeasonId);

            // Teams 
            builder
                .Entity<DbTeam>()
                .HasKey(x => x.TeamId);
            builder
                .Entity<DbTeam>()
                .HasMany(x => x.MatchesAsHomeTeam)
                .WithOne(x => x.HomeTeam)
                .HasForeignKey(x => x.HomeTeamId);
            builder
                .Entity<DbTeam>()
                .HasMany(x => x.MatchesAsAwayTeam)
                .WithOne(x => x.AwayTeam)
                .HasForeignKey(x => x.AwayTeamId);

            //MatchPrediction
            builder
                .Entity<DbMatchPrediction>()
                .HasKey(x => x.MatchPredictionId);
            builder
                .Entity<DbMatchPrediction>()
                .HasOne(x => x.User)
                .WithMany(x => x.MatchPredictions)
                .HasForeignKey(x => x.UserId);
            builder
                .Entity<DbMatchPrediction>()
                .HasOne(x => x.Match)
                .WithMany(x => x.MatchPredictions)
                .HasForeignKey(x => x.MatchPredictionId);

            //User
            builder
                .Entity<DbUser>()
                .HasKey(x => x.UserId);
            builder
                .Entity<DbUser>()
                .HasMany(x => x.MatchPredictions)
                .WithOne(x => x.User)
                .HasForeignKey(x => x.UserId);

        }
    }
}
