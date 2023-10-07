using Microsoft.AspNetCore.Mvc;

namespace NETMVC.Controllers
{
    public class CareController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}