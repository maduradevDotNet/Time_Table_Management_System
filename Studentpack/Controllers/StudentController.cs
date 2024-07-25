using Microsoft.AspNetCore.Mvc;
using Studentpack.Data;
using Studentpack.Models;

namespace Studentpack.Controllers
{
    public class StudentController : Controller
    {
        private readonly ApplicationDbContext _Db;

        public StudentController(ApplicationDbContext Db)
        {
            _Db=Db;
        }
        public IActionResult Index()
        {
            List<Student> obj=_Db.students.ToList();
            return View(obj);
        }
    }
}
