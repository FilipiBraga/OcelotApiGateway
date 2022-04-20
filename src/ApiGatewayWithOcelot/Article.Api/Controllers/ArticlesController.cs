using Article.Api.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Article.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ArticlesController : ControllerBase
    {
        private readonly ArticleRepository _articleRepository;
        public ArticlesController()
        {
            _articleRepository = new();
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_articleRepository.GetAll());
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            return Ok(_articleRepository.Get(id));
        }
    }
}
