using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Test.Models;
using Test.Models.Repositories;

namespace Test.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PostsController : ControllerBase
    {
        private readonly IPostRepository<Post> repo;

        public PostsController(IPostRepository<Post> repo)
        {
            this.repo = repo;
        }

        // GET: api/Posts
        [HttpGet]
        public IEnumerable<Post> GetPosts()
        {
            return repo.getUserTweets();
        }

        // POST: api/Posts/tweet
        [HttpPost("tweet", Name = "PostTweet")]
        public IActionResult PostTweet([FromBody] CreatePost post)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

             repo.writeTweet(post);

            return Ok();            
        }

        // POST: api/Posts/comments
        [HttpPost("comment", Name = "PostComment")]
        public IActionResult PostComment([FromBody] CreateComment comment)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            repo.writeComment(comment);

            return Ok();
        }
    }

}