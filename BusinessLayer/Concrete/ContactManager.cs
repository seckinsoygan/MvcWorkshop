using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;

namespace BusinessLayer.Concrete
{
    public class ContactManager : IContactService
    {
        IContactDal _contactDal;

        public ContactManager(IContactDal contactDal)
        {
            _contactDal = contactDal;
        }
        public void ContactAdd(Contact Contact)
        {
            _contactDal.Insert(Contact);
        }

        public void ContactDelete(Contact Contact)
        {
            _contactDal.Delete(Contact);
        }

        public void ContactUpdate(Contact Contact)
        {
            _contactDal.Update(Contact);
        }

        public List<Contact> GetAll()
        {
            return _contactDal.GetAll();
        }

        public Contact GetById(int id)
        {
            return _contactDal.GetById(x => x.ContactId == id);
        }
    }
}
