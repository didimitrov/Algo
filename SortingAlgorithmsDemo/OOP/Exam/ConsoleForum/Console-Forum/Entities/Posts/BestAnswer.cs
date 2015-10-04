using ConsoleForum.Contracts;

namespace ConsoleForum.Entities.Posts
{
    class BestAnswer : Answer
    {
        public BestAnswer(int id, string body, IUser author)
            : base(id, body, author)
        {
        }
    }
    
}
