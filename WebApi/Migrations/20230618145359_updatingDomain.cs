using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace library_as.Migrations
{
    /// <inheritdoc />
    public partial class updatingDomain : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Age",
                table: "Books");

            migrationBuilder.DropColumn(
                name: "Cpf",
                table: "Books");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "Books");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Age",
                table: "Books",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Cpf",
                table: "Books",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Books",
                type: "TEXT",
                nullable: true);
        }
    }
}
