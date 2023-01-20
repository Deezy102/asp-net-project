using asp_net_project.Models;
using Microsoft.AspNetCore.Mvc;

namespace asp_net_project.Controllers
{
    public class HomeController : Controller
    {
        public HomeController()
        {

        }

        public IActionResult Index()
        {
            return View();
        }
    }
}