using System.Collections.Generic;
using ConsoleForum.Contracts;

namespace ConsoleForum.Entities.Posts
{
    class Question:IQuestion
    {
        public Question(int id, string body, IUser author, string title)
        {
            Title = title;
            Author = author;
            Body = body;
            Id = id;
            Answers = new List<IAnswer>();
        }

        public int Id { get; set; }
        public string Body { get; set; }
        public IUser Author { get; set; }
        public string Title { get; set; }
        public IList<IAnswer> Answers { get; private set; }
    }
}
