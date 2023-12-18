using EQA.Core.Models;
using EQA.Core.Repositories.Interfaces;
using EQA.Data.DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EQA.Data.Repositories.Implementations
{
    public class PortfolioRepository : GenricRepository<Portfolio>, IPortfolioRepository
    {
        public PortfolioRepository(AppDbContext context) : base(context) 
        {

        }
    }
        
    
}
