using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JoshuaBrandonProject2.Guesses
{
    /// <summary>
    /// The InvalidGuess Class
    /// </summary>
    public class InvalidGuesses : Guesses
    {
        /// <summary>
        /// The IncorrectReason string
        /// </summary>
        public string IncorrectReason { get; set; }
        /// <summary>
        /// The Default Constructor
        /// </summary>
        /// <param name="wordEntered"></param>
        /// <param name="timeEntered"></param>
        /// <param name="incorrectReason"></param>
        public InvalidGuesses(string wordEntered,int timeEntered,string incorrectReason) : base(wordEntered, timeEntered)
        {
            IncorrectReason = incorrectReason;
        }
        /// <summary>
        /// The ToString Override
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return base.ToString() + " Reason Incorrect: " + IncorrectReason ;
        }
    }
}
