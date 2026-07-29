using LMSystem.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace LMSystem.Controllers
{
    public class LoginController : Controller
    {
        private readonly LibraryContext _context;

        public LoginController(LibraryContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Verify(LoginModel usr)
        {
            if (string.IsNullOrEmpty(usr.username) || string.IsNullOrEmpty(usr.password))
            {
                ViewBag.message = "Username and password are required.";
                return View("Index");
            }

            var user = await _context.logintab
                .FirstOrDefaultAsync(u => u.username == usr.username && u.password == usr.password);

            if (user != null)
            {
                TempData["message"] = "Login Success";
                return RedirectToAction("Index", "Dashboard");
            }
            else
            {
                ViewBag.message = "Login Failed";
                return View("Index");
            }
        }
    }
}
