using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JoshuaBrandonProject2.ReadDictionary
{
    public class DictionaryReader
    {
        public char letter { get; set; }
        public List<string> words { get; set; }
        

        public DictionaryReader(char letter, List<string> words)
        {
            this.letter = letter;
            this.words = words;
        }
    }
}
