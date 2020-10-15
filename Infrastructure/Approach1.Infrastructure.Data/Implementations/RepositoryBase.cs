using System.Data.Entity;
using System.Linq;
using Approach1.Core.Data;

namespace Approach1.Infrastructure.Data.Implementations
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private PrometheusBaseEntities DbContext;
        private readonly DbSet<T> dbSet;

        protected Repository(PrometheusBaseEntities context)
        {
            this.DbContext = context;
            this.dbSet = this.DbContext.Set<T>();
        }

        public void Add(T entity)
        {
            var entityEntry = DbContext.Entry(entity);

            if (entityEntry.State != EntityState.Detached)
            {
                entityEntry.State = EntityState.Added;
            }
            else
            {
                this.dbSet.Add(entity);
            }
        }

        public void Delete(T entityToDelete)
        {
            var entityEntry = DbContext.Entry(entityToDelete);

            if (entityEntry.State != EntityState.Deleted)
            {
                entityEntry.State = EntityState.Deleted;
            }
            else
            {
                this.dbSet.Attach(entityToDelete);
                this.dbSet.Remove(entityToDelete);
            }
        }

        public IQueryable<T> GetAll()
        {
            return this.dbSet;
        }

        public T GetById(int id)
        {
            return this.dbSet.Find(id);
        }

        public void Update(T entityToUpdate)
        {
            var entityEntry = this.DbContext.Entry(entityToUpdate);

            if (entityEntry.State == EntityState.Detached)
            {
                this.dbSet.Attach(entityToUpdate);
            }

            entityEntry.State = EntityState.Modified;
        }
    }
}
