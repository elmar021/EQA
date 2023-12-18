using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EQA.Core.Models
{
    public class PortfolioImage : BaseEntity
    {
        public string ImageUrl { get; set; }
        public bool? IsPoster { get; set; }
        public int PortfolioId { get; set; }
        public Portfolio Portfolio { get; set; }

    }
}
