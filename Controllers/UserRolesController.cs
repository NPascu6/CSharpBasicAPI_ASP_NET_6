using ASP_CORE_BASIC_NET_6_API.Repositories;
using ASP_CORE_BASIC_NET_6_API.Repositories.Interfaces;
using ASP_CORE_BASIC_NET_6_API.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace ASP_CORE_BASIC_NET_6_API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserRolesController : Controller
    {
        private readonly IUserRolesService _userRolesService;

        public UserRolesController(IUserRolesService userRolesService)
        {
            this._userRolesService = userRolesService;
        }


        [HttpGet]
        public IActionResult GetAll()
        {
            var userRoles = _userRolesService.GetAllUserRoles();

            return Ok(userRoles);
        }
    }
}
