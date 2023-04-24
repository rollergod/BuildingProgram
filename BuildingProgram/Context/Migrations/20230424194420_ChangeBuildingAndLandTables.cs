using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BuildingProgram.Context.Migrations
{
    public partial class ChangeBuildingAndLandTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Address",
                table: "BuildingObjects");

            migrationBuilder.AddColumn<string>(
                name: "Address",
                table: "Lands",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "LandId",
                table: "BuildingObjects",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_BuildingObjects_LandId",
                table: "BuildingObjects",
                column: "LandId");

            migrationBuilder.AddForeignKey(
                name: "FK_BuildingObjects_Lands_LandId",
                table: "BuildingObjects",
                column: "LandId",
                principalTable: "Lands",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BuildingObjects_Lands_LandId",
                table: "BuildingObjects");

            migrationBuilder.DropIndex(
                name: "IX_BuildingObjects_LandId",
                table: "BuildingObjects");

            migrationBuilder.DropColumn(
                name: "Address",
                table: "Lands");

            migrationBuilder.DropColumn(
                name: "LandId",
                table: "BuildingObjects");

            migrationBuilder.AddColumn<string>(
                name: "Address",
                table: "BuildingObjects",
                type: "text",
                nullable: false,
                defaultValue: "");
        }
    }
}
