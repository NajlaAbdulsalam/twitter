using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
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
        /// <summary>
        /// Returns a list of the users’ tweets along with their related comments 
        /// </summary>
        /// <returns>
        /// list of posts
        /// </returns>
        [HttpGet]
        public IEnumerable<Post> GetPosts()
        {
            return repo.getUserTweets();
        }

        // POST: api/Posts/tweet
        /// <summary>
        /// Post a new comment for the user
        /// </summary>
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
        /// <summary>
        /// Writes a new comment 
        /// </summary>
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