using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using TibekBlog.Models;
using TibekBlog.Services;

namespace TibekBlog.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PostsController : ControllerBase
    {
        private readonly ILogger _logger;
        private readonly PostService _postService;

        public PostsController(ILogger<PostsController> logger, PostService postService)
        {
            _logger = logger;
            _postService = postService;
        }

        // GET api/values
        [HttpGet]
        public ActionResult<List<Post>> Get()
        {
            _logger.LogDebug("Get all posts");

            return _postService.Get();
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            _logger.LogDebug("Getting item {ID}", id);

            return "value";
        }

        // POST api/values
        [HttpPost]
        public ActionResult<Post> Create([FromBody] Post post)
        {
            _postService.Create(post);

            return CreatedAtRoute("GetPost", new { id = post.Id.ToString() }, post);
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
