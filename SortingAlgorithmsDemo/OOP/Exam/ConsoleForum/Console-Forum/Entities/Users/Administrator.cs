﻿using System.Collections.Generic;
using ConsoleForum.Contracts;

namespace ConsoleForum.Entities.Users
{
    class Administrator:User,IAdministrator
    {
        public Administrator(int id, string name, string password, string email)
            : base(id, name, password, email)
        {
        }
    }
}
