using EntityLayer.Concrete;

namespace DataAccessLayer.Abstract
{
    public interface ICategoryDal
    {
        List<Category> GetAll();
        //Category Get(int id);
        void Insert(Category p);
        void Delete(Category p);
        void Update(Category p);
    }
}
