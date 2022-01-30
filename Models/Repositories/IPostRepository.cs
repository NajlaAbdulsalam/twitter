using System.Collections.Generic;

namespace Test.Models.Repositories
{
    public interface IPostRepository<TEntity>
    {
        IList<TEntity> getUserTweets();
        void writeTweet(CreatePost post);
        void writeComment(CreateComment post);
    }
}
