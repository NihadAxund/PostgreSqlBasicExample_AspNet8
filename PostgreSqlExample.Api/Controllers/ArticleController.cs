using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PostgreSqlExample.Api.Request;
using PostgreSqlExample.Data;
using PostgreSqlExample.Data.Entities;

namespace PostgreSqlExample.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ArticleController : ControllerBase
    {
        private readonly PostgreSqlExampleDbContext _postgreSqlExampleDbContext;

        public ArticleController(PostgreSqlExampleDbContext postgreSqlExampleDbContext)
        {
            _postgreSqlExampleDbContext = postgreSqlExampleDbContext;
        }
        [HttpPost("add")]
        public IActionResult Add([FromBody] AtricleRequestModel request)
        {
            try
            {
                var model = new Article(request.Title, request.Description);

                _postgreSqlExampleDbContext.Add(model);
                _postgreSqlExampleDbContext.SaveChanges();

                return Ok("Changes saved.");
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"An error occurred during the operation: {ex.Message}");
            }
        }

    }
}
