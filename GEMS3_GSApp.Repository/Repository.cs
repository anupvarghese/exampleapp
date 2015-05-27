using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GEMS3_GSApp.Repository
{
    public abstract class Repository<T> : IRepository<T>
      where T : class
    {
        protected DbContext _entities;
        protected readonly IDbSet<T> _dbset;

        public Repository(DbContext context)
        {
            _entities = context;
            _dbset = context.Set<T>();
        }

        public virtual IQueryable<T> GetAll()
        {

            return _dbset.AsQueryable<T>();
        }

        public IQueryable<T> FindBy(System.Linq.Expressions.Expression<Func<T, bool>> predicate)
        {

            IQueryable<T> query = _dbset.Where(predicate).AsQueryable();
            return query;
        }

        public virtual T Add(T entity)
        {
            return _dbset.Add(entity);
        }

        public virtual T Delete(T entity)
        {
            return _dbset.Remove(entity);
        }

        public virtual void Edit(T entity)
        {
            _entities.Entry(entity).State = EntityState.Modified;
        }

        public virtual void Save()
        {
            _entities.SaveChanges();
        }
    }
}
