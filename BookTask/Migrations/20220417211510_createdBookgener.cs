using Microsoft.EntityFrameworkCore.Migrations;

namespace BookTask.Migrations
{
    public partial class createdBookgener : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_genres",
                table: "genres");

            migrationBuilder.DropPrimaryKey(
                name: "PK_books",
                table: "books");

            migrationBuilder.RenameTable(
                name: "genres",
                newName: "Genres");

            migrationBuilder.RenameTable(
                name: "books",
                newName: "Books");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Genres",
                table: "Genres",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Books",
                table: "Books",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "BookGeners",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BookId = table.Column<int>(nullable: false),
                    GenerId = table.Column<int>(nullable: false),
                    genreId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BookGeners", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BookGeners_Books_BookId",
                        column: x => x.BookId,
                        principalTable: "Books",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BookGeners_Genres_genreId",
                        column: x => x.genreId,
                        principalTable: "Genres",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_BookGeners_BookId",
                table: "BookGeners",
                column: "BookId");

            migrationBuilder.CreateIndex(
                name: "IX_BookGeners_genreId",
                table: "BookGeners",
                column: "genreId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BookGeners");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Genres",
                table: "Genres");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Books",
                table: "Books");

            migrationBuilder.RenameTable(
                name: "Genres",
                newName: "genres");

            migrationBuilder.RenameTable(
                name: "Books",
                newName: "books");

            migrationBuilder.AddPrimaryKey(
                name: "PK_genres",
                table: "genres",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_books",
                table: "books",
                column: "Id");
        }
    }
}
