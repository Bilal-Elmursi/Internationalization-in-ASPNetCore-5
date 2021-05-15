using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Localization;

namespace InternationalizationDotNetCore.Controllers.Api
{
    [Route("api/[controller]")]
    [ApiController]
    public class LanguageController : ControllerBase
    {
        private readonly IStringLocalizer<LanguageController> _localizer;
        public LanguageController(IStringLocalizer<LanguageController> localizer)
        {
            _localizer = localizer;
        }

        [HttpGet]
        public IActionResult Get()
        {
            const string userName = "Bilal";
            return Ok(_localizer["welcome", userName].Value);
        }
    }
}
