using Microsoft.EntityFrameworkCore.Migrations;

namespace API.Data.Migrations
{
    public partial class Member : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "IsMan",
                table: "Photos",
                newName: "IsMain");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "IsMain",
                table: "Photos",
                newName: "IsMan");
        }
    }
}
