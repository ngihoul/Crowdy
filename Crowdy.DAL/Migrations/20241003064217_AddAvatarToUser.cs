using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Crowdy.DAL.Migrations
{
    /// <inheritdoc />
    public partial class AddAvatarToUser : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Avatar",
                table: "user",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");  
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Avatar",
                table: "user");
        }
    }
}
