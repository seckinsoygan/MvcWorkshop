using EntityLayer.Concrete;

namespace BusinessLayer.Abstract
{
    public interface IAboutService
    {
        List<About> GetAll();
        void AboutAdd(About about);
        About GetById(int id);
        void AboutDelete(About about);
        void AboutUpdate(About about);
    }
}
