using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using test_for_path_project.Models;

namespace test_for_path_project.Controllers
{
    public class SecondPageController : Controller
    {
        private readonly ApplicationDbContext _context;

        public SecondPageController(ApplicationDbContext context)
        {
            _context = context;
        }
        public IActionResult Index(string p)
        {
            if(p != null && p == "IT" ){
                ViewBag.Title = p;
                var uniIT  = _context.Unis.ToList();
                if(uniIT != null)
                {
                    return View(uniIT);
                }
                return NotFound();
            }
            else if (p != null && p == "engineering")
            {
                ViewBag.Title = p;
                var uniEng = _context.Unis.ToList();
                if (uniEng != null)
                {
                    return View(uniEng);
                }
                return NotFound();
                
            }
            else if ( p != null && p == "medic")
            {
                ViewBag.Title = p;
                var uniMed = _context.Unis.ToList();
                if (uniMed != null)
                {
                    return View(uniMed);
                }
                return NotFound();
               
            }
            return View();
        }
    }
}
