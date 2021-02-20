using Microsoft.EntityFrameworkCore.Migrations;

namespace HomeWork9.Migrations
{
    public partial class Createdatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Author",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AuthorCode = table.Column<int>(type: "int", nullable: false),
                    AuthorName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Author", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Stories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AuthorId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Stories", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Stories_Author_AuthorId",
                        column: x => x.AuthorId,
                        principalTable: "Author",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Characters",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Gender = table.Column<bool>(type: "bit", nullable: false),
                    Age = table.Column<int>(type: "int", nullable: false),
                    StoryId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Characters", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Characters_Stories_StoryId",
                        column: x => x.StoryId,
                        principalTable: "Stories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Author",
                columns: new[] { "Id", "AuthorCode", "AuthorName" },
                values: new object[] { 1, 1, "Vasya Pupkin" });

            migrationBuilder.InsertData(
                table: "Author",
                columns: new[] { "Id", "AuthorCode", "AuthorName" },
                values: new object[] { 2, 2, "Ivan Ivanov" });

            migrationBuilder.InsertData(
                table: "Author",
                columns: new[] { "Id", "AuthorCode", "AuthorName" },
                values: new object[] { 3, 3, "Petrovich" });

            migrationBuilder.InsertData(
                table: "Stories",
                columns: new[] { "Id", "AuthorId", "Description", "Name" },
                values: new object[] { 1, 1, "", "Foundation" });

            migrationBuilder.InsertData(
                table: "Stories",
                columns: new[] { "Id", "AuthorId", "Description", "Name" },
                values: new object[] { 2, 2, "", "LOTR" });

            migrationBuilder.InsertData(
                table: "Stories",
                columns: new[] { "Id", "AuthorId", "Description", "Name" },
                values: new object[] { 3, 3, "", "Hyperion" });

            migrationBuilder.InsertData(
                table: "Characters",
                columns: new[] { "Id", "Age", "FirstName", "Gender", "LastName", "StoryId" },
                values: new object[] { 1, 35, "Harry", true, "Seldon", 1 });

            migrationBuilder.InsertData(
                table: "Characters",
                columns: new[] { "Id", "Age", "FirstName", "Gender", "LastName", "StoryId" },
                values: new object[] { 2, 2700, "Arven", false, "Undomiel", 2 });

            migrationBuilder.InsertData(
                table: "Characters",
                columns: new[] { "Id", "Age", "FirstName", "Gender", "LastName", "StoryId" },
                values: new object[] { 3, 14, "Finn", true, "Mertens", 3 });

            migrationBuilder.CreateIndex(
                name: "IX_Characters_StoryId",
                table: "Characters",
                column: "StoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Stories_AuthorId",
                table: "Stories",
                column: "AuthorId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Characters");

            migrationBuilder.DropTable(
                name: "Stories");

            migrationBuilder.DropTable(
                name: "Author");
        }
    }
}
