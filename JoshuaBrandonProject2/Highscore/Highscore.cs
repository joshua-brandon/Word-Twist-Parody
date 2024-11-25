using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JoshuaBrandonProject2.Highscore
{
    /// <summary>
    /// the Highscore class
    /// </summary>
    public class Highscore
    {
        /// <summary>
        /// The Name String
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// The Time Int
        /// </summary>
        public int Time { get; set; }
        /// <summary>
        /// The Score Int
        /// </summary>
        public int Score { get; set; }
        /// <summary>
        /// The Default constructor
        /// </summary>
        /// <param name="name"></param>
        /// <param name="time"></param>
        /// <param name="score"></param>
        public Highscore(string name, int time, int score)
        {
            Name = name;
            Time = time;
            Score = score;
        }
        /// <summary>
        /// The ToString Override
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return "Name: " + Name + " Time: " + Time + " Score: " + Score;
        }
    }
}
