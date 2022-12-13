using ASP_CORE_BASIC_NET_6_API.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace ASP_CORE_BASIC_NET_6_API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AssetsController : Controller
    {
        private readonly IAssetsService _assetService;

        public AssetsController(IAssetsService assetService)
        {
            _assetService = assetService;
        }

        [HttpGet]
        public IActionResult GetAllAssets()
        {
            var assets = _assetService.GetAllAssets();
            return Ok(assets);
        }
    }
}
