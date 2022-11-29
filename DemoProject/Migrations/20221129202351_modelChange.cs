using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DemoProject.Migrations
{
    /// <inheritdoc />
    public partial class modelChange : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AccountId",
                table: "Owners");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AccountId",
                table: "Owners",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
