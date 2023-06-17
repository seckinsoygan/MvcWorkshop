using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;

namespace BusinessLayer.Concrete
{
    public class ContentManager : IContentService
    {
        IContentDal _contentDal;

        public ContentManager(IContentDal contentDal)
        {
            _contentDal = contentDal;
        }

        public void ContentAdd(Content Content)
        {
            throw new NotImplementedException();
        }

        public void ContentDelete(Content Content)
        {
            throw new NotImplementedException();
        }

        public void ContentUpdate(Content Content)
        {
            throw new NotImplementedException();
        }

        public List<Content> GetAll()
        {
            throw new NotImplementedException();
        }

        public Content GetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Content> GetListByHeadingId(int id)
        {
            return _contentDal.List(x => x.HeadingId == id);
        }
    }
}
