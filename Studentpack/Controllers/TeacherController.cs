using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Studentpack.Data;
using Studentpack.Models;

namespace Studentpack.Controllers
{
    public class TeacherController : Controller
    {
        private readonly ApplicationDbContext _Db;

        public TeacherController(ApplicationDbContext Db)
        {
            _Db = Db;
        }
        public async Task<IActionResult> Index()
        {
            var teachers = await _Db.teachers
         .Include(t => t.Classes) // Include related Classes data
         .ToListAsync();

            return View(teachers);
        }
    }
}
