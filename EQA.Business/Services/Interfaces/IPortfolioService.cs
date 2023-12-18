using EQA.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EQA.Business.Services.Interfaces
{
    public interface IPortfolioService 
    {
        public Task CreateAsync(Portfolio entity);
        public Task SoftDelete(int id);
        public Task Delete(int id);
        public Task<Portfolio> GetByIdAsync(int id);
        public Task<List<Portfolio>> GetAllAsync();
        public Task UpdateAsync(Portfolio entity);
    }
}
