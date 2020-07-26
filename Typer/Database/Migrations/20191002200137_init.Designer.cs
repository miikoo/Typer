﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Typer.Database;

namespace Typer.Migrations
{
    [DbContext(typeof(TyperContext))]
    [Migration("20191002200137_init")]
    partial class init
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079");

            modelBuilder.Entity("Typer.Database.Entities.Gameweek", b =>
                {
                    b.Property<long>("GameweekId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("GameweekNumber");

                    b.Property<long>("SeasonId");

                    b.HasKey("GameweekId");

                    b.HasIndex("SeasonId");

                    b.ToTable("Gameweeks");
                });

            modelBuilder.Entity("Typer.Database.Entities.Match", b =>
                {
                    b.Property<long>("MatchId")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("AwayTeamGoals");

                    b.Property<long>("AwayTeamId");

                    b.Property<long>("GameweekId");

                    b.Property<int?>("HomeTeamGoals");

                    b.Property<long>("HomeTeamId");

                    b.HasKey("MatchId");

                    b.HasIndex("AwayTeamId");

                    b.HasIndex("GameweekId");

                    b.HasIndex("HomeTeamId");

                    b.ToTable("Matches");
                });

            modelBuilder.Entity("Typer.Database.Entities.MatchPrediction", b =>
                {
                    b.Property<long>("MatchPredictionId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AwayTeamGoalPrediction");

                    b.Property<int>("HomeTeamGoalPrediction");

                    b.Property<long>("MatchId");

                    b.Property<long>("UserId");

                    b.HasKey("MatchPredictionId");

                    b.HasIndex("MatchId");

                    b.HasIndex("UserId");

                    b.ToTable("MatchPredictions");
                });

            modelBuilder.Entity("Typer.Database.Entities.Season", b =>
                {
                    b.Property<long>("SeasonId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("EndYear");

                    b.Property<int>("StartYear");

                    b.HasKey("SeasonId");

                    b.ToTable("Seasons");
                });

            modelBuilder.Entity("Typer.Database.Entities.Team", b =>
                {
                    b.Property<long>("TeamId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("TeamName");

                    b.HasKey("TeamId");

                    b.ToTable("Teams");
                });

            modelBuilder.Entity("Typer.Database.Entities.User", b =>
                {
                    b.Property<long>("UserId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Email");

                    b.Property<string>("Password");

                    b.Property<string>("Username");

                    b.HasKey("UserId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("Typer.Database.Entities.Gameweek", b =>
                {
                    b.HasOne("Typer.Database.Entities.Season", "Season")
                        .WithMany("Gameweeks")
                        .HasForeignKey("SeasonId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Typer.Database.Entities.Match", b =>
                {
                    b.HasOne("Typer.Database.Entities.Team", "AwayTeam")
                        .WithMany()
                        .HasForeignKey("AwayTeamId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Typer.Database.Entities.Gameweek", "Gameweek")
                        .WithMany("Matches")
                        .HasForeignKey("GameweekId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Typer.Database.Entities.Team", "HomeTeam")
                        .WithMany()
                        .HasForeignKey("HomeTeamId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Typer.Database.Entities.MatchPrediction", b =>
                {
                    b.HasOne("Typer.Database.Entities.Match", "Match")
                        .WithMany("MatchPredictions")
                        .HasForeignKey("MatchId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Typer.Database.Entities.User", "User")
                        .WithMany("MatchPredictions")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}