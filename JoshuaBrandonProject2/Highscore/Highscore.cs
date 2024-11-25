using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JoshuaBrandonProject2.Highscore
{
    public class Highscore
    {
        public string Name { get; set; }

        public int Time { get; set; }
        public int Score { get; set; }

        public Highscore(string name, int time, int score)
        {
            Name = name;
            Time = time;
            Score = score;
        }

        public override string ToString()
        {
            return "Name: " + Name + " Time: " + Time + " Score: " + Score;
        }
    }
}
