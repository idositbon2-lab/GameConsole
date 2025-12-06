using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameConsole.Models
{
    internal class HighScore
    {
        public string gamename;
        public int score;
        public DateTime shana;
        public HighScore(string gamename, int score, DateTime shana)
        {
            this.gamename = gamename;
            this.score = score;
            this.shana = DateTime.Now;
        }

    }
}
