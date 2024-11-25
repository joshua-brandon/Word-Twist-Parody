using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JoshuaBrandonProject2.ReadDictionary
{
    /// <summary>
    /// The DictionaryReader class
    /// </summary>
    public class DictionaryReader
    {
        public char letter { get; set; }
        public List<string> words { get; set; }
        

        /// <summary>
        /// The default constructor
        /// </summary>
        /// <param name="letter"></param>
        /// <param name="words"></param>
        public DictionaryReader(char letter, List<string> words)
        {
            this.letter = letter;
            this.words = words;
        }
    }
}
