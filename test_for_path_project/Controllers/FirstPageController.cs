using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using test_for_path_project.Models;

namespace test_for_path_project.Controllers
{
    public class FirstPageController : Controller
    {
        private readonly ApplicationDbContext _context;

        private List<string> paths = new List<string> { "IT", "engineering", "medic" , "business", "language","law" };

        public FirstPageController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult FirstP()
        {
            return View();
        }

        [HttpPost, ActionName("path")]
        public  IActionResult secPage(string path)
        {
            foreach (string field in paths)
            {
                if (path == field && path != null)
                {
                    return RedirectToAction("Index", "SecondPage",new {p = path});
                }
            }
                return NotFound();
        }
    }
}
