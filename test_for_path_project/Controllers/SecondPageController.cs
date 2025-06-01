using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Linq;
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
        public async Task<IActionResult> Index(string p ,float g)
        {
            if(p != null && p == "IT" ){
                ViewBag.Title = g;
                if (g != 0)
                {
                    var newModle = new CombinedViewModel
                    {
                        AAUlIST = await _context.AAU_INFO.Where(x => x.الحقل == "تكنلوجيا المعلومات" && x.معدل_القبول <= g).ToListAsync(),
                        PHUlIST = await _context.PHU_INFO.Where(x => x.الحقل == "تكنلوجيا المعلومات" && x.معدل_القبول <= g).ToListAsync(),
                        MEUlIST = await _context.MEU_INFO.Where(x => x.الحقل == "تكنلوجيا المعلومات" && x.معدل_القبول <= g).ToListAsync(),
                        UniesList = _context.Unis.ToList()
                    };
                    if (newModle != null)
                    {
                        return View(newModle);
                    }
                }
                else
                {
                    var newModle = new CombinedViewModel
                    {
                        AAUlIST = await _context.AAU_INFO.Where(x => x.الحقل == "تكنلوجيا المعلومات" ).ToListAsync(),
                        PHUlIST = await _context.PHU_INFO.Where(x => x.الحقل == "تكنلوجيا المعلومات" ).ToListAsync(),
                        MEUlIST = await _context.MEU_INFO.Where(x => x.الحقل == "تكنلوجيا المعلومات" ).ToListAsync(),
                        UniesList = _context.Unis.ToList()
                    };
                    if (newModle != null)
                    {
                        return View(newModle);
                    }
                }
               
                return NotFound();
            }
            else if (p != null && p == "engineering")
            {
                ViewBag.Title = p;
                if (g != 0)
                {
                    var newModle = new CombinedViewModel
                    {

                        AAUlIST = await _context.AAU_INFO.Where(x => x.الحقل == "هندسي" && x.معدل_القبول <= g).ToListAsync(),
                        PHUlIST = await _context.PHU_INFO.Where(x => x.الحقل == "هندسي" && x.معدل_القبول <= g).ToListAsync(),
                        MEUlIST = await _context.MEU_INFO.Where(x => x.الحقل == "هندسي" && x.معدل_القبول <= g).ToListAsync(),
                        UniesList = _context.Unis.ToList()
                    };
                    if (newModle != null)
                    {
                        return View(newModle);
                    }
                }
                else
                {
                    var newModle = new CombinedViewModel
                    {
                        AAUlIST = await _context.AAU_INFO.Where(x => x.الحقل == "هندسي" ).ToListAsync(),
                        PHUlIST = await _context.PHU_INFO.Where(x => x.الحقل == "هندسي" ).ToListAsync(),
                        MEUlIST = await _context.MEU_INFO.Where(x => x.الحقل == "هندسي" ).ToListAsync(),
                        UniesList = _context.Unis.ToList()
                    };
                    if (newModle != null)
                    {
                        return View(newModle);
                    }
                }
                return NotFound();
            }
            else if ( p != null && p == "medic")
            {
                ViewBag.Title = p;
                if (g != 0)
                {
                    var newModle = new CombinedViewModel
                    {
                        AAUlIST = await _context.AAU_INFO.Where(x => x.الحقل == "صحي" && x.معدل_القبول <= g).ToListAsync(),
                        PHUlIST = await _context.PHU_INFO.Where(x => x.الحقل == "صحي" && x.معدل_القبول <= g).ToListAsync(),
                        MEUlIST = await _context.MEU_INFO.Where(x => x.الحقل == "صحي" && x.معدل_القبول <= g).ToListAsync(),
                        UniesList = _context.Unis.ToList()

                    };
                    if (newModle != null)
                    {
                        return View(newModle);
                    }

                }
                else
                {
                    var newModle = new CombinedViewModel
                    {
                        AAUlIST = await _context.AAU_INFO.Where(x => x.الحقل == "صحي" ).ToListAsync(),
                        PHUlIST = await _context.PHU_INFO.Where(x => x.الحقل == "صحي" ).ToListAsync(),
                        MEUlIST = await _context.MEU_INFO.Where(x => x.الحقل == "صحي" ).ToListAsync(),
                        UniesList = _context.Unis.ToList()
                    };
                    if (newModle != null)
                    {
                        return View(newModle);
                    }
                }
                return NotFound();
            }
            else if (p != null && p == "business")
            {
                ViewBag.Title = p;
                if (g != 0) {

                    var newModle = new CombinedViewModel
                    {
                        AAUlIST = await _context.AAU_INFO.Where(x => x.الحقل == "الأعمال" && x.معدل_القبول <= g).ToListAsync(),
                        PHUlIST = await _context.PHU_INFO.Where(x => x.الحقل == "الأعمال" && x.معدل_القبول <= g).ToListAsync(),
                        MEUlIST = await _context.MEU_INFO.Where(x => x.الحقل == "الأعمال" && x.معدل_القبول <= g).ToListAsync(),
                        UniesList = _context.Unis.ToList()

                    };
                    if (newModle != null)
                    {
                        return View(newModle);
                    }
                }
                else
                {
                    var newModle = new CombinedViewModel
                    {
                        AAUlIST = await _context.AAU_INFO.Where(x => x.الحقل == "الأعمال" ).ToListAsync(),
                        PHUlIST = await _context.PHU_INFO.Where(x => x.الحقل == "الأعمال" ).ToListAsync(),
                        MEUlIST = await _context.MEU_INFO.Where(x => x.الحقل == "الأعمال" ).ToListAsync(),
                        UniesList = _context.Unis.ToList()
                    };
                    if (newModle != null)
                    {
                        return View(newModle);
                    }
                }
                return NotFound();

            }
            else if (p != null && p == "language")
            {
                ViewBag.Title = p;
                if (g != 0) {

                    var newModle = new CombinedViewModel
                    {
                        AAUlIST = await _context.AAU_INFO.Where(x => x.الحقل == "اللغات والعلوم الاجتماعية" && x.معدل_القبول <= g).ToListAsync(),
                        MEUlIST = await _context.MEU_INFO.Where(x => x.الحقل == "اللغات والعلوم الاجتماعية" && x.معدل_القبول <= g).ToListAsync(),
                        PHUlIST = await _context.PHU_INFO.Where(x => x.الحقل == "اللغات والعلوم الاجتماعية" && x.معدل_القبول <= g).ToListAsync(),
                        UniesList = _context.Unis.ToList()

                    };
                    if (newModle != null)
                    {
                        return View(newModle);
                    }

                }
                else
                {
                    var newModle = new CombinedViewModel
                    {
                        AAUlIST = await _context.AAU_INFO.Where(x => x.الحقل == "اللغات والعلوم الاجتماعية" ).ToListAsync(),
                        MEUlIST = await _context.MEU_INFO.Where(x => x.الحقل == "اللغات والعلوم الاجتماعية" ).ToListAsync(),
                        PHUlIST = await _context.PHU_INFO.Where(x => x.الحقل == "اللغات والعلوم الاجتماعية" ).ToListAsync(),
                        UniesList = _context.Unis.ToList()
                    };
                    if (newModle != null)
                    {
                        return View(newModle);
                    }
                }
                return NotFound();

            }
            else if (p != null && p == "law")
            {
                ViewBag.Title = p;
                if (g != 0)
                {
                    var newModle = new CombinedViewModel
                    {
                        AAUlIST = await _context.AAU_INFO.Where(x => x.الحقل == "القانون والعلوم الشرعية" && x.معدل_القبول <= g).ToListAsync(),
                        PHUlIST = await _context.PHU_INFO.Where(x => x.الحقل == "القانون والعلوم الشرعية" && x.معدل_القبول <= g).ToListAsync(),
                        MEUlIST = await _context.MEU_INFO.Where(x => x.الحقل == "القانون والعلوم الشرعية" && x.معدل_القبول <= g).ToListAsync(),
                        UniesList = _context.Unis.ToList()

                    };
                    if (newModle != null)
                    {
                        return View(newModle);
                    }
                    return NotFound();
                }
                else
                {
                    var newModle = new CombinedViewModel
                    {
                        AAUlIST = await _context.AAU_INFO.Where(x => x.الحقل == "القانون والعلوم الشرعية" ).ToListAsync(),
                        PHUlIST = await _context.PHU_INFO.Where(x => x.الحقل == "القانون والعلوم الشرعية" ).ToListAsync(),
                        MEUlIST = await _context.MEU_INFO.Where(x => x.الحقل == "القانون والعلوم الشرعية" ).ToListAsync(),
                        UniesList = _context.Unis.ToList()
                    };
                    if (newModle != null)
                    {
                        return View(newModle);
                    }
                }
            }
            return View();
        }
    }
}
