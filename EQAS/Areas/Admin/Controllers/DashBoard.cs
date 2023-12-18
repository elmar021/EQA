using Microsoft.AspNetCore.Mvc;

namespace EQAS.Areas.Admin.Controllers
{
    public class DashBoard : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
