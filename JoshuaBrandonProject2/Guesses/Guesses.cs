using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JoshuaBrandonProject2.Guesses
{
    /// <summary>
    /// The Guesses class
    /// </summary>
    public class Guesses
    {
        /// <summary>
        /// The WordEntered string
        /// </summary>
        public string WordEntered { get; set; }
        /// <summary>
        /// The TimeEntered int
        /// </summary>
        public int TimeEntered { get; set; }
        /// <summary>
        /// The Default constructor
        /// </summary>
        /// <param name="wordEntered"></param>
        /// <param name="timeEntered"></param>
        public Guesses(string wordEntered, int timeEntered)
        {
            WordEntered = wordEntered;
            TimeEntered = timeEntered;
        }
        /// <summary>
        /// The ToString Override
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return ("Word: " + WordEntered + ", Time: " + TimeEntered);
        }
    }


}
