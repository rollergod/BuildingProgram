using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BuildingProgram.Context.Migrations
{
    public partial class DeleteSomeColumns : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BuildingObjects_Organizations_OrganizationId",
                table: "BuildingObjects");

            migrationBuilder.DropForeignKey(
                name: "FK_Lands_Organizations_BuyerId",
                table: "Lands");

            migrationBuilder.DropForeignKey(
                name: "FK_Lands_Organizations_SellerId",
                table: "Lands");

            migrationBuilder.DropIndex(
                name: "IX_Lands_BuyerId",
                table: "Lands");

            migrationBuilder.DropIndex(
                name: "IX_BuildingObjects_OrganizationId",
                table: "BuildingObjects");

            migrationBuilder.DropColumn(
                name: "BuyerId",
                table: "Lands");

            migrationBuilder.DropColumn(
                name: "IsSold",
                table: "Lands");

            migrationBuilder.DropColumn(
                name: "OrganizationId",
                table: "BuildingObjects");

            migrationBuilder.RenameColumn(
                name: "SellerId",
                table: "Lands",
                newName: "OwnerId");

            migrationBuilder.RenameIndex(
                name: "IX_Lands_SellerId",
                table: "Lands",
                newName: "IX_Lands_OwnerId");

            migrationBuilder.AddForeignKey(
                name: "FK_Lands_Organizations_OwnerId",
                table: "Lands",
                column: "OwnerId",
                principalTable: "Organizations",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Lands_Organizations_OwnerId",
                table: "Lands");

            migrationBuilder.RenameColumn(
                name: "OwnerId",
                table: "Lands",
                newName: "SellerId");

            migrationBuilder.RenameIndex(
                name: "IX_Lands_OwnerId",
                table: "Lands",
                newName: "IX_Lands_SellerId");

            migrationBuilder.AddColumn<int>(
                name: "BuyerId",
                table: "Lands",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsSold",
                table: "Lands",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "OrganizationId",
                table: "BuildingObjects",
                type: "integer",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Lands_BuyerId",
                table: "Lands",
                column: "BuyerId");

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

            migrationBuilder.AddForeignKey(
                name: "FK_Lands_Organizations_BuyerId",
                table: "Lands",
                column: "BuyerId",
                principalTable: "Organizations",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Lands_Organizations_SellerId",
                table: "Lands",
                column: "SellerId",
                principalTable: "Organizations",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
