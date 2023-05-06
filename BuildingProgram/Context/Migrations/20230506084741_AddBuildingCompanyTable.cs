using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace BuildingProgram.Context.Migrations
{
    public partial class AddBuildingCompanyTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "BuildingCompanyId",
                table: "BuildingObjects",
                type: "integer",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "BuildingCompanies",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BuildingCompanies", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_BuildingObjects_BuildingCompanyId",
                table: "BuildingObjects",
                column: "BuildingCompanyId");

            migrationBuilder.AddForeignKey(
                name: "FK_BuildingObjects_BuildingCompanies_BuildingCompanyId",
                table: "BuildingObjects",
                column: "BuildingCompanyId",
                principalTable: "BuildingCompanies",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BuildingObjects_BuildingCompanies_BuildingCompanyId",
                table: "BuildingObjects");

            migrationBuilder.DropTable(
                name: "BuildingCompanies");

            migrationBuilder.DropIndex(
                name: "IX_BuildingObjects_BuildingCompanyId",
                table: "BuildingObjects");

            migrationBuilder.DropColumn(
                name: "BuildingCompanyId",
                table: "BuildingObjects");
        }
    }
}
