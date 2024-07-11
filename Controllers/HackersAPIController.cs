using HackersAPICore.Interface;
using HackersAPICore.Service;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace HackersAPICore.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HackersAPIController : ControllerBase
    {
        private readonly IHackerService _hackerService;
        public HackersAPIController(IHackerService hackersAPIService)
        {
            _hackerService = hackersAPIService;
        }

        // GET: api/<ValuesController>
        [HttpGet]
        [Route("GetStories")]
        public IActionResult Get()
        {
            return Ok(_hackerService.GetStories());
        }       
    }
}
