using Microsoft.AspNetCore.Mvc;

namespace WebApplication1
{
    public class DefalutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
