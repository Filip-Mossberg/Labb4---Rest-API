using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Labb4___Rest_API.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Hobby",
                columns: table => new
                {
                    HobbyID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Hobby", x => x.HobbyID);
                });

            migrationBuilder.CreateTable(
                name: "Link",
                columns: table => new
                {
                    LinkID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LinkName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    URL = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Link", x => x.LinkID);
                });

            migrationBuilder.CreateTable(
                name: "Person",
                columns: table => new
                {
                    PersonID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Phone = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Person", x => x.PersonID);
                });

            migrationBuilder.CreateTable(
                name: "PersonHobby",
                columns: table => new
                {
                    PersonHobbyID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PersonID = table.Column<int>(type: "int", nullable: false),
                    HobbyID = table.Column<int>(type: "int", nullable: false),
                    LinkID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PersonHobby", x => x.PersonHobbyID);
                });

            migrationBuilder.InsertData(
                table: "Hobby",
                columns: new[] { "HobbyID", "Description", "Title" },
                values: new object[,]
                {
                    { 1, "Fishing club", "Fishing" },
                    { 2, "Racing with motorized vehicles.", "Racing" },
                    { 3, "Plant flowers.", "Gardening" },
                    { 4, "Skiing down steep slopes.", "Skiing" }
                });

            migrationBuilder.InsertData(
                table: "Link",
                columns: new[] { "LinkID", "LinkName", "URL" },
                values: new object[,]
                {
                    { 1, "Google", "http://www.google.com" },
                    { 2, "YouTube", "http://www.youtube.com" },
                    { 3, "Facebook", "http://www.facebook.com" },
                    { 4, "Twitter", "http://www.twitter.com" },
                    { 5, "Instagram", "http://www.instagram.com" },
                    { 6, "LinkedIn", "http://www.linkedin.com" },
                    { 7, "Reddit", "http://www.reddit.com" },
                    { 8, "Pinterest", "http://www.pinterest.com" },
                    { 9, "Tumblr", "http://www.tumblr.com" },
                    { 10, "Snapchat", "http://www.snapchat.com" }
                });

            migrationBuilder.InsertData(
                table: "Person",
                columns: new[] { "PersonID", "FirstName", "LastName", "Phone" },
                values: new object[,]
                {
                    { 1, "Arne", "Trampo", 123483723 },
                    { 2, "Börje", "Severinsson", 124383723 },
                    { 3, "Sara", "Palmqvist", 123443723 },
                    { 4, "Reidar", "Folkesson", 123543723 },
                    { 5, "Elina", "Johansson", 125483723 },
                    { 6, "Hans", "Gustavsson", 126383723 },
                    { 7, "Lena", "Karlsson", 127443723 },
                    { 8, "Mikael", "Lindgren", 128543723 },
                    { 9, "Pernilla", "Ekström", 129483723 },
                    { 10, "Oscar", "Nilsson", 130383723 }
                });

            migrationBuilder.InsertData(
                table: "PersonHobby",
                columns: new[] { "PersonHobbyID", "HobbyID", "LinkID", "PersonID" },
                values: new object[,]
                {
                    { 1, 1, 1, 1 },
                    { 2, 2, 2, 2 },
                    { 3, 3, 3, 3 },
                    { 4, 4, 4, 4 },
                    { 5, 1, 5, 5 },
                    { 6, 2, 6, 6 },
                    { 7, 3, 7, 7 },
                    { 8, 4, 8, 8 },
                    { 9, 1, 9, 9 },
                    { 10, 2, 10, 10 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Hobby");

            migrationBuilder.DropTable(
                name: "Link");

            migrationBuilder.DropTable(
                name: "Person");

            migrationBuilder.DropTable(
                name: "PersonHobby");
        }
    }
}
