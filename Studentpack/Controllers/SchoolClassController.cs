using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Studentpack.Data;
using Studentpack.Models;

namespace Studentpack.Controllers
{
    public class SchoolClassController : Controller
    {
        private readonly ApplicationDbContext _DB;

        public SchoolClassController(ApplicationDbContext DB)
        {
            _DB= DB;
        }

        public async Task<IActionResult> Index()
        {
            var schoolClasses = await _DB.schoolClass
                .Include(sc => sc.Teacher)       // Include the Teacher data
                .Include(sc => sc.Students)       // Include the Students data
                .ToListAsync();

            return View(schoolClasses);
        }

    }
}
