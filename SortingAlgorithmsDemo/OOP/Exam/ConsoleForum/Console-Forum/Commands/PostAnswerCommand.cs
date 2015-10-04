using ConsoleForum.Commands.Exceptions;
using ConsoleForum.Contracts;
using ConsoleForum.Entities.Posts;

namespace ConsoleForum.Commands
{
    class PostAnswerCommand:AbstractCommand
    {
        public PostAnswerCommand(IForum forum) : base(forum)
        {
        }

        public override void Execute()
        {
            var body = Data[1];
            var question = this.Forum.CurrentQuestion;

            if (!Forum.IsLogged)
            {
                throw new CommandException(Messages.NotLogged);
            }
            if (question==null)
            {
                throw new CommandException(Messages.NoQuestion);
            }

            var answer = new Answer((Forum.Answers.Count + 1), body, Forum.CurrentUser);
            Forum.Answers.Add(answer);
            question.Answers.Add(answer);
            this.Forum.Output.AppendLine(string.Format(Messages.PostAnswerSuccess, answer.Id));
        }
    }
}
