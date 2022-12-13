using ASP_CORE_BASIC_NET_6_API.Repositories.Interfaces;
using ASP_CORE_BASIC_NET_6_API.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace ASP_CORE_BASIC_NET_6_API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserDetailsController : Controller
    {
        private readonly IUserDetailsService _userDetailsService;

        public UserDetailsController(IUserDetailsService userDetailsService)
        {
            this._userDetailsService = userDetailsService;
        }

        [HttpGet]
        public IActionResult GetAllUserDetails()
        {
            var users = _userDetailsService.GetAllUserDetails();
            return Ok(users);
        }
    }
}