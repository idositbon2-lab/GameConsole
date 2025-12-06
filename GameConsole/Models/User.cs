using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameConsole.Models
{
    internal class User
    {
        public string username;
        public string name;
        public string password;
        public List<HighScore> highscores;
        public User(string username, string password, string name)
        {
            this.username = username;
            this.password = password;
            this.name = name;
            this.highscores = new List<HighScore>();
        }

    }
}
