using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Labb4___Rest_API.Migrations
{
    /// <inheritdoc />
    public partial class Modifieddataandmodels : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "PersonHobby",
                keyColumn: "PersonHobbyID",
                keyValue: 10,
                column: "LinkID",
                value: 5);

            migrationBuilder.UpdateData(
                table: "PersonHobby",
                keyColumn: "PersonHobbyID",
                keyValue: 12,
                column: "LinkID",
                value: 8);

            migrationBuilder.UpdateData(
                table: "PersonHobby",
                keyColumn: "PersonHobbyID",
                keyValue: 14,
                column: "LinkID",
                value: 2);

            migrationBuilder.UpdateData(
                table: "PersonHobby",
                keyColumn: "PersonHobbyID",
                keyValue: 15,
                column: "LinkID",
                value: 9);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "PersonHobby",
                keyColumn: "PersonHobbyID",
                keyValue: 10,
                column: "LinkID",
                value: 1);

            migrationBuilder.UpdateData(
                table: "PersonHobby",
                keyColumn: "PersonHobbyID",
                keyValue: 12,
                column: "LinkID",
                value: 1);

            migrationBuilder.UpdateData(
                table: "PersonHobby",
                keyColumn: "PersonHobbyID",
                keyValue: 14,
                column: "LinkID",
                value: 6);

            migrationBuilder.UpdateData(
                table: "PersonHobby",
                keyColumn: "PersonHobbyID",
                keyValue: 15,
                column: "LinkID",
                value: 6);
        }
    }
}
