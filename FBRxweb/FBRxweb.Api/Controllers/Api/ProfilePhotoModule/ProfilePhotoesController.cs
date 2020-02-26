using Microsoft.AspNetCore.Mvc;
using System.Linq;
using FBRxweb.Domain.ProfilePhotoModule;
using FBRxweb.Models.Main;
using RxWeb.Core.AspNetCore;
using RxWeb.Core.Security.Authorization;

namespace FBRxweb.Api.Controllers.ProfilePhotoModule
{
    [ApiController]
    [Route("api/[controller]")]
	
	public class ProfilePhotoesController : BaseDomainController<ProfilePhoto, ProfilePhoto>

    {
        public ProfilePhotoesController(IProfilePhotoDomain domain):base(domain) {}

    }
}
