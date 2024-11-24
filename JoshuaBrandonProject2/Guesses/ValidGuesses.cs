using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JoshuaBrandonProject2.Guesses
{
    public class ValidGuesses :Guesses
    {
        public int Points { get; set; }

        public ValidGuesses(string wordGuessed, int timeGuessesed, int points) : base(wordGuessed, timeGuessesed)
        {
            Points = points;
        }

        public override string ToString()
        {
            return base.ToString() + " Points: " + Points; 
        }
    }
}
