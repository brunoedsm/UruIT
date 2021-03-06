﻿using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace UruIT.GameOfDrones.Repository.Migrations
{
    public partial class UruITDataBase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "HandSignals",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DataRegister = table.Column<DateTime>(nullable: false),
                    Description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HandSignals", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Matches",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DataRegister = table.Column<DateTime>(nullable: false),
                    HashId = table.Column<string>(nullable: true),
                    CurrentRound = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Matches", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Players",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DataRegister = table.Column<DateTime>(nullable: false),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Players", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Rounds",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DataRegister = table.Column<DateTime>(nullable: false),
                    MatchId = table.Column<int>(nullable: false),
                    PlayerId = table.Column<int>(nullable: false),
                    HandSignalId = table.Column<int>(nullable: false),
                    SecondPlayerId = table.Column<int>(nullable: false),
                    SecondHandSignalId = table.Column<int>(nullable: false),
                    WinnerId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rounds", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "HandSignals",
                columns: new[] { "Id", "DataRegister", "Description" },
                values: new object[] { 1L, new DateTime(2019, 5, 23, 23, 16, 13, 592, DateTimeKind.Local).AddTicks(4401), "Paper" });

            migrationBuilder.InsertData(
                table: "HandSignals",
                columns: new[] { "Id", "DataRegister", "Description" },
                values: new object[] { 2L, new DateTime(2019, 5, 23, 23, 16, 13, 594, DateTimeKind.Local).AddTicks(1249), "Rock" });

            migrationBuilder.InsertData(
                table: "HandSignals",
                columns: new[] { "Id", "DataRegister", "Description" },
                values: new object[] { 3L, new DateTime(2019, 5, 23, 23, 16, 13, 594, DateTimeKind.Local).AddTicks(1487), "Scissor" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "HandSignals");

            migrationBuilder.DropTable(
                name: "Matches");

            migrationBuilder.DropTable(
                name: "Players");

            migrationBuilder.DropTable(
                name: "Rounds");
        }
    }
}
