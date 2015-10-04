using ConsoleForum.Contracts;

namespace ConsoleForum.Entities.Posts
{
    class Answer:IAnswer
    {
        public Answer(int id, string body, IUser author)
        {
            Author = author;
            Body = body;
            Id = id;
        }

        public int Id { get; set; }
        public string Body { get; set; }
        public IUser Author { get; set; }
    }
}
