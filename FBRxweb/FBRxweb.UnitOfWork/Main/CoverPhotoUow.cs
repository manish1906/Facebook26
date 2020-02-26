using RxWeb.Core.Data;
using FBRxweb.BoundedContext.Main;

namespace FBRxweb.UnitOfWork.Main
{
    public class CoverPhotoUow : BaseUow, ICoverPhotoUow
    {
        public CoverPhotoUow(ICoverPhotoContext context, IRepositoryProvider repositoryProvider) : base(context, repositoryProvider) { }
    }

    public interface ICoverPhotoUow : ICoreUnitOfWork { }
}


