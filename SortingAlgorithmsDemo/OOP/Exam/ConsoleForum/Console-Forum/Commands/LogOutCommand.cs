using ConsoleForum.Commands.Exceptions;
using ConsoleForum.Contracts;

namespace ConsoleForum.Commands
{
    class LogOutCommand:AbstractCommand
    {
        public LogOutCommand(IForum forum) : base(forum)
        {
        }

        public override void Execute()
        {
            if (!this.Forum.IsLogged)
            {
                throw new CommandException(Messages.NotLogged);
            }
            this.Forum.CurrentUser = null;
            this.Forum.Output.AppendLine(Messages.LogoutSuccess);

            //close open question
            this.Forum.CurrentQuestion = null;
        }
    }
}
