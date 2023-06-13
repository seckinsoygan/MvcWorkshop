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
        List<T> Get(Expression<Func<T, bool>> filter);
    }
}
