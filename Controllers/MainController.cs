using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CourseProject.Controllers
{
    [AllowAnonymous]
    public class MainController : Controller
    {
        // GET
        public IActionResult Index()
        {
            return View();
        }
    }
}