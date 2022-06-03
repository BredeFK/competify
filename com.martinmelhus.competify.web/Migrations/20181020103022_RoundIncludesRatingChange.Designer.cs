﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using com.martinmelhus.competify.web.Data;

namespace com.martinmelhus.competify.web.Migrations
{
    [DbContext(typeof(CompetifyDbContext))]
    [Migration("20181020103022_RoundIncludesRatingChange")]
    partial class RoundIncludesRatingChange
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.4-rtm-31024")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("com.martinmelhus.competify.web.Data.Competitor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("LeagueId");

                    b.Property<string>("Name");

                    b.Property<int>("Rating");

                    b.HasKey("Id");

                    b.HasIndex("LeagueId");

                    b.ToTable("Competitors");
                });

            modelBuilder.Entity("com.martinmelhus.competify.web.Data.League", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name");

                    b.Property<string>("Passphrase");

                    b.HasKey("Id");

                    b.ToTable("Leagues");
                });

            modelBuilder.Entity("com.martinmelhus.competify.web.Data.Round", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CompetitorA");

                    b.Property<int>("CompetitorB");

                    b.Property<DateTime>("Created");

                    b.Property<int>("LeagueId");

                    b.Property<int>("RatingChangeA");

                    b.Property<int>("RatingChangeB");

                    b.Property<int>("Result");

                    b.HasKey("Id");

                    b.HasIndex("LeagueId");

                    b.ToTable("Rounds");
                });

            modelBuilder.Entity("com.martinmelhus.competify.web.Data.Competitor", b =>
                {
                    b.HasOne("com.martinmelhus.competify.web.Data.League", "League")
                        .WithMany("Competitors")
                        .HasForeignKey("LeagueId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("com.martinmelhus.competify.web.Data.Round", b =>
                {
                    b.HasOne("com.martinmelhus.competify.web.Data.League", "League")
                        .WithMany("Rounds")
                        .HasForeignKey("LeagueId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
