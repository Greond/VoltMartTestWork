using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VoltMartTestWork.Core.Interfaces.IRepositories;

namespace VoltMartTestWork.Data.Repositories
{
    internal class BaseRepository<T> : IBaseRepository<T> where T : class
    {
        private readonly AppDbContext _dbContext;
        protected DbSet<T> DbSet => _dbContext.Set<T>();

        protected BaseRepository(AppDbContext dbContext)
        {
            _dbContext = dbContext; 
        }
        public async Task<IEnumerable<T>> GetEntities()
        {
            return await _dbContext.Set<T>().ToListAsync();
        }
        public async Task<T> GetEntityById(int id)
        {
            var data = await _dbContext.Set<T>().FindAsync(id);
            if (data == null)
            {
                throw new ArgumentNullException("No data found");
            }
            return data;
        }
        public async Task<T> CreateEntity(T entity)
        {
            await _dbContext.Set<T>().AddAsync(entity);
            await _dbContext.SaveChangesAsync();
            return entity;
        }
        public async Task<T> UpdateEntity(T entity)
        {
            _dbContext.Set<T>().Update(entity);
            await _dbContext.SaveChangesAsync();
            return entity;
        }
        public async Task DeleteEntity(T entity)
        {
            _dbContext.Set<T>().Remove(entity);
            await _dbContext.SaveChangesAsync();
        }
    }
}
