using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Labb4___Rest_API.Migrations
{
    /// <inheritdoc />
    public partial class FirstCreation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "PersonHobby",
                keyColumn: "PersonHobbyID",
                keyValue: 10,
                columns: new[] { "HobbyID", "LinkID", "PersonID" },
                values: new object[] { 3, 1, 1 });

            migrationBuilder.InsertData(
                table: "PersonHobby",
                columns: new[] { "PersonHobbyID", "HobbyID", "LinkID", "PersonID" },
                values: new object[,]
                {
                    { 11, 1, 4, 4 },
                    { 12, 4, 1, 1 },
                    { 13, 2, 8, 8 },
                    { 14, 3, 6, 6 },
                    { 15, 1, 6, 6 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "PersonHobby",
                keyColumn: "PersonHobbyID",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "PersonHobby",
                keyColumn: "PersonHobbyID",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "PersonHobby",
                keyColumn: "PersonHobbyID",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "PersonHobby",
                keyColumn: "PersonHobbyID",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "PersonHobby",
                keyColumn: "PersonHobbyID",
                keyValue: 15);

            migrationBuilder.UpdateData(
                table: "PersonHobby",
                keyColumn: "PersonHobbyID",
                keyValue: 10,
                columns: new[] { "HobbyID", "LinkID", "PersonID" },
                values: new object[] { 2, 10, 10 });
        }
    }
}
