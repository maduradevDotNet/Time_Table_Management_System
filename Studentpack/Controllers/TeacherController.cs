using Microsoft.AspNetCore.Mvc;

namespace Studentpack.Controllers
{
    public class TeacherController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
