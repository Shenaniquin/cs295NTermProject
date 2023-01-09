using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OregonAnimals.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Animals",
                columns: table => new
                {
                    Animal = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AnimalImage = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Animals", x => x.Animal);
                });

            migrationBuilder.CreateTable(
                name: "Sightings",
                columns: table => new
                {
                    SightingID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AnimalSightedAnimal = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    AnimalNum = table.Column<int>(type: "int", nullable: false),
                    Location = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SightingDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sightings", x => x.SightingID);
                    table.ForeignKey(
                        name: "FK_Sightings_Animals_AnimalSightedAnimal",
                        column: x => x.AnimalSightedAnimal,
                        principalTable: "Animals",
                        principalColumn: "Animal");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Sightings_AnimalSightedAnimal",
                table: "Sightings",
                column: "AnimalSightedAnimal");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Sightings");

            migrationBuilder.DropTable(
                name: "Animals");
        }
    }
}
