using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Writer.Api.Repositories;

namespace Writer.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WritersController : ControllerBase
    {
        private readonly WriterRepository _writerRepository;

        public WritersController()
        {
            _writerRepository = new();
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_writerRepository.GetAll());
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            return Ok(_writerRepository.Get(id));
        }
    }
}
