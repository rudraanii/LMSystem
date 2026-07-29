using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace LMSystem.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Books13",
                columns: table => new
                {
                    BookId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Title = table.Column<string>(type: "TEXT", maxLength: 100, nullable: false),
                    Author = table.Column<string>(type: "TEXT", maxLength: 100, nullable: false),
                    ISBN = table.Column<string>(type: "TEXT", nullable: false),
                    PublishedDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    IsAvailable = table.Column<bool>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Books13", x => x.BookId);
                });

            migrationBuilder.CreateTable(
                name: "Librarians",
                columns: table => new
                {
                    LibrarianId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: true),
                    Age = table.Column<int>(type: "INTEGER", nullable: false),
                    Phone = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Librarians", x => x.LibrarianId);
                });

            migrationBuilder.CreateTable(
                name: "logintab",
                columns: table => new
                {
                    id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    username = table.Column<string>(type: "TEXT", nullable: true),
                    password = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_logintab", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Publications",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Title = table.Column<string>(type: "TEXT", maxLength: 100, nullable: false),
                    Publisher = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false),
                    PublishedDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Type = table.Column<int>(type: "INTEGER", nullable: false),
                    IsAvailable = table.Column<bool>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Publications", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Students",
                columns: table => new
                {
                    StudentId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    StudentName = table.Column<string>(type: "TEXT", nullable: true),
                    Email = table.Column<string>(type: "TEXT", nullable: true),
                    Phone = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Students", x => x.StudentId);
                });

            migrationBuilder.CreateTable(
                name: "BorrowRecords13",
                columns: table => new
                {
                    BorrowRecordId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    BookId = table.Column<int>(type: "INTEGER", nullable: false),
                    BorrowerName = table.Column<string>(type: "TEXT", nullable: false),
                    BorrowerEmail = table.Column<string>(type: "TEXT", nullable: false),
                    Phone = table.Column<string>(type: "TEXT", nullable: false),
                    BorrowDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    ReturnDate = table.Column<DateTime>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BorrowRecords13", x => x.BorrowRecordId);
                    table.ForeignKey(
                        name: "FK_BorrowRecords13_Books13_BookId",
                        column: x => x.BookId,
                        principalTable: "Books13",
                        principalColumn: "BookId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Books13",
                columns: new[] { "BookId", "Author", "ISBN", "IsAvailable", "PublishedDate", "Title" },
                values: new object[,]
                {
                    { 1, "Andrew Hunt and David Thomas", "978-0201616224", true, new DateTime(2021, 10, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Pragmatic Programmer" },
                    { 2, "Robert C. Martin", "978-0132350884", true, new DateTime(2023, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Design Pattern using C#" },
                    { 3, "Pranaya Kumar Rout", "978-0451616235", true, new DateTime(2022, 11, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mastering ASP.NET Core" },
                    { 4, "Rakesh Kumat", "978-4562350123", true, new DateTime(2020, 8, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "SQL Server with DBA" }
                });

            migrationBuilder.InsertData(
                table: "Librarians",
                columns: new[] { "LibrarianId", "Age", "Name", "Phone" },
                values: new object[,]
                {
                    { 1, 34, "Sarah Connor", "555-0201" },
                    { 2, 28, "John Doe", "555-0202" },
                    { 3, 45, "Michael Scott", "555-0203" },
                    { 4, 39, "Ellen Ripley", "555-0204" },
                    { 5, 40, "James Bond", "555-0205" }
                });

            migrationBuilder.InsertData(
                table: "Publications",
                columns: new[] { "Id", "IsAvailable", "PublishedDate", "Publisher", "Title", "Type" },
                values: new object[,]
                {
                    { 1, true, new DateTime(2026, 7, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Global Media Group", "The Daily Times", 0 },
                    { 2, true, new DateTime(2026, 7, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "WallSt Press", "Financial Chronicle", 0 },
                    { 3, true, new DateTime(2026, 7, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Silicon Valley Pubs", "Tech Weekly News", 0 },
                    { 4, true, new DateTime(2026, 7, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "City Press House", "Metro Morning Post", 0 },
                    { 5, false, new DateTime(2026, 7, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Global Media Group", "Saturday Sports Herald", 0 },
                    { 6, true, new DateTime(2026, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "NatGeo Society", "National Geographic Vol 45", 1 },
                    { 7, true, new DateTime(2026, 6, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Condé Nast", "Vogue Fashion Summer", 1 },
                    { 8, false, new DateTime(2026, 7, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Forbes Media", "Forbes Business 30 Under 30", 1 },
                    { 9, true, new DateTime(2026, 7, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Future US", "PC Gamer Ultimate", 1 },
                    { 10, true, new DateTime(2026, 6, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Springer Nature", "Scientific American", 1 }
                });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "StudentId", "Email", "Phone", "StudentName" },
                values: new object[,]
                {
                    { 1, "alice.j@email.com", "555-0101", "Alice Johnson" },
                    { 2, "bob.smith@email.com", "555-0102", "Bob Smith" },
                    { 3, "charlie.b@email.com", "555-0103", "Charlie Brown" },
                    { 4, "diana.p@email.com", "555-0104", "Diana Prince" },
                    { 5, "evan.w@email.com", "555-0105", "Evan Wright" }
                });

            migrationBuilder.InsertData(
                table: "logintab",
                columns: new[] { "id", "password", "username" },
                values: new object[,]
                {
                    { 1, "12345", "admin" },
                    { 2, "myc546", "mycodingproject" },
                    { 3, "myc", "my" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_BorrowRecords13_BookId",
                table: "BorrowRecords13",
                column: "BookId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BorrowRecords13");

            migrationBuilder.DropTable(
                name: "Librarians");

            migrationBuilder.DropTable(
                name: "logintab");

            migrationBuilder.DropTable(
                name: "Publications");

            migrationBuilder.DropTable(
                name: "Students");

            migrationBuilder.DropTable(
                name: "Books13");
        }
    }
}
