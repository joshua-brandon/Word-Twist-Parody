using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JoshuaBrandonProject2.Previous_Rounds
{
    public class Round
    {
        public int RoundNumber { get; set; }
        public string Name { get; set; }
        public int Time { get; set; }
        public List<Guesses.Guesses> Guesses { get; set; }

        public Round(int roundNumber, string name, int time, List<Guesses.Guesses> guesses)
        {
            RoundNumber = roundNumber;
            Name = name;
            Time = time;
            Guesses = guesses;
        }
    }
}
