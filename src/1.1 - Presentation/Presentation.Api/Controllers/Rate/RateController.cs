using Microsoft.AspNetCore.Mvc;

namespace Presentation.Api.Controllers.Rate
{
    [ApiController]
    [Route("fee")]
    public class RateController : ControllerBase
    {
        private readonly ILogger<RateController> _logger;

        public RateController(ILogger<RateController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "recommended-transaction-fees")]
        public IActionResult Get()
        {
            return Ok();
        }

        [HttpGet(Name = "transaction-fees-summary")]
        public IActionResult GetTransactionFeesSummary()
        {
            return Ok();
        }
    }
}