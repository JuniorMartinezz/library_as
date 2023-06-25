using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace library_as.Migrations
{
    /// <inheritdoc />
    public partial class AddingTypes5 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "authors",
                table: "books");

            migrationBuilder.AddColumn<int>(
                name: "BookId",
                table: "Authors",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Authors_BookId",
                table: "Authors",
                column: "BookId");

            migrationBuilder.AddForeignKey(
                name: "FK_Authors_books_BookId",
                table: "Authors",
                column: "BookId",
                principalTable: "books",
                principalColumn: "id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Authors_books_BookId",
                table: "Authors");

            migrationBuilder.DropIndex(
                name: "IX_Authors_BookId",
                table: "Authors");

            migrationBuilder.DropColumn(
                name: "BookId",
                table: "Authors");

            migrationBuilder.AddColumn<byte[]>(
                name: "authors",
                table: "books",
                type: "Author",
                nullable: false,
                defaultValue: new byte[0]);
        }
    }
}
