using Microsoft.AspNetCore.Mvc;

namespace EQAS.Areas.Admin.Controllers
{
    public class Category : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
