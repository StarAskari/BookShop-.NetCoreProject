using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BookShop.Application
{
    public interface IService<TEntity> where TEntity : class
    {
        TEntity Get(int id, string[] includes = null);
        IEnumerable<TEntity> GetAll(string[] includes = null);
        IEnumerable<TEntity> Find(Expression<Func<TEntity, bool>> predicate);
        void Save(TEntity entity);
        Task SaveAsync(TEntity entity);
        void SaveList(IEnumerable<TEntity> entities);

        void Delete(TEntity entity);
        void Update(TEntity entity);
        List<TEntity> FindWithIncludes(Expression<Func<TEntity, bool>> predicate, string[] includes);
        Task<List<TEntity>> FindWithIncludesAsync(Expression<Func<TEntity, bool>> predicate, string[] includes);
    }
}
