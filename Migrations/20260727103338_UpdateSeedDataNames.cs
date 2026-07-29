using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LMSystem.Migrations
{
    /// <inheritdoc />
    public partial class UpdateSeedDataNames : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Books13",
                keyColumn: "BookId",
                keyValue: 1,
                column: "Author",
                value: "Sunil Kumar and Rajesh Tiwari");

            migrationBuilder.UpdateData(
                table: "Books13",
                keyColumn: "BookId",
                keyValue: 2,
                column: "Author",
                value: "Sanjay Mishra");

            migrationBuilder.UpdateData(
                table: "Librarians",
                keyColumn: "LibrarianId",
                keyValue: 1,
                column: "Name",
                value: "Priya Sharma");

            migrationBuilder.UpdateData(
                table: "Librarians",
                keyColumn: "LibrarianId",
                keyValue: 2,
                column: "Name",
                value: "Rahul Verma");

            migrationBuilder.UpdateData(
                table: "Librarians",
                keyColumn: "LibrarianId",
                keyValue: 3,
                column: "Name",
                value: "Amit Patel");

            migrationBuilder.UpdateData(
                table: "Librarians",
                keyColumn: "LibrarianId",
                keyValue: 4,
                column: "Name",
                value: "Neha Gupta");

            migrationBuilder.UpdateData(
                table: "Librarians",
                keyColumn: "LibrarianId",
                keyValue: 5,
                column: "Name",
                value: "Vikram Singh");

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1,
                columns: new[] { "Email", "StudentName" },
                values: new object[] { "ananya.i@email.com", "Ananya Iyer" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2,
                columns: new[] { "Email", "StudentName" },
                values: new object[] { "rohan.k@email.com", "Rohan Kapoor" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 3,
                columns: new[] { "Email", "StudentName" },
                values: new object[] { "arjun.d@email.com", "Arjun Das" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 4,
                columns: new[] { "Email", "StudentName" },
                values: new object[] { "divya.r@email.com", "Divya Rao" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 5,
                columns: new[] { "Email", "StudentName" },
                values: new object[] { "aditya.j@email.com", "Aditya Joshi" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Books13",
                keyColumn: "BookId",
                keyValue: 1,
                column: "Author",
                value: "Andrew Hunt and David Thomas");

            migrationBuilder.UpdateData(
                table: "Books13",
                keyColumn: "BookId",
                keyValue: 2,
                column: "Author",
                value: "Robert C. Martin");

            migrationBuilder.UpdateData(
                table: "Librarians",
                keyColumn: "LibrarianId",
                keyValue: 1,
                column: "Name",
                value: "Sarah Connor");

            migrationBuilder.UpdateData(
                table: "Librarians",
                keyColumn: "LibrarianId",
                keyValue: 2,
                column: "Name",
                value: "John Doe");

            migrationBuilder.UpdateData(
                table: "Librarians",
                keyColumn: "LibrarianId",
                keyValue: 3,
                column: "Name",
                value: "Michael Scott");

            migrationBuilder.UpdateData(
                table: "Librarians",
                keyColumn: "LibrarianId",
                keyValue: 4,
                column: "Name",
                value: "Ellen Ripley");

            migrationBuilder.UpdateData(
                table: "Librarians",
                keyColumn: "LibrarianId",
                keyValue: 5,
                column: "Name",
                value: "James Bond");

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1,
                columns: new[] { "Email", "StudentName" },
                values: new object[] { "alice.j@email.com", "Alice Johnson" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2,
                columns: new[] { "Email", "StudentName" },
                values: new object[] { "bob.smith@email.com", "Bob Smith" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 3,
                columns: new[] { "Email", "StudentName" },
                values: new object[] { "charlie.b@email.com", "Charlie Brown" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 4,
                columns: new[] { "Email", "StudentName" },
                values: new object[] { "diana.p@email.com", "Diana Prince" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 5,
                columns: new[] { "Email", "StudentName" },
                values: new object[] { "evan.w@email.com", "Evan Wright" });
        }
    }
}
