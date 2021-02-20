using Microsoft.EntityFrameworkCore.Migrations;

namespace HomeWork9.Migrations
{
    public partial class CreateUniqIndexAuthor : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "AuthorName",
                table: "Author",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "Author_Index",
                table: "Author",
                columns: new[] { "AuthorCode", "AuthorName" },
                unique: true,
                filter: "[AuthorName] IS NOT NULL");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "Author_Index",
                table: "Author");

            migrationBuilder.AlterColumn<string>(
                name: "AuthorName",
                table: "Author",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);
        }
    }
}
