using Microsoft.AspNetCore.Mvc;

namespace Studentpack.Controllers
{
    public class SchoolClassController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
