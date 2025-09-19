using Microsoft.AspNetCore.Mvc;

namespace ${{ values.name }}.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class HelloController : ControllerBase
    {
        [HttpGet]
        public ActionResult<string> Get()
        {
            return "Hello from ${{ values.name }}!";
        }
    }
}
