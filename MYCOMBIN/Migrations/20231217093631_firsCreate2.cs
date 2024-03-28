using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MYCOMBIN.Migrations
{
    /// <inheritdoc />
    public partial class firsCreate2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsActive2",
                table: "UserInfos",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsActive2",
                table: "UserInfos");
        }
    }
}
