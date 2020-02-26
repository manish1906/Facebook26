using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using FBRxweb.BoundedContext.SqlContext;
using FBRxweb.Models.Main;
using FBRxweb.Models;
using FBRxweb.BoundedContext.Singleton;
using RxWeb.Core.Data;
using RxWeb.Core.Data.Models;
using RxWeb.Core.Data.BoundedContext;

namespace FBRxweb.BoundedContext.Main
{
    public class FacebookContext : BaseBoundedContext, IFacebookContext
    {
        public FacebookContext(MainSqlDbContext sqlDbContext,  IOptions<DatabaseConfig> databaseConfig, IHttpContextAccessor contextAccessor,ITenantDbConnectionInfo tenantDbConnection): base(sqlDbContext, databaseConfig.Value, contextAccessor,tenantDbConnection){ }

            #region DbSets
            		public DbSet<FacebookUser> FacebookUser { get; set; }
            #endregion DbSets


    }


    public interface IFacebookContext : IDbContext
    {
    }
}

