using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JoshuaBrandonProject2.Export
{
    public class Export
    {
        public string Name { get; set; }
        public int Time { get; set; }
        public List<Guesses.Guesses> Guesses { get; set; }

        public Export(string name, int time, List<Guesses.Guesses> guesses)
        {
            Guesses = guesses;
            Name = name;
            Time = time;
        }
    }
}
