using Microsoft.AspNetCore.Mvc;

namespace Studentpack.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
