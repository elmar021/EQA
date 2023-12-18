using EQA.Core.Models;
using Microsoft.EntityFrameworkCore;

namespace EQAS.VIewModel
{
    public class BoxViewModel
    {
        public List<Portfolio> Portfolios { get; set; }
        public List<Category> Categories { get; set; }
    }
}
