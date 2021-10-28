using Microsoft.EntityFrameworkCore.Migrations;

namespace TBC.Migrations
{
    public partial class fix : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "IdNumber",
                table: "Students",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "IdNumber",
                table: "Students",
                type: "int",
                nullable: false,
                oldClrType: typeof(string));
        }
    }
}
