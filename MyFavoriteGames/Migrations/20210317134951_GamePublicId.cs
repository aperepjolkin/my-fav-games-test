using Microsoft.EntityFrameworkCore.Migrations;

namespace MyFavoriteGames.Migrations
{
    public partial class GamePublicId : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "PublicGameID",
                table: "Games",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PublicGameID",
                table: "Games");
        }
    }
}
