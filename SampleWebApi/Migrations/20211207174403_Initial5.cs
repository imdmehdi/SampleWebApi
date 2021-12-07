using Microsoft.EntityFrameworkCore.Migrations;

namespace SampleWebApi.Migrations
{
    public partial class Initial5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_StudentSubjects_Students_StudId",
                table: "StudentSubjects");

            migrationBuilder.DropIndex(
                name: "IX_StudentSubjects_StudId",
                table: "StudentSubjects");

            migrationBuilder.DropColumn(
                name: "StudentId",
                table: "StudentSubjects");

            migrationBuilder.AlterColumn<int>(
                name: "StudId",
                table: "StudentSubjects",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "StudentsId",
                table: "StudentSubjects",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_StudentSubjects_StudentsId",
                table: "StudentSubjects",
                column: "StudentsId");

            migrationBuilder.AddForeignKey(
                name: "FK_StudentSubjects_Students_StudentsId",
                table: "StudentSubjects",
                column: "StudentsId",
                principalTable: "Students",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_StudentSubjects_Students_StudentsId",
                table: "StudentSubjects");

            migrationBuilder.DropIndex(
                name: "IX_StudentSubjects_StudentsId",
                table: "StudentSubjects");

            migrationBuilder.DropColumn(
                name: "StudentsId",
                table: "StudentSubjects");

            migrationBuilder.AlterColumn<int>(
                name: "StudId",
                table: "StudentSubjects",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "StudentId",
                table: "StudentSubjects",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_StudentSubjects_StudId",
                table: "StudentSubjects",
                column: "StudId");

            migrationBuilder.AddForeignKey(
                name: "FK_StudentSubjects_Students_StudId",
                table: "StudentSubjects",
                column: "StudId",
                principalTable: "Students",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
