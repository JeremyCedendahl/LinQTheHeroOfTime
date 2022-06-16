using Microsoft.EntityFrameworkCore.Migrations;

namespace LINQ.Migrations
{
    public partial class Tres : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_StudentKurs_Kurser_KursId",
                table: "StudentKurs");

            migrationBuilder.DropForeignKey(
                name: "FK_StudentKurs_Studenter_StudentID",
                table: "StudentKurs");

            migrationBuilder.DropPrimaryKey(
                name: "PK_StudentKurs",
                table: "StudentKurs");

            migrationBuilder.RenameTable(
                name: "StudentKurs",
                newName: "StudentKurser");

            migrationBuilder.RenameIndex(
                name: "IX_StudentKurs_StudentID",
                table: "StudentKurser",
                newName: "IX_StudentKurser_StudentID");

            migrationBuilder.RenameIndex(
                name: "IX_StudentKurs_KursId",
                table: "StudentKurser",
                newName: "IX_StudentKurser_KursId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_StudentKurser",
                table: "StudentKurser",
                column: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_StudentKurser_Kurser_KursId",
                table: "StudentKurser",
                column: "KursId",
                principalTable: "Kurser",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_StudentKurser_Studenter_StudentID",
                table: "StudentKurser",
                column: "StudentID",
                principalTable: "Studenter",
                principalColumn: "StudentID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_StudentKurser_Kurser_KursId",
                table: "StudentKurser");

            migrationBuilder.DropForeignKey(
                name: "FK_StudentKurser_Studenter_StudentID",
                table: "StudentKurser");

            migrationBuilder.DropPrimaryKey(
                name: "PK_StudentKurser",
                table: "StudentKurser");

            migrationBuilder.RenameTable(
                name: "StudentKurser",
                newName: "StudentKurs");

            migrationBuilder.RenameIndex(
                name: "IX_StudentKurser_StudentID",
                table: "StudentKurs",
                newName: "IX_StudentKurs_StudentID");

            migrationBuilder.RenameIndex(
                name: "IX_StudentKurser_KursId",
                table: "StudentKurs",
                newName: "IX_StudentKurs_KursId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_StudentKurs",
                table: "StudentKurs",
                column: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_StudentKurs_Kurser_KursId",
                table: "StudentKurs",
                column: "KursId",
                principalTable: "Kurser",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_StudentKurs_Studenter_StudentID",
                table: "StudentKurs",
                column: "StudentID",
                principalTable: "Studenter",
                principalColumn: "StudentID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
