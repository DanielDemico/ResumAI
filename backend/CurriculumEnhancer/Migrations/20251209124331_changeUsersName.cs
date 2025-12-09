using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CurriculumEnhancer.Migrations
{
    /// <inheritdoc />
    public partial class changeUsersName : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_BancoDeDados",
                table: "BancoDeDados");

            migrationBuilder.RenameTable(
                name: "BancoDeDados",
                newName: "Users");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Users",
                table: "Users",
                column: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Users",
                table: "Users");

            migrationBuilder.RenameTable(
                name: "Users",
                newName: "BancoDeDados");

            migrationBuilder.AddPrimaryKey(
                name: "PK_BancoDeDados",
                table: "BancoDeDados",
                column: "Id");
        }
    }
}
