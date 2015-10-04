using System.Linq;
using ConsoleForum.Commands.Exceptions;
using ConsoleForum.Contracts;
using ConsoleForum.Utility;

namespace ConsoleForum.Commands
{
    class LoginCommand:AbstractCommand
    {
        public LoginCommand(IForum forum) : base(forum)
        {
        }

        public override void Execute()
        {
            var users = this.Forum.Users;
            var userName = this.Data[1];
            var password = PasswordUtility.Hash(Data[2]);

            if (this.Forum.IsLogged)
            {
                throw new CommandException(Messages.AlreadyLoggedIn);
            }
            if (!users.Any(x => x.Username==userName && x.Password==password))
            {
                throw new CommandException(Messages.InvalidLoginDetails);
            }

            this.Forum.CurrentUser = users.FirstOrDefault(x => x.Username == userName && x.Password == password);
            this.Forum.Output.AppendLine(string.Format(Messages.LoginSuccess, this.Forum.CurrentUser.Username));
        }
    }
}
