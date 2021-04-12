using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers{
     [ApiController]
    [Route("[controller]")]

    public class FuncionarioController : ControllerBase{
        [HttpGet]
        public IActionResult Get()
        {
        return Ok("Lucas");
        }
    }

}