using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Labb4___Rest_API.Migrations
{
    /// <inheritdoc />
    public partial class DatabaseConnectionRework : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_PersonHobby_HobbyID",
                table: "PersonHobby",
                column: "HobbyID");

            migrationBuilder.CreateIndex(
                name: "IX_PersonHobby_LinkID",
                table: "PersonHobby",
                column: "LinkID");

            migrationBuilder.CreateIndex(
                name: "IX_PersonHobby_PersonID",
                table: "PersonHobby",
                column: "PersonID");

            migrationBuilder.AddForeignKey(
                name: "FK_PersonHobby_Hobby_HobbyID",
                table: "PersonHobby",
                column: "HobbyID",
                principalTable: "Hobby",
                principalColumn: "HobbyID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PersonHobby_Link_LinkID",
                table: "PersonHobby",
                column: "LinkID",
                principalTable: "Link",
                principalColumn: "LinkID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PersonHobby_Person_PersonID",
                table: "PersonHobby",
                column: "PersonID",
                principalTable: "Person",
                principalColumn: "PersonID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PersonHobby_Hobby_HobbyID",
                table: "PersonHobby");

            migrationBuilder.DropForeignKey(
                name: "FK_PersonHobby_Link_LinkID",
                table: "PersonHobby");

            migrationBuilder.DropForeignKey(
                name: "FK_PersonHobby_Person_PersonID",
                table: "PersonHobby");

            migrationBuilder.DropIndex(
                name: "IX_PersonHobby_HobbyID",
                table: "PersonHobby");

            migrationBuilder.DropIndex(
                name: "IX_PersonHobby_LinkID",
                table: "PersonHobby");

            migrationBuilder.DropIndex(
                name: "IX_PersonHobby_PersonID",
                table: "PersonHobby");
        }
    }
}
