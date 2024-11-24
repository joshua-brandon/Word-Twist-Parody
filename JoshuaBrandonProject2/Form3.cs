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
    }
}
