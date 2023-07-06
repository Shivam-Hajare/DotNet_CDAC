using Microsoft.AspNetCore.Mvc;

namespace WebApplication3
{
    public class DefaultController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        //view to have diff name
        public IActionResult Newcon()
        {
            return View("OtherName");
        }
    }
}
