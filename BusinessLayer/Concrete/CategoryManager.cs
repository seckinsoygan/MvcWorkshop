using DataAccessLayer.Concrete.Repositories;
using EntityLayer.Concrete;

namespace BusinessLayer.Concrete
{
    public class CategoryManager
    {
        GenericRepository<Category> repository = new GenericRepository<Category>();

        public List<Category> GetAll()
        {
            return repository.GetAll();
        }

        public void CategoryAddBl(Category category)
        {
            repository.Insert(category);
        }
    }
}
