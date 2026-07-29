using LMSystem.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace LMSystem.Controllers
{
    public class StudentController : Controller
    {
        private readonly LibraryContext _context;

        public StudentController(LibraryContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index(string? searchTerm, int page = 1)
        {
            var viewModel = new StudentIndexViewModel
            {
                SearchTerm = searchTerm,
                CurrentPage = page < 1 ? 1 : page
            };

            var query = _context.Students.AsQueryable();

            if (!string.IsNullOrEmpty(searchTerm))
            {
                var lowerSearchTerm = searchTerm.ToLower();
                query = query.Where(s => 
                    (s.StudentName != null && s.StudentName.ToLower().Contains(lowerSearchTerm)) ||
                    (s.Email != null && s.Email.ToLower().Contains(lowerSearchTerm)) ||
                    (s.Phone != null && s.Phone.ToLower().Contains(lowerSearchTerm)));
            }

            int totalRecords = await query.CountAsync();
            viewModel.TotalPages = (int)Math.Ceiling((double)totalRecords / viewModel.PageSize);

            if (viewModel.CurrentPage > viewModel.TotalPages && viewModel.TotalPages > 0)
            {
                viewModel.CurrentPage = viewModel.TotalPages;
            }

            viewModel.Students = await query
                .OrderBy(s => s.StudentId)
                .Skip((viewModel.CurrentPage - 1) * viewModel.PageSize)
                .Take(viewModel.PageSize)
                .ToListAsync();

            return View(viewModel);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(StudentModel model)
        {
            if (!ModelState.IsValid)
                return View(model);

            _context.Students.Add(model);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> Edit(int id)
        {
            var student = await _context.Students.FindAsync(id);
            if (student == null) return NotFound();
            return View(student);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(StudentModel model)
        {
            if (!ModelState.IsValid)
                return View(model);

            _context.Students.Update(model);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> Delete(int id)
        {
            var student = await _context.Students.FindAsync(id);
            if (student != null)
            {
                _context.Students.Remove(student);
                await _context.SaveChangesAsync();
            }
            return RedirectToAction("Index");
        }
    }
}
