using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JoshuaBrandonProject2
{
    /// <summary>
    /// the Highscore Form
    /// </summary>
    public partial class Highscores : Form
    {
        /// <summary>
        /// The Highscore list
        /// </summary>
        private List<Highscore.Highscore> highscoreList = new();
        /// <summary>
        /// The default Constructor
        /// </summary>
        public Highscores()
        {
            InitializeComponent();
            var filePath =
                @"C:\Users\joshu\Downloads\JoshuaBrandonProject2\JoshuaBrandonProject2\Data\highscore.json";
            StreamReader r = new StreamReader(filePath);
            string json = r.ReadToEnd();
            highscoreList = JsonSerializer.Deserialize<List<Highscore.Highscore>>(json) ?? new List<Highscore.Highscore>();

            if (highscoreList != null)
            {
                foreach (var highscore in highscoreList)
                {
                    if (highscore.Time != 0)
                    {
                        highScoreListBox.Items.Add(highscore).ToString();
                    }
                }
            }
            r.Close();
        }
        /// <summary>
        /// the scoreSort button Click action
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void scoreSortButton_Click(object sender, EventArgs e)
        {
            highScoreListBox.Items.Clear();
            highscoreList.Sort((x, y) => x.Score.CompareTo(y.Score));
            foreach (var highscore in highscoreList)
            {
                if (highscore.Time != 0)
                {
                    highScoreListBox.Items.Add(highscore).ToString();
                }
            }

        }
        /// <summary>
        /// The exit button action
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void exitButton_Click(object sender, EventArgs e)
        {
            Close();
        }
        /// <summary>
        /// The time and score sort button action
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timeAndScoreSortButton_Click(object sender, EventArgs e)
        {
            highScoreListBox.Items.Clear();
            var newHigscoreList = highscoreList.OrderBy(a => a.Time).ThenBy(a => a.Score);
            foreach (var highscore in newHigscoreList)
            {
                if (highscore.Time != 0)
                {
                    highScoreListBox.Items.Add(highscore).ToString();
                }
            }
        }

    }
}
