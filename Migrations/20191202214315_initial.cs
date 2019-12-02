using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Neighbourhood_Alert.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CrimesReported",
                columns: table => new
                {
                    IncidentNo = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Date = table.Column<DateTime>(nullable: false),
                    Offense = table.Column<string>(nullable: true),
                    Weapons = table.Column<string>(nullable: true),
                    Neighborhood = table.Column<string>(nullable: true),
                    Address = table.Column<string>(nullable: true),
                    TotalNumberOfSuspects = table.Column<int>(nullable: false),
                    RaceOfSuspect = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CrimesReported", x => x.IncidentNo);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CrimesReported");
        }
    }
}
