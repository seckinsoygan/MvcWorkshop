using DataAccessLayer.Abstract.Shared;
using System.Data.Entity;
using System.Linq.Expressions;

namespace DataAccessLayer.Concrete.Repositories
{
    public class GenericRepository<T> : IRepository<T> where T : class
    {
        Context c = new Context();
        DbSet<T> _object;

        public GenericRepository()
        {
            _object = c.Set<T>();
        }

        public void Delete(T p)
        {
            var DeletedEntity = c.Entry(p);
            DeletedEntity.State = EntityState.Deleted;
            c.SaveChanges();
        }

        public List<T> Get(Expression<Func<T, bool>> filter)
        {
            return _object.Where(filter).ToList();
        }

        public List<T> GetAll()
        {
            return _object.ToList();
        }

        public T GetById(Expression<Func<T, bool>> filter)
        {
            return _object.SingleOrDefault(filter);
        }

        public void Insert(T p)
        {
            var AddedEntity = c.Entry(p);
            AddedEntity.State = EntityState.Added;
            c.SaveChanges();
        }

        public void Update(T p)
        {

            var UpdatedEntity = c.Entry(p);
            UpdatedEntity.State = EntityState.Modified;
            c.SaveChanges();
        }
    }
}
