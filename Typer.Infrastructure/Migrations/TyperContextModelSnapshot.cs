﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Typer.Infrastructure;

namespace Typer.Infrastructure.Migrations
{
    [DbContext(typeof(TyperContext))]
    partial class TyperContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Typer.Infrastructure.Entities.DbGameweek", b =>
                {
                    b.Property<long>("GameweekId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    b.Property<int>("GameweekNumber")
                        .HasColumnType("int");

                    b.Property<long>("SeasonId")
                        .HasColumnType("bigint");

                    b.HasKey("GameweekId");

                    b.HasIndex("SeasonId");

                    b.ToTable("Gameweeks");
                });

            modelBuilder.Entity("Typer.Infrastructure.Entities.DbMatch", b =>
                {
                    b.Property<long>("MatchId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    b.Property<int?>("AwayTeamGoals")
                        .HasColumnType("int");

                    b.Property<long>("AwayTeamId")
                        .HasColumnType("bigint");

                    b.Property<long>("GameweekId")
                        .HasColumnType("bigint");

                    b.Property<int?>("HomeTeamGoals")
                        .HasColumnType("int");

                    b.Property<long>("HomeTeamId")
                        .HasColumnType("bigint");

                    b.Property<DateTime>("MatchDate")
                        .HasColumnType("datetime(6)");

                    b.HasKey("MatchId");

                    b.HasIndex("AwayTeamId");

                    b.HasIndex("GameweekId");

                    b.HasIndex("HomeTeamId");

                    b.ToTable("Matches");
                });

            modelBuilder.Entity("Typer.Infrastructure.Entities.DbMatchPrediction", b =>
                {
                    b.Property<long>("MatchPredictionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    b.Property<int?>("AwayTeamGoalPrediction")
                        .HasColumnType("int");

                    b.Property<int?>("HomeTeamGoalPrediction")
                        .HasColumnType("int");

                    b.Property<long>("MatchId")
                        .HasColumnType("bigint");

                    b.Property<Guid>("UserId")
                        .HasColumnType("char(36)");

                    b.HasKey("MatchPredictionId");

                    b.HasIndex("MatchId");

                    b.HasIndex("UserId");

                    b.ToTable("MatchPredictions");
                });

            modelBuilder.Entity("Typer.Infrastructure.Entities.DbSeason", b =>
                {
                    b.Property<long>("SeasonId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    b.Property<int>("EndYear")
                        .HasColumnType("int");

                    b.Property<int>("StartYear")
                        .HasColumnType("int");

                    b.HasKey("SeasonId");

                    b.ToTable("Seasons");
                });

            modelBuilder.Entity("Typer.Infrastructure.Entities.DbTeam", b =>
                {
                    b.Property<long>("TeamId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    b.Property<string>("TeamName")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("TeamId");

                    b.ToTable("Teams");
                });

            modelBuilder.Entity("Typer.Infrastructure.Entities.DbUser", b =>
                {
                    b.Property<Guid>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<string>("Email")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Password")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<int>("Role")
                        .HasColumnType("int");

                    b.Property<string>("Salt")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Username")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("UserId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("Typer.Infrastructure.Entities.DbGameweek", b =>
                {
                    b.HasOne("Typer.Infrastructure.Entities.DbSeason", "Season")
                        .WithMany("Gameweeks")
                        .HasForeignKey("SeasonId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Typer.Infrastructure.Entities.DbMatch", b =>
                {
                    b.HasOne("Typer.Infrastructure.Entities.DbTeam", "AwayTeam")
                        .WithMany("MatchesAsAwayTeam")
                        .HasForeignKey("AwayTeamId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Typer.Infrastructure.Entities.DbGameweek", "Gameweek")
                        .WithMany("Matches")
                        .HasForeignKey("GameweekId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Typer.Infrastructure.Entities.DbTeam", "HomeTeam")
                        .WithMany("MatchesAsHomeTeam")
                        .HasForeignKey("HomeTeamId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Typer.Infrastructure.Entities.DbMatchPrediction", b =>
                {
                    b.HasOne("Typer.Infrastructure.Entities.DbMatch", "Match")
                        .WithMany("MatchPredictions")
                        .HasForeignKey("MatchId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Typer.Infrastructure.Entities.DbUser", "User")
                        .WithMany("MatchPredictions")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
