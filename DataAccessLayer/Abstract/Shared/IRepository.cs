using System.Linq.Expressions;

namespace DataAccessLayer.Abstract.Shared
{
    public interface IRepository<T>
    {
        List<T> GetAll();
        //T GetById(int id);
        void Insert(T p);
        void Delete(T p);
        void Update(T p);
        List<T> List(Expression<Func<T, bool>> filter);
        List<T> Get(Expression<Func<T, bool>> filter);
        T GetById(Expression<Func<T, bool>> filter);
    }
}
