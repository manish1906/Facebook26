#region Namespace
using Microsoft.Extensions.DependencyInjection;
using FBRxweb.Infrastructure.Security;
using RxWeb.Core.Data;
using RxWeb.Core.Security;
using RxWeb.Core.Annotations;
using RxWeb.Core;
using FBRxweb.UnitOfWork.DbEntityAudit;
using FBRxweb.BoundedContext.Main;
using FBRxweb.UnitOfWork.Main;

            using FBRxweb.Domain.FacebookUserWorkModule;
            using FBRxweb.Domain.EducationDetailModule;
           
            using FBRxweb.Domain.FacebookUserDetailModule;
            using FBRxweb.Domain.vUserProfileModule;
            using FBRxweb.Domain.ProfilePhotoModule;
            using FBRxweb.Domain.CoverPhotoModule;
            using FBRxweb.Domain.vEducationDetailModule;
            #endregion Namespace












namespace FBRxweb.Api.Bootstrap
{
    public static class ScopedExtension
    {

        public static void AddScopedService(this IServiceCollection serviceCollection)
        {
            serviceCollection.AddScoped<IRepositoryProvider, RepositoryProvider>();
            serviceCollection.AddScoped<ITokenAuthorizer, TokenAuthorizer>();
            serviceCollection.AddScoped<IModelValidation, ModelValidation>();
            serviceCollection.AddScoped<IAuditLog, AuditLog>();
            serviceCollection.AddScoped<IApplicationTokenProvider, ApplicationTokenProvider>();
            serviceCollection.AddScoped(typeof(IDbContextManager<>), typeof(DbContextManager<>));

            #region ContextService

            serviceCollection.AddScoped<ILoginContext, LoginContext>();
            serviceCollection.AddScoped<ILoginUow, LoginUow>();
             
            serviceCollection.AddScoped<IFacebookContext, FacebookContext>();
            serviceCollection.AddScoped<IFacebookUow, FacebookUow>();
                    
                      
                        serviceCollection.AddScoped<IFacebookUserWorkContext, FacebookUserWorkContext>();
            serviceCollection.AddScoped<IFacebookUserWorkUow, FacebookUserWorkUow>();
                        serviceCollection.AddScoped<IEducationDetailContext, EducationDetailContext>();
            serviceCollection.AddScoped<IEducationDetailUow, EducationDetailUow>();
      
                        serviceCollection.AddScoped<IFacebookUserDetailContext, FacebookUserDetailContext>();
            serviceCollection.AddScoped<IFacebookUserDetailUow, FacebookUserDetailUow>();
                        serviceCollection.AddScoped<IVUserProfileContext, VUserProfileContext>();
            serviceCollection.AddScoped<IVUserProfileUow, VUserProfileUow>();
                        serviceCollection.AddScoped<IVUserProfileContext, VUserProfileContext>();
            serviceCollection.AddScoped<IVUserProfileUow, VUserProfileUow>();
                        serviceCollection.AddScoped<IVUserProfileContext, VUserProfileContext>();
            serviceCollection.AddScoped<IVUserProfileUow, VUserProfileUow>();
                        serviceCollection.AddScoped<IProfilePhotoContext, ProfilePhotoContext>();
            serviceCollection.AddScoped<IProfilePhotoUow, ProfilePhotoUow>();
                        serviceCollection.AddScoped<ICoverPhotoContext, CoverPhotoContext>();
            serviceCollection.AddScoped<ICoverPhotoUow, CoverPhotoUow>();
                        serviceCollection.AddScoped<IVEducationDetailContext, VEducationDetailContext>();
            serviceCollection.AddScoped<IVEducationDetailUow, VEducationDetailUow>();
            #endregion ContextService










            #region DomainService

            
       
            
            serviceCollection.AddScoped<IFacebookUserWorkDomain, FacebookUserWorkDomain>();
            
            serviceCollection.AddScoped<IEducationDetailDomain, EducationDetailDomain>();
         
            
            serviceCollection.AddScoped<IFacebookUserDetailDomain, FacebookUserDetailDomain>();
            
            serviceCollection.AddScoped<IFacebookUserDetailDomain, FacebookUserDetailDomain>();
            
            serviceCollection.AddScoped<IFacebookUserDetailDomain, FacebookUserDetailDomain>();
            
            serviceCollection.AddScoped<IvUserProfileDomain, vUserProfileDomain>();
            
            serviceCollection.AddScoped<IvUserProfileDomain, vUserProfileDomain>();
            
            serviceCollection.AddScoped<IProfilePhotoDomain, ProfilePhotoDomain>();
            
            serviceCollection.AddScoped<ICoverPhotoDomain, CoverPhotoDomain>();
            
            serviceCollection.AddScoped<IvEducationDetailDomain, vEducationDetailDomain>();
            #endregion DomainService













        }
    }
}




