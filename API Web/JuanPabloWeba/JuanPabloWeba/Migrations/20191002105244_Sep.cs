using Microsoft.EntityFrameworkCore.Migrations;

namespace JuanPabloWeba.Migrations
{
    public partial class Sep : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Games_Categories_CategoriesId",
                table: "Games");

            migrationBuilder.DropIndex(
                name: "IX_Games_CategoriesId",
                table: "Games");

            migrationBuilder.DropColumn(
                name: "CategoriesId",
                table: "Games");

            migrationBuilder.AddColumn<int>(
                name: "CategoryId",
                table: "Games",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Games_CategoryId",
                table: "Games",
                column: "CategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Games_Categories_CategoryId",
                table: "Games",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Games_Categories_CategoryId",
                table: "Games");

            migrationBuilder.DropIndex(
                name: "IX_Games_CategoryId",
                table: "Games");

            migrationBuilder.DropColumn(
                name: "CategoryId",
                table: "Games");

            migrationBuilder.AddColumn<int>(
                name: "CategoriesId",
                table: "Games",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Games_CategoriesId",
                table: "Games",
                column: "CategoriesId");

            migrationBuilder.AddForeignKey(
                name: "FK_Games_Categories_CategoriesId",
                table: "Games",
                column: "CategoriesId",
                principalTable: "Categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
