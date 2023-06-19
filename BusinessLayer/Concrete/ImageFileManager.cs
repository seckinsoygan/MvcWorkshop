using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;

namespace BusinessLayer.Concrete
{
    public class ImageFileManager : IImageFileService
    {
        IImageFileDal _imagefileDal;

        public ImageFileManager(IImageFileDal imageFileDal)
        {
            _imagefileDal = imageFileDal;
        }
        public List<ImageFile> GetAll()
        {
            return _imagefileDal.GetAll();
        }
    }
}
