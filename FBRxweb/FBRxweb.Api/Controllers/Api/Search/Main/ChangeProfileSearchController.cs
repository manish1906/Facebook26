using System.Collections.Generic;
using Microsoft.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RxWeb.Core.Data;
using FBRxweb.Models.ViewModels;
using FBRxweb.BoundedContext.SqlContext;
namespace FBRxweb.Api.Controllers.FacebookModule
{
    [ApiController]
	[Route("api/[controller]")]
    public class SearchChangeProfileController : ControllerBase
    {
        private IDbContextManager<MainSqlDbContext> DbContextManager { get; set; }
        public SearchChangeProfileController(IDbContextManager<MainSqlDbContext> dbContextManager) {
            DbContextManager = dbContextManager;
        }

		[HttpPost]
        public async Task<IActionResult> Post([FromBody]Dictionary<string,string> searchParams)
        {
            var spParameters = new SqlParameter[2];
            spParameters[0] = new SqlParameter() { ParameterName = "photo", Value = searchParams["photo"] };
            spParameters[1] = new SqlParameter() { ParameterName = "id", Value = searchParams["id"] };
            var result = await DbContextManager.StoreProc<StoreProcResult>("[dbo].spChangeProfilePhoto", spParameters);
            return Ok(result.SingleOrDefault()?.Result);
        }
    }
}
