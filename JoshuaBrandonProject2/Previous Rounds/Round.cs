using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JoshuaBrandonProject2.Previous_Rounds
{
    /// <summary>
    /// The Round Class
    /// </summary>
    public class Round
    {
        /// <summary>
        /// The RoundNumber int
        /// </summary>
        public int RoundNumber { get; set; }
        /// <summary>
        /// The Name string
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// The Time Int
        /// </summary>
        public int Time { get; set; }
        /// <summary>
        /// The Guesses List
        /// </summary>
        public List<Guesses.Guesses> Guesses { get; set; }
        /// <summary>
        /// The Default Constructor
        /// </summary>
        /// <param name="roundNumber"></param>
        /// <param name="name"></param>
        /// <param name="time"></param>
        /// <param name="guesses"></param>
        public Round(int roundNumber, string name, int time, List<Guesses.Guesses> guesses)
        {
            RoundNumber = roundNumber;
            Name = name;
            Time = time;
            Guesses = guesses;
        }
    }
}
