using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Test.Models.Repositories
{
    public interface IPostRepository<TEntity>
    {
        IList<TEntity> getUserTweets();
        void writeTweet(CreatePost post);
        void writeComment(CreateComment post);
    }
}
