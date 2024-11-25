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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            foreach (var guess in Form2.AllValidGuessesList)
            {
                scorringWordsListBox.Items.Add(guess.ToString());
            }
            totalPointsLabel.Text = "Total Points: " + Form2.pointTotal;
        }

        private void newGameButton_Click(object sender, EventArgs e)
        {
            Close();
            Form2 f2 = new Form2();
            f2.ShowDialog();


        }

        private void homeButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
