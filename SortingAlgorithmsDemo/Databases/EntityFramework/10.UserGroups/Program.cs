﻿using System;
using System.Text.RegularExpressions;
using System.Transactions;

namespace _10.UserGroups
{
    class Program
    {
        /* Run the 11.CreateDB.sql first to create the DB. The file is in the app directory. */

        public static void InsertUser(string userName)
        {
            //using (TransactionScope scope = new TransactionScope())
            //{
            //    using (GroupsEntities context = new GroupsEntities())
            //    {
            //        Group adminGroup = new Group { GroupName = "Admins" };
            //        if (context.Groups.Count(x => x.GroupName == "Admins") == 0)
            //        {
            //            context.Groups.Add(adminGroup);
            //            context.SaveChanges();
            //            scope.Complete();
            //        }
            //        else
            //        {
            //            if (context.Users.Count(x => x.UserName == userName) > 0)
            //            {
            //                Console.WriteLine("User already exists.");
            //                scope.Dispose();
            //            }

            //            Group currentgroup = context.Groups
            //                .Where(x => x.GroupName == "Adminss").First();

            //            User newUser = new User()
            //            {
            //                UserName = userName,
            //                GroupID = currentgroup.GroupID
            //            };

            //            context.Users.Add(newUser);
            //            context.SaveChanges();
            //            scope.Complete();
            //        }
            //    }
            //}

        }
        static void Main(string[] args)
        {
            InsertUser("Kolio madoto");
        }
    }
}
