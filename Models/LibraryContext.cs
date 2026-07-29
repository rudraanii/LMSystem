using Microsoft.EntityFrameworkCore;

namespace LMSystem.Models
{
    public class LibraryContext : DbContext
    {
        public LibraryContext(DbContextOptions<LibraryContext> options) : base(options)
        {
        }

        public DbSet<Book> Books13 { get; set; }
        public DbSet<BorrowRecord> BorrowRecords13 { get; set; }
        public DbSet<StudentModel> Students { get; set; }
        public DbSet<LibrarianModel> Librarians { get; set; }
        public DbSet<Publication> Publications { get; set; }
        public DbSet<LoginModel> logintab { get; set; }

        // Seed initial data
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Book>().HasData(
                new Book
                {
                    BookId = 1,
                    Title = "The Pragmatic Programmer",
                    Author = "Sunil Kumar and Rajesh Tiwari",
                    ISBN = "978-0201616224",
                    PublishedDate = new DateTime(2021, 10, 30),
                    IsAvailable = true
                },
                new Book
                {
                    BookId = 2,
                    Title = "Design Pattern using C#",
                    Author = "Sanjay Mishra",
                    ISBN = "978-0132350884",
                    PublishedDate = new DateTime(2023, 8, 1),
                    IsAvailable = true
                },
                new Book
                {
                    BookId = 3,
                    Title = "Mastering ASP.NET Core",
                    Author = "Pranaya Kumar Rout",
                    ISBN = "978-0451616235",
                    PublishedDate = new DateTime(2022, 11, 22),
                    IsAvailable = true
                },
                new Book
                {
                    BookId = 4,
                    Title = "SQL Server with DBA",
                    Author = "Rakesh Kumat",
                    ISBN = "978-4562350123",
                    PublishedDate = new DateTime(2020, 8, 15),
                    IsAvailable = true
                }
            );

            // Adding Sample Newspapers (Type = 0)
            modelBuilder.Entity<Publication>().HasData(
                new Publication { Id = 1, Title = "The Daily Times", Publisher = "Global Media Group", PublishedDate = new DateTime(2026, 7, 22), Type = PublicationType.Newspaper, IsAvailable = true },
                new Publication { Id = 2, Title = "Financial Chronicle", Publisher = "WallSt Press", PublishedDate = new DateTime(2026, 7, 21), Type = PublicationType.Newspaper, IsAvailable = true },
                new Publication { Id = 3, Title = "Tech Weekly News", Publisher = "Silicon Valley Pubs", PublishedDate = new DateTime(2026, 7, 20), Type = PublicationType.Newspaper, IsAvailable = true },
                new Publication { Id = 4, Title = "Metro Morning Post", Publisher = "City Press House", PublishedDate = new DateTime(2026, 7, 22), Type = PublicationType.Newspaper, IsAvailable = true },
                new Publication { Id = 5, Title = "Saturday Sports Herald", Publisher = "Global Media Group", PublishedDate = new DateTime(2026, 7, 18), Type = PublicationType.Newspaper, IsAvailable = false }
            );

            // Adding Sample Magazines (Type = 1)
            modelBuilder.Entity<Publication>().HasData(
                new Publication { Id = 6, Title = "National Geographic Vol 45", Publisher = "NatGeo Society", PublishedDate = new DateTime(2026, 7, 1), Type = PublicationType.Magazine, IsAvailable = true },
                new Publication { Id = 7, Title = "Vogue Fashion Summer", Publisher = "Condé Nast", PublishedDate = new DateTime(2026, 6, 15), Type = PublicationType.Magazine, IsAvailable = true },
                new Publication { Id = 8, Title = "Forbes Business 30 Under 30", Publisher = "Forbes Media", PublishedDate = new DateTime(2026, 7, 10), Type = PublicationType.Magazine, IsAvailable = false },
                new Publication { Id = 9, Title = "PC Gamer Ultimate", Publisher = "Future US", PublishedDate = new DateTime(2026, 7, 5), Type = PublicationType.Magazine, IsAvailable = true },
                new Publication { Id = 10, Title = "Scientific American", Publisher = "Springer Nature", PublishedDate = new DateTime(2026, 6, 28), Type = PublicationType.Magazine, IsAvailable = true }
            );

            modelBuilder.Entity<LibrarianModel>().HasData(
                new LibrarianModel { LibrarianId = 1, Name = "Priya Sharma", Age = 34, Phone = "555-0201" },
                new LibrarianModel { LibrarianId = 2, Name = "Rahul Verma", Age = 28, Phone = "555-0202" },
                new LibrarianModel { LibrarianId = 3, Name = "Amit Patel", Age = 45, Phone = "555-0203" },
                new LibrarianModel { LibrarianId = 4, Name = "Neha Gupta", Age = 39, Phone = "555-0204" },
                new LibrarianModel { LibrarianId = 5, Name = "Vikram Singh", Age = 40, Phone = "555-0205" }
            );

            // Adding Sample Students
            modelBuilder.Entity<StudentModel>().HasData(
                new StudentModel { StudentId = 1, StudentName = "Ananya Iyer", Email = "ananya.i@email.com", Phone = "555-0101" },
                new StudentModel { StudentId = 2, StudentName = "Rohan Kapoor", Email = "rohan.k@email.com", Phone = "555-0102" },
                new StudentModel { StudentId = 3, StudentName = "Arjun Das", Email = "arjun.d@email.com", Phone = "555-0103" },
                new StudentModel { StudentId = 4, StudentName = "Divya Rao", Email = "divya.r@email.com", Phone = "555-0104" },
                new StudentModel { StudentId = 5, StudentName = "Aditya Joshi", Email = "aditya.j@email.com", Phone = "555-0105" }
            );

            modelBuilder.Entity<LoginModel>().HasData(
                new LoginModel { id = 1, username = "admin", password = "12345" },
                new LoginModel { id = 2, username = "mycodingproject", password = "myc546" },
                new LoginModel { id = 3, username = "my", password = "myc" }
            );
        }
    }
}
