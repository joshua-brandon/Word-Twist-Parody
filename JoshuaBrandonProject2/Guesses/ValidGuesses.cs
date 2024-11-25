using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JoshuaBrandonProject2.Guesses
{
    /// <summary>
    /// The ValidGuesses class
    /// </summary>
    public class ValidGuesses :Guesses
    {
        /// <summary>
        /// the Points Int
        /// </summary>
        public int Points { get; set; }
        /// <summary>
        /// The default constructor
        /// </summary>
        /// <param name="wordGuessed"></param>
        /// <param name="timeGuessesed"></param>
        /// <param name="points"></param>
        public ValidGuesses(string wordGuessed, int timeGuessesed, int points) : base(wordGuessed, timeGuessesed)
        {
            Points = points;
        }
        /// <summary>
        /// The ToString Override
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return base.ToString() + " Points: " + Points; 
        }
    }
}
