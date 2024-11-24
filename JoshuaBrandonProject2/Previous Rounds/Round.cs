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
        public List<Guesses.Guesses> Guesses { get; set; }

        public Round(int roundNumber, List<Guesses.Guesses> guesses)
        {
            RoundNumber = roundNumber;
            Guesses = guesses;
        }
    }
}
