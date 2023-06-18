using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;

namespace BusinessLayer.Concrete
{
    public class MessageManager : IMessageService
    {
        IMessageDal _messageDal;

        public MessageManager(IMessageDal messageDal)
        {
            _messageDal = messageDal;
        }
        public List<Message> GetAll()
        {
            return _messageDal.GetAll();
        }

        public Message GetById(int id)
        {
            return _messageDal.GetById(x => x.MessageId == id);
        }

        public List<Message> GetListInbox()
        {
            return _messageDal.List(x => x.ReceiverMail == "admin@gmail.com");
        }
        public List<Message> GetListSendbox()
        {
            return _messageDal.List(x => x.SenderMail == "admin@gmail.com");
        }

        public void MessageAdd(Message Message)
        {
            _messageDal.Insert(Message);
        }

        public void MessageDelete(Message Message)
        {
            _messageDal.Delete(Message);
        }

        public void MessageUpdate(Message Message)
        {
            _messageDal.Update(Message);
        }
    }
}
