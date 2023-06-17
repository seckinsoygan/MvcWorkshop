using EntityLayer.Concrete;

namespace BusinessLayer.Abstract
{
    public interface IContentService
    {
        List<Content> GetAll();
        List<Content> GetListByHeadingId(int id);
        void ContentAdd(Content Content);
        Content GetById(int id);
        void ContentDelete(Content Content);
        void ContentUpdate(Content Content);
    }
}
