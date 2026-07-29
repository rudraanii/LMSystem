using LMSystem.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace LMSystem.Controllers
{
    public class DashboardController : Controller
    {
        private readonly LibraryContext _context;

        public DashboardController(LibraryContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            var model = new DashboardModel
            {
                TotalStudents = await _context.Students.CountAsync(),
                TotalBooks = await _context.Books13.CountAsync(),
                TotalLibrarians = await _context.Librarians.CountAsync(),
                TotalBorrowings = await _context.BorrowRecords13.CountAsync(),
                TotalPublications = await _context.Publications.CountAsync()
            };

            // Chart Data Prep
            ViewBag.AvailableBooks = await _context.Books13.CountAsync(b => b.IsAvailable);
            ViewBag.BorrowedBooks = await _context.Books13.CountAsync(b => !b.IsAvailable);

            ViewBag.Newspapers = await _context.Publications.CountAsync(p => p.Type == PublicationType.Newspaper);
            ViewBag.Magazines = await _context.Publications.CountAsync(p => p.Type == PublicationType.Magazine);

            return View(model);
        }
    }
}
