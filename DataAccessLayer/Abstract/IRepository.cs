namespace DataAccessLayer.Abstract
{
    public interface IRepository<T>
    {
        List<T> GetAll();
        //T GetById(int id);
        void Insert(T p);
        void Delete(T p);
        void Update(T p);
    }
}
