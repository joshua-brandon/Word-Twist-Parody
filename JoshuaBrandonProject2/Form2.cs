using JoshuaBrandonProject2.Random_Letters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JoshuaBrandonProject2
{
    public partial class Form2 : Form
    {
        public List<char> wordGuess = new();
        public RandomLetters randomLetters = new RandomLetters();
        public string submitedGuess = "";
        public string lettersChosen = "";
        public int points = 0;
        public Form2()
        {
            InitializeComponent();
            randomLetters.draw();
            button1.Text = randomLetters.Drawn[0].ToString();
            button2.Text = randomLetters.Drawn[1].ToString();
            button3.Text = randomLetters.Drawn[2].ToString();
            button4.Text = randomLetters.Drawn[3].ToString();
            button5.Text = randomLetters.Drawn[4].ToString();
            button6.Text = randomLetters.Drawn[5].ToString();
            button7.Text = randomLetters.Drawn[6].ToString();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            wordGuess.Add(randomLetters.Drawn[0]);
            lettersChosen = lettersChosen + randomLetters.Drawn[0];
            label1.Text = lettersChosen;
            button1.Enabled = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            wordGuess.Add(randomLetters.Drawn[1]);
            lettersChosen = lettersChosen + randomLetters.Drawn[1];
            label1.Text = lettersChosen;
            button2.Enabled = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            wordGuess.Add(randomLetters.Drawn[2]);
            lettersChosen = lettersChosen + randomLetters.Drawn[2];
            label1.Text = lettersChosen;
            button3.Enabled = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            wordGuess.Add(randomLetters.Drawn[3]);
            lettersChosen = lettersChosen + randomLetters.Drawn[3];
            label1.Text = lettersChosen;
            button4.Enabled = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            wordGuess.Add(randomLetters.Drawn[4]);
            lettersChosen = lettersChosen + randomLetters.Drawn[4];
            label1.Text = lettersChosen;
            button5.Enabled = false;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            wordGuess.Add(randomLetters.Drawn[5]);
            lettersChosen = lettersChosen + randomLetters.Drawn[5];
            label1.Text = lettersChosen;
            button6.Enabled = false;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            wordGuess.Add(randomLetters.Drawn[6]);
            lettersChosen = lettersChosen + randomLetters.Drawn[6];
            label1.Text = lettersChosen;
            button7.Enabled = false;
        }

        private void enterButton_Click(object sender, EventArgs e)
        {
            submitedGuess = "";
            foreach (var letter in wordGuess)
            {
                submitedGuess = submitedGuess + letter;
            }

            if (submitedGuess.Length < 3)
            {
                messageLabel.Text = "Guess must be longer than 3 letters";
                button1.Enabled = true;
                button2.Enabled = true;
                button3.Enabled = true;
                button4.Enabled = true;
                button5.Enabled = true;
                button6.Enabled = true;
                button7.Enabled = true;
                lettersChosen = "";
                submitedGuess = "";
                wordGuess.Clear();
            }
            else
            {
                if (submitedGuess.Length == 3)
                {
                    points = 90;
                }

                if (submitedGuess.Length == 4)
                {
                    points = 160;
                }

                if (submitedGuess.Length == 5)
                {
                    points = 250;
                }

                if (submitedGuess.Length == 6)
                {
                    points = 360;
                }

                if (submitedGuess.Length == 7)
                {
                    points = 490;
                }
                messageLabel.Text = "Guess submitted";
                button1.Enabled = true;
                button2.Enabled = true;
                button3.Enabled = true;
                button4.Enabled = true;
                button5.Enabled = true;
                button6.Enabled = true;
                button7.Enabled = true;

                lettersChosen = "";
                submitedGuess = "";
                wordGuess.Clear();
            }
            
            
        }
    }
}
