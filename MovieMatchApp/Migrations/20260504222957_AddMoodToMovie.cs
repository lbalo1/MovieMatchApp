using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MovieMatchApp.Migrations
{
    /// <inheritdoc />
    public partial class AddMoodToMovie : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Mood",
                table: "Movies",
                type: "TEXT",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Mood",
                table: "Movies");
        }
    }
}
