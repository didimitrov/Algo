using System.Linq;
using ConsoleForum.Commands.Exceptions;
using ConsoleForum.Contracts;
using ConsoleForum.Entities.Posts;

namespace ConsoleForum.Commands
{
    class MakeBestAnswerCommand:AbstractCommand
    {
        public MakeBestAnswerCommand(IForum forum) : base(forum)
        {
        }

        public override void Execute()
        {
            int answerId = int.Parse(this.Data[1]);
            var question = this.Forum.CurrentQuestion;

            if (!this.Forum.IsLogged)
            {
                throw new CommandException(Messages.NotLogged);
            }
            if (this.Forum.CurrentQuestion == null)
            {
                throw new CommandException(Messages.NoQuestionOpened);
            }
            if (!question.Answers.Any(a => a.Id == answerId))
            {
                throw new CommandException(Messages.NoAnswer);
            }
            if (question.Author != this.Forum.CurrentUser && !(this.Forum.CurrentUser is IAdministrator))
            {
                throw new CommandException(Messages.NoPermission);
            }
            if (question.Answers.Any(a => a is BestAnswer))
            {
                int currentBestID = question.Answers.Where(a => a is BestAnswer).FirstOrDefault().Id;
                Answer oldBest = new Answer(currentBestID, question.Answers[currentBestID - 1].Body, question.Answers[currentBestID - 1].Author);
                question.Answers[currentBestID - 1] = oldBest;
            }
            IAnswer answer = question.Answers.FirstOrDefault(a => a.Id == answerId);
            BestAnswer bestAnswer = new BestAnswer(answer.Id, answer.Body, answer.Author);
            question.Answers[answerId - 1] = bestAnswer;
            this.Forum.Output.AppendLine(string.Format(Messages.BestAnswerSuccess, answerId));
        }
    }
}
