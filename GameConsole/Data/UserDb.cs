using GameConsole.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameConsole.Data
{
    internal class UserDb
    {
        private static List<Models.User> Users = new List<Models.User>();

        public static User RegisterUser(string name, string uName, string password)
        {
            if (Users.Any(u => u.username == uName))
            {
                throw new InvalidOperationException("the name is allredy been taken");
            }
            User newus = new User(name, uName, password);
            Users.Add(newus);
            return newus;
        }

        public static User Login(string name, string password)
        {

            return Users.FirstOrDefault(u => u.username == name && u.password == password);

        }

        public static void Update(User u)


        { 
            if (Users.Any(user => user == u))
            {

                Users.Where(user => user == u).FirstOrDefault().password = null;
                Users.Where(user => user == u).FirstOrDefault().name = null;
            }
            else

                throw new InvalidOperationException("no user like that");
        }


    }
}
