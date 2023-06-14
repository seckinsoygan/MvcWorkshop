using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;

namespace BusinessLayer.Concrete
{
    public class CategoryManager : ICategoryService
    {
        ICategoryDal _categoryDal;

        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }

        public List<Category> GetAll()
        {
            return _categoryDal.GetAll();
        }

        //public void CategoryAddBl(Category category)
        //{
        //    _categoryDal.Insert(category);
        //}

        public void CategoryAdd(Category category)
        {
            _categoryDal.Insert(category);
        }
    }
}
