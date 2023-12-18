using EQA.Data.DataAccessLayer;
using EQAS.VIewModel;
using Microsoft.AspNetCore.Mvc;

namespace EQAS.Controllers
{
    public class EQAControlller : Controller
    {
        private readonly AppDbContext _context;
        public EQAControlller(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            BoxViewModel bwm = new BoxViewModel()
            {
                Portfolios = _context.Portfolios.ToList(),
                Categories = _context.Categories.ToList(),
            };
            return View(bwm);
        }
    }
}
