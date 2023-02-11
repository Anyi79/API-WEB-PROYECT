using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data.Migrations
{
    /// <inheritdoc />
    public partial class Second : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_UserItem_OwnerUserId",
                table: "Products");

            migrationBuilder.DropTable(
                name: "UserItem");

            migrationBuilder.DropIndex(
                name: "IX_Products_OwnerUserId",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "OwnerUserId",
                table: "Products");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "OwnerUserId",
                table: "Products",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "UserItem",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ExampleGitSasasa = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IdRol = table.Column<int>(type: "int", nullable: false),
                    IdWeb = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    InsertDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserItem", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Products_OwnerUserId",
                table: "Products",
                column: "OwnerUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_UserItem_OwnerUserId",
                table: "Products",
                column: "OwnerUserId",
                principalTable: "UserItem",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
