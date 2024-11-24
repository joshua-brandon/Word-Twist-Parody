using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JoshuaBrandonProject2.Guesses
{
    public class Guesses
    {
        public string WordEntered { get; set; }
        public int TimeEntered { get; set; }

        public Guesses(string wordEntered, int timeEntered)
        {
            WordEntered = wordEntered;
            TimeEntered = timeEntered;
        }

        public override string ToString()
        {
            return ("Word: " + WordEntered + ", Time: " + TimeEntered);
        }
    }


}
