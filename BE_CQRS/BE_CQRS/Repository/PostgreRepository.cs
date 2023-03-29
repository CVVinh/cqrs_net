using BE_CQRS.Interface;
using BE_CQRS.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;
using System.Linq.Expressions;

namespace BE_CQRS.Repository
{
    public class PostgreRepository<TEntity> : IPostgreRepository<TEntity> where TEntity : class
    {
        private PostgreDbContext _context;
        private DbSet<TEntity> dbSet;

        public PostgreRepository(PostgreDbContext context)
        {
            _context = context;
            dbSet = _context.Set<TEntity>();
        }

        public async Task<IEnumerable<TEntity>> GetAll(Func<IQueryable<TEntity>, IIncludableQueryable<TEntity, object>> entity = null)
        {
            if (entity == null)
            {
                return await dbSet.ToListAsync();
            }
            return await entity(dbSet.AsQueryable()).ToListAsync();
        }

        public async Task<TEntity?> GetById(Expression<Func<TEntity, bool>> expression, Func<IQueryable<TEntity>, IIncludableQueryable<TEntity, object>> entity = null)
        {
            if (entity == null)
            {
                return await dbSet.Where(expression).FirstOrDefaultAsync();
            }
            return await entity(dbSet.AsQueryable()).Where(expression).FirstOrDefaultAsync();
        }

        public IEnumerable<TEntity> Find(Expression<Func<TEntity, bool>> expression)
        {
            return dbSet.Where(expression);
        }

        public async Task Insert(TEntity entity)
        {
            await dbSet.AddAsync(entity);
            await _context.SaveChangesAsync();
        }
       

        public async Task Update(TEntity entity)
        {
            dbSet.Update(entity);
            await _context.SaveChangesAsync();
        }

        public async Task Delete(TEntity entity)
        {
            dbSet.Remove(entity);
            await _context.SaveChangesAsync();
        }

        public bool IsEntity(Expression<Func<TEntity, bool>> expression)
        {
            return dbSet.Any(expression);
        }

    }
}
