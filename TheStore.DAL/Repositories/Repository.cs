using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using TheStore.Core.Repositories;

namespace TheStore.Data.Repositories
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity: class
    {
        public readonly DbContext _context;
        public readonly DbSet<TEntity> _dbset;

        public Repository(DbContext dbContext)
        {
            _context = dbContext;
            _dbset = dbContext.Set<TEntity>();
        }
        public async Task AddAsync(TEntity entity)
        {
            await _dbset.AddAsync(entity);
        }

        public async Task AddRangeAsync(IEnumerable<TEntity> entities)
        {
            await _dbset.AddRangeAsync(entities);
        }

        public async Task<IEnumerable<TEntity>> GetAllAsync()
        {
            return await _dbset.ToListAsync();
        }

        public async Task<TEntity> GetByIdAsync(int id)
        {
            return await _dbset.FindAsync(id);
        }

        public void Remove(TEntity entity)
        {
            _dbset.Remove(entity);
        }

        public void RemoveRange(IEnumerable<TEntity> entities)
        {
            _dbset.RemoveRange(entities);
        }

        public async Task<TEntity> SingleOrDefaultAsync(Expression<Func<TEntity, bool>> predicate)
        {
            return await _dbset.SingleOrDefaultAsync(predicate);
        }

        public TEntity Update(TEntity entity)
        {
            _context.Update(entity).State = EntityState.Modified;

            return entity;
        }

        public  IEnumerable<TEntity> Where(Expression<Func<TEntity, bool>> predicate)
        {
            return   _dbset.Where(predicate);
        }

     
    }
}
