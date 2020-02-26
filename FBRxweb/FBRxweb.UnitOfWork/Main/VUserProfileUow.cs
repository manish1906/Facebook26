using RxWeb.Core.Data;
using FBRxweb.BoundedContext.Main;

namespace FBRxweb.UnitOfWork.Main
{
    public class VUserProfileUow : BaseUow, IVUserProfileUow
    {
        public VUserProfileUow(IVUserProfileContext context, IRepositoryProvider repositoryProvider) : base(context, repositoryProvider) { }
    }

    public interface IVUserProfileUow : ICoreUnitOfWork { }
}


