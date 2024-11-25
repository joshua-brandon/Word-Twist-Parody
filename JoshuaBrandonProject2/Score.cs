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
    /// <summary>
    /// The Score Form
    /// </summary>
    public partial class Score : Form
    {
        /// <summary>
        /// The Default Constructor
        /// </summary>
        public Score()
        {
            InitializeComponent();
            foreach (var guess in Game.AllValidGuessesList)
            {
                scorringWordsListBox.Items.Add(guess.ToString());
            }
            totalPointsLabel.Text = "Total Points: " + Game.pointTotal;
        }
        /// <summary>
        /// The NewGame Button action
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void newGameButton_Click(object sender, EventArgs e)
        {
            Close();
            Game f2 = new Game();
            f2.ShowDialog();


        }
        /// <summary>
        /// The Home button action
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void homeButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
