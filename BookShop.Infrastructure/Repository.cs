using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace BookShop.Infrastructure
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        protected readonly DbContext _dbContext;
        public Repository(DbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task DeleteAsync(TEntity entity)
        {
            _dbContext.Set<TEntity>().Remove(entity);
            
           await _dbContext.SaveChangesAsync();


        }

        public IEnumerable<TEntity> Find(Expression<Func<TEntity, bool>> predicate)
        {
            return _dbContext.Set<TEntity>().Where(predicate).AsNoTracking();
        }


        public IEnumerable<TEntity> GetAll()
        {
            return _dbContext.Set<TEntity>().ToList();
        }

        public void Save(TEntity entity)
        {

            try
            {
               
               var res= _dbContext.Set<TEntity>().Add(entity);
                 _dbContext.SaveChangesAsync();


            }
            catch (Exception e)
            {
                throw e;
            }
        }
        public async Task AsyncSave(TEntity entity)
        {
            using (var transaction = await _dbContext.Database.BeginTransactionAsync())
            {
                try
                {

                    _dbContext.Set<TEntity>().Add(entity);
                    await _dbContext.SaveChangesAsync();
                   await transaction.CommitAsync();
                }
                catch (Exception e)
                {
                   await transaction.RollbackAsync();
                    throw e;
                }
            }
        }



        public void Update(TEntity entity)
        {
            _dbContext.Set<TEntity>().Update(entity);
            _dbContext.SaveChanges();

        }





        public IEnumerable<TEntity> GetAll(string[] includes = null)
        {
            IQueryable<TEntity> entityQuery = _dbContext.Set<TEntity>();
            return entityQuery.ToList();

        }

        public TEntity Get(int id, string[] includes = null)
        {
            IQueryable<TEntity> entityQuery = _dbContext.Set<TEntity>().Where(x => id == id).AsNoTracking();
            return entityQuery.FirstOrDefault();

        }

        public List<TEntity> FindWithIncludes(Expression<Func<TEntity, bool>> predicate, string[] includes)
        {

            IQueryable<TEntity> entityQuery = _dbContext.Set<TEntity>().Where(predicate);

            foreach (var include in includes)
            {
                entityQuery = entityQuery.Include(include);
            }

            return entityQuery.ToList();
        }
        public async Task<List<TEntity>> FindWithIncludesASync(Expression<Func<TEntity, bool>> Predicate, string[] includes)
        {
            IQueryable<TEntity> entityQuery = _dbContext.Set<TEntity>().Where(Predicate);

            foreach (var include in includes)
            {
                entityQuery = entityQuery.Include(include);
            }

            return await entityQuery.ToListAsync();
        }

        public void SaveList(IEnumerable<TEntity> entities)
        {
            _dbContext.Set<TEntity>().AddRange(entities);
            _dbContext.SaveChanges();
        }

        public int GetAutoGenaretedID(TEntity entity)
        {
            var propertyInfo = entity.GetType().GetProperty("Id");
            if (propertyInfo != null)
            {
                // Obtain the value of the Id property and cast it to an integer
                int id = (int)propertyInfo.GetValue(entity);
                return id;
            }
            else
            {
                return 0;
            }
        }
    }
}
