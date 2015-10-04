using System.Linq;
using ConsoleForum.Commands.Exceptions;
using ConsoleForum.Contracts;

namespace ConsoleForum.Commands
{
    class OpenQuestion:AbstractCommand
    {
        public OpenQuestion(IForum forum) : base(forum)
        {
        }

        public override void Execute()
        {
            var questions = this.Forum.Questions;
            var questionId = int.Parse(this.Data[1]);

            if (!questions.Any(x => x.Id == questionId))
            {
                throw new CommandException(Messages.NoQuestion);
            }

            this.Forum.Output.AppendLine(questions.Where(x => x.Id == questionId).FirstOrDefault().ToString());
            this.Forum.CurrentQuestion = questions.FirstOrDefault(x => x.Id == questionId);
        }
    }
}
