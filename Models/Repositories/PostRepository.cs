using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Test.Models.Repositories
{
    public class PostRepository : IPostRepository<Post>
    {
        TwitterDBContext db;

        public PostRepository(TwitterDBContext _db)
        {
            db = _db;
        }
        public IList<Post> getUserTweets()
        {
           return db.Posts.Include(a => a.user_id).Where(c=>c.deleted_at!=null).ToList();
        }

        public void writeTweet(CreatePost post)
        {
            var user = db.Users.FirstOrDefault(u=> u.id== post.user_id);

            var newPost = new Post()
            {
                content = post.content,
                created_at = DateTime.Now,
                updated_at = DateTime.Now,
                user_id = user
            };
            db.Posts.Add(newPost);
            db.SaveChanges();
        }
        public void writeComment(CreateComment comment)
        {
            var post = db.Posts.FirstOrDefault(p => p.id == comment.post_id);
            var replied_to = comment.replied_to == null ? null : db.Comments.FirstOrDefault(p => p.id == comment.replied_to);

            var newComment = new Comment()
            {
                content = comment.content,
                created_at = DateTime.Now,
                updated_at = DateTime.Now,
                post_id =post,
                replied_to= replied_to
            };
            db.Comments.Add(newComment);

            db.SaveChanges();
        }
    }
}
