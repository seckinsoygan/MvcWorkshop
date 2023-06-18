using EntityLayer.Concrete;

namespace BusinessLayer.Abstract
{
    public interface IMessageService
    {
        List<Message> GetAll();
        List<Message> GetListInbox();
        List<Message> GetListSendbox();
        void MessageAdd(Message Message);
        Message GetById(int id);
        void MessageDelete(Message Message);
        void MessageUpdate(Message Message);
    }
}
