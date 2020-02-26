using RxWeb.Core.Data;
using FBRxweb.BoundedContext.Main;

namespace FBRxweb.UnitOfWork.Main
{
    public class ProfilePhotoUow : BaseUow, IProfilePhotoUow
    {
        public ProfilePhotoUow(IProfilePhotoContext context, IRepositoryProvider repositoryProvider) : base(context, repositoryProvider) { }
    }

    public interface IProfilePhotoUow : ICoreUnitOfWork { }
}


