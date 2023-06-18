using EntityLayer.Concrete;

namespace BusinessLayer.Abstract
{
    public interface IContactService
    {
        List<Contact> GetAll();
        void ContactAdd(Contact Contact);
        Contact GetById(int id);
        void ContactDelete(Contact Contact);
        void ContactUpdate(Contact Contact);
    }
}
