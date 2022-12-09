using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ICL.Mediator.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GrnController : ControllerBase
    {
        [HttpPost]
        public async Task<IActionResult> ReceiveGRN()
        {
            // send middle ware
            return Ok();
        }
    }
}
