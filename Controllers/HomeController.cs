using HNGProjectTaskOneAPI.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HNGProjectTaskOneAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IHNGStudentsService _studentsService;

        public HomeController(ILogger<HomeController> logger, IHNGStudentsService studentsService)
        {
            _logger = logger;
            _studentsService = studentsService;
        }


        [HttpGet]
        public async Task<IActionResult> Get()
        {
            try
            {
                var hngStudents = await _studentsService.GetAllHNGStudents();
                return Ok(hngStudents);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, ex.Message);
                return StatusCode(StatusCodes.Status500InternalServerError, "Error retrieving data from the database");
            }
        }
    }
}
