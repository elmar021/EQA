using EQA.Core.Models;
using EQA.Core.Repositories.Interfaces;
using EQA.Data.DataAccessLayer;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace EQA.Data.Repositories.Implementations
{
    public class GenricRepository<TEntity> : IGenericRepository<TEntity> where TEntity : BaseEntity, new()
    {
        private readonly AppDbContext _context;
        public GenricRepository(AppDbContext context)
        {
            _context = context;
        }
        public DbSet<TEntity> Table => _context.Set<TEntity>();
        public async Task<int> CommitAsync()
        {
            return await _context.SaveChangesAsync();
        }
        public async Task CreateAsync(TEntity entity)
        {
            await Table.AddAsync(entity);
        }
        public void Delete(TEntity entity)
        {
            Table.Remove(entity);
        }
        public Task<List<TEntity>> GetAllAsync(Expression<Func<TEntity, bool>>? expression = null, params string[]? includes)
        {
            throw new NotImplementedException();
        }
        public Task<TEntity> GetByIdAsync(Expression<Func<TEntity, bool>>? expression = null, params string[]? includes)
        {
            throw new NotImplementedException();
        }
    }
}
