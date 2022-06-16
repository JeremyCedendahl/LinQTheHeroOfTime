using Microsoft.EntityFrameworkCore.Migrations;

namespace LINQ.Migrations
{
    public partial class Dos : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "Teachers");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "Teachers");

            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "Studenter");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "Studenter");

            migrationBuilder.AddColumn<string>(
                name: "FullName",
                table: "Teachers",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "FullName",
                table: "Studenter",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FullName",
                table: "Teachers");

            migrationBuilder.DropColumn(
                name: "FullName",
                table: "Studenter");

            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "Teachers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "Teachers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "Studenter",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "Studenter",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
