using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MYCOMBIN.Migrations
{
    /// <inheritdoc />
    public partial class personaTable5 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Personas",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Description",
                table: "Personas");
        }
    }
}
