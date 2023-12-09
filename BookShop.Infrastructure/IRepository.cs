using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BookShop.Infrastructure
{
    public interface IRepository<TEntity> where TEntity : class
    {
        TEntity Get(int id, string[] includes = null);
        IEnumerable<TEntity> GetAll(string[] includes = null);
        IEnumerable<TEntity> Find(Expression<Func<TEntity, bool>> predicate);
        Task<TEntity> Save(TEntity entity);
        void SaveList(IEnumerable<TEntity> entities);
        void Delete(TEntity entity);
        void Update(TEntity entity);
        Task<List<TEntity>> FindWithIncludesASync(Expression<Func<TEntity, bool>> Predicate, string[] includes);
        public List<TEntity> FindWithIncludes(Expression<Func<TEntity, bool>> predicate, string[] includes);
    }
}
