using Microsoft.AspNetCore.Mvc;

namespace Paupers.Controllers
{
    public class Data : Controller
    {
        public IActionResult Index()
        {
            var data = new Data();

            return View();
        }
    }
}
