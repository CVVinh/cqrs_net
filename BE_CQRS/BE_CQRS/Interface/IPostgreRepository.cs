using Microsoft.EntityFrameworkCore.Query;
using System.Linq.Expressions;

namespace BE_CQRS.Interface
{
    public interface IPostgreRepository<TEntity> where TEntity : class
    {
        Task<IEnumerable<TEntity>> GetAll(Func<IQueryable<TEntity>, IIncludableQueryable<TEntity, object>> entity = null);
        Task<TEntity?> GetById(Expression<Func<TEntity, bool>> expression, Func<IQueryable<TEntity>, IIncludableQueryable<TEntity, object>> entity = null);
        IEnumerable<TEntity> Find(Expression<Func<TEntity, bool>> expression);
        Task Insert(TEntity entity);
        Task Update(TEntity entity);
        Task Delete(TEntity entity);

        bool IsEntity(Expression<Func<TEntity, bool>> expression);
    }
}
