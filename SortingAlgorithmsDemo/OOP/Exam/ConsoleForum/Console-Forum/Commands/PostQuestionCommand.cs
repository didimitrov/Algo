using ConsoleForum.Commands.Exceptions;
using ConsoleForum.Contracts;
using ConsoleForum.Entities.Posts;

namespace ConsoleForum.Commands
{
    class PostQuestionCommand:AbstractCommand
    {
        public PostQuestionCommand(IForum forum) : base(forum)
        {
        }

        public override void Execute()
        {
            var questions = this.Forum.Questions;
            var title = this.Data[1];
            var body = this.Data[2];

            if (!Forum.IsLogged)
            {
                throw new CommandException(Messages.NotLogged);
            }

            var question = new Question((questions.Count + 1), body, Forum.CurrentUser, title);
            questions.Add(question);
            this.Forum.Output.AppendLine(string.Format(Messages.PostQuestionSuccess, question.Id));
        }
    }
}
