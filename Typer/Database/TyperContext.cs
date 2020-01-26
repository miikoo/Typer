using Microsoft.EntityFrameworkCore;
using Typer.Database.Entities;

namespace Typer.Database
{
    public class TyperContext : DbContext // connection streing 
    {
        public TyperContext(DbContextOptions<TyperContext> options) : base(options)
        {

        }

        public DbSet<User> Users { get; set; }
        public DbSet<Team> Teams { get; set; }

















        public DbSet<Match> Matches { get; set; }
        public DbSet<Gameweek> Gameweeks { get; set; }
        public DbSet<Season> Seasons { get; set; }   
        public DbSet<MatchPrediction> MatchPredictions { get; set; }
        

        protected override void OnModelCreating(ModelBuilder builder)
        {
            // Teams 
            builder.Entity<Team>().HasKey(x => x.TeamId);


            //User
            builder.Entity<User>().HasKey(x => x.UserId);
























            builder
                .Entity<User>()
                .HasMany(x => x.MatchPredictions)
                .WithOne(x => x.User);

            // Matches
            builder
                .Entity<Match>()
                .HasKey(x => x.MatchId);
            builder
                .Entity<Match>()
                .HasOne(x => x.Gameweek)
                .WithMany(x => x.Matches);
            builder
                .Entity<Match>()
                .HasOne(x => x.AwayTeam);
            builder
                .Entity<Match>()
                .HasOne(x => x.HomeTeam);

            // Gameweeks
            builder
                .Entity<Gameweek>()
                .HasKey(x => x.GameweekId);
            builder
                .Entity<Gameweek>()
                .HasOne(x => x.Season)
                .WithMany(x => x.Gameweeks);
            builder
                .Entity<Gameweek>()
                .HasMany(x => x.Matches)
                .WithOne(x => x.Gameweek);

            //Seasons
            builder
                .Entity<Season>()
                .HasKey(x => x.SeasonId);
            builder
                .Entity<Season>()
                .HasMany(x => x.Gameweeks)
                .WithOne(x => x.Season);

            //MatchPrediction
            builder
                .Entity<MatchPrediction>()
                .HasKey(x => x.MatchPredictionId);
            builder
                .Entity<MatchPrediction>()
                .HasOne(x => x.User)
                .WithMany(x => x.MatchPredictions);
            builder
                .Entity<MatchPrediction>()
                .HasOne(x => x.Match)
                .WithMany(x => x.MatchPredictions);
        }
    }
}
