﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using UruIT.GameOfDrones.Repository;

namespace UruIT.GameOfDrones.Repository.Migrations
{
    [DbContext(typeof(AssessmentContext))]
    [Migration("20190524021613_UruITDataBase")]
    partial class UruITDataBase
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("UruIT.GameOfDrones.Domain.Entities.HandSignal", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DataRegister");

                    b.Property<string>("Description");

                    b.HasKey("Id");

                    b.ToTable("HandSignals");

                    b.HasData(
                        new
                        {
                            Id = 1L,
                            DataRegister = new DateTime(2019, 5, 23, 23, 16, 13, 592, DateTimeKind.Local).AddTicks(4401),
                            Description = "Paper"
                        },
                        new
                        {
                            Id = 2L,
                            DataRegister = new DateTime(2019, 5, 23, 23, 16, 13, 594, DateTimeKind.Local).AddTicks(1249),
                            Description = "Rock"
                        },
                        new
                        {
                            Id = 3L,
                            DataRegister = new DateTime(2019, 5, 23, 23, 16, 13, 594, DateTimeKind.Local).AddTicks(1487),
                            Description = "Scissor"
                        });
                });

            modelBuilder.Entity("UruIT.GameOfDrones.Domain.Entities.Match", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CurrentRound");

                    b.Property<DateTime>("DataRegister");

                    b.Property<string>("HashId");

                    b.HasKey("Id");

                    b.ToTable("Matches");
                });

            modelBuilder.Entity("UruIT.GameOfDrones.Domain.Entities.Player", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DataRegister");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Players");
                });

            modelBuilder.Entity("UruIT.GameOfDrones.Domain.Entities.Round", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DataRegister");

                    b.Property<int>("HandSignalId");

                    b.Property<int>("MatchId");

                    b.Property<int>("PlayerId");

                    b.Property<int>("SecondHandSignalId");

                    b.Property<int>("SecondPlayerId");

                    b.Property<int>("WinnerId");

                    b.HasKey("Id");

                    b.ToTable("Rounds");
                });
#pragma warning restore 612, 618
        }
    }
}