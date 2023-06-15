using EntityLayer.Concrete;

namespace BusinessLayer.Abstract
{
    public interface IHeadingService
    {
        List<Heading> GetAll();
        void HeadingAdd(Heading heading);
        Heading GetById(int id);
        void HeadingDelete(Heading heading);
        void HeadingUpdate(Heading heading);
    }
}
