using Microsoft.AspNetCore.Mvc;

namespace LR4.Controllers
{
    [ApiController]
    [Route("test")]
    public class WeatherForecastController: Controller
    {
        [HttpPost]
        [HttpGet]
        [Produces("application/json")]
        [Route("index")]
        public async Task<IActionResult> Index()
        {
            return this.Json(new { result = "Hello World" });
        }

        [HttpPost]
        [HttpGet]
        [Produces("application/json")]
        [Route("hello_world")]
        public async Task<IActionResult> Test()
        {
            Response res = new Response();
            res.Name = "Alex";
            res.Surname = "Trubkina";
            res.Version = 1.1;
            return this.Json(res);
        }
    }
    
}