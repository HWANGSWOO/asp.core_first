using Microsoft.EntityFrameworkCore.Migrations;

namespace App.Migrations
{
    public partial class Note : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "NoteTitle",
                table: "Notes",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "NoteContents",
                table: "Notes",
                nullable: true,
                oldClrType: typeof(string));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "NoteTitle",
                table: "Notes",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "NoteContents",
                table: "Notes",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);
        }
    }
}
