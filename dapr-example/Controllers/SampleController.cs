using System.Threading.Tasks;
using Dapr;
using dapr_example.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace dapr_example.Controllers
{
    [ApiController]
    public class SampleController : ControllerBase
    {
        private readonly ILogger<SampleController> _logger;

        public SampleController(ILogger<SampleController> logger)
        {
            _logger = logger;
        }


        [Topic("notify")]
        [HttpPost("notify")]
        public async Task<ActionResult<NotifyMessage>> Notify(NotifyMessage message)
        {
            return message;
        }
    }
}