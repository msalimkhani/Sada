using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Sada.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class addUserIdToSchool : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "Schools",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Schools");
        }
    }
}
