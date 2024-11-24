using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JoshuaBrandonProject2.Random_Letters
{
    public class RandomLetters
    {
        public List<char> Bag = new();
        public List<char> Drawn = new();

        public RandomLetters()
        {
            for (int i = 0; i < 11; i++)
            {
                Bag.Add('e');
            }

            for (int i = 0; i < 9; i++)
            {
                Bag.Add('t');
            }

            for (int i = 0; i < 8; i++)
            {
                Bag.Add('o');
            }

            for (int i = 0; i < 6; i++)
            {
                Bag.Add('a');
                Bag.Add('i');
                Bag.Add('n');
                Bag.Add('s');
            }

            for (int i = 0; i < 5; i++)
            {
                Bag.Add('h');
                Bag.Add('r');
            }

            for (int i = 0; i < 4; i++)
            {
                Bag.Add('l');
            }

            for (int i = 0; i < 3; i++)
            {
                Bag.Add('d');
                Bag.Add('u');
                Bag.Add('w');
                Bag.Add('y');
            }

            for (int i = 0; i < 2; i++)
            {
                Bag.Add('b');
                Bag.Add('c');
                Bag.Add('f');
                Bag.Add('g');
                Bag.Add('m');
                Bag.Add('p');
                Bag.Add('v');
            }

            Bag.Add('j');
            Bag.Add('k');
            Bag.Add('q');
            Bag.Add('x');
            Bag.Add('z');
        }

        public void draw()
        {
            Drawn.Clear();
            Random random = new Random();
            
            for (int i = 0; i < 7; i++)
            {
                int randomNumber = random.Next(0, Bag.Count);
                Drawn.Add(Bag[randomNumber]);
                Bag.Remove(Bag[randomNumber]);
            }

            foreach (var letter in Drawn)
            {
                Bag.Add(letter);
            }
        }
    }
}
