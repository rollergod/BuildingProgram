using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BuildingProgram.Context.Migrations
{
    public partial class AddOrgColumnInBuildingTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "OrganizationId",
                table: "BuildingObjects",
                type: "integer",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_BuildingObjects_OrganizationId",
                table: "BuildingObjects",
                column: "OrganizationId");

            migrationBuilder.AddForeignKey(
                name: "FK_BuildingObjects_Organizations_OrganizationId",
                table: "BuildingObjects",
                column: "OrganizationId",
                principalTable: "Organizations",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BuildingObjects_Organizations_OrganizationId",
                table: "BuildingObjects");

            migrationBuilder.DropIndex(
                name: "IX_BuildingObjects_OrganizationId",
                table: "BuildingObjects");

            migrationBuilder.DropColumn(
                name: "OrganizationId",
                table: "BuildingObjects");
        }
    }
}
