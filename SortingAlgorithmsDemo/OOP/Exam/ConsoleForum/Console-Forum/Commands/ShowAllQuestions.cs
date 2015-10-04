using System;
using System.Linq;
using ConsoleForum.Commands.Exceptions;
using ConsoleForum.Contracts;

namespace ConsoleForum.Commands
{
    class ShowAllQuestions:AbstractCommand
    {
        public ShowAllQuestions(IForum forum) : base(forum)
        {
        }

        public override void Execute()
        {
            if (this.Forum.Questions.Count==0)
            {
                throw new CommandException(Messages.NoQuestions);
            }

            var orderedQuestions = this.Forum.Questions.OrderByDescending(x => x.Id);

            foreach (var q in orderedQuestions)
            {
                this.Forum.Output.AppendLine(q.ToString());
            }
        }
    }
}
