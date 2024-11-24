using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JoshuaBrandonProject2.Guesses
{
    public class InvalidGuesses : Guesses
    {
        public string IncorrectReason { get; set; }

        public InvalidGuesses(string wordEntered,int timeEntered,string incorrectReason) : base(wordEntered, timeEntered)
        {
            IncorrectReason = incorrectReason;
        }
    }
}
