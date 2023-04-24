using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace BuildingProgram.Context.Migrations
{
    public partial class AddLandTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Organizations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    OrganizationName = table.Column<string>(type: "text", nullable: false),
                    DirectorName = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Organizations", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Lands",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Square = table.Column<double>(type: "double precision", nullable: false),
                    SellPrice = table.Column<decimal>(type: "numeric", nullable: false),
                    BuyPrice = table.Column<decimal>(type: "numeric", nullable: false),
                    CadastralNumber = table.Column<string>(type: "text", nullable: false),
                    IsSold = table.Column<bool>(type: "boolean", nullable: false),
                    LandType = table.Column<int>(type: "integer", nullable: true),
                    SellerId = table.Column<int>(type: "integer", nullable: false),
                    BuyerId = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Lands", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Lands_Organizations_BuyerId",
                        column: x => x.BuyerId,
                        principalTable: "Organizations",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Lands_Organizations_SellerId",
                        column: x => x.SellerId,
                        principalTable: "Organizations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Lands_BuyerId",
                table: "Lands",
                column: "BuyerId");

            migrationBuilder.CreateIndex(
                name: "IX_Lands_SellerId",
                table: "Lands",
                column: "SellerId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Lands");

            migrationBuilder.DropTable(
                name: "Organizations");
        }
    }
}
