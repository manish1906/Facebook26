using Microsoft.AspNetCore.Mvc;
using System.Linq;
using FBRxweb.Domain.CoverPhotoModule;
using FBRxweb.Models.Main;
using RxWeb.Core.AspNetCore;
using RxWeb.Core.Security.Authorization;

namespace FBRxweb.Api.Controllers.CoverPhotoModule
{
    [ApiController]
    [Route("api/[controller]")]
	
	public class CoverPhotoesController : BaseDomainController<CoverPhoto, CoverPhoto>

    {
        public CoverPhotoesController(ICoverPhotoDomain domain):base(domain) {}

    }
}
