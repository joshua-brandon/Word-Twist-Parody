using JoshuaBrandonProject2.Previous_Rounds;
using JoshuaBrandonProject2.Random_Letters;
using Microsoft.VisualBasic.ApplicationServices;
using System.Text;
using System.Text.Json;
using System.Windows.Forms;

namespace JoshuaBrandonProject2
{
    /// <summary>
    /// The Home Form
    /// </summary>
    public partial class Home : Form
    {
        /// <summary>
        /// The comboboxSelected int
        /// </summary>
        public static int comboboxSelected = 120;
        /// <summary>
        /// The static string name
        /// </summary>
        public static string name = "";
        /// <summary>
        /// The static List RoundList
        /// </summary>
        public static List<Round> RoundList = new List<Round>();

        /// <summary>
        /// The Default Constructor
        /// </summary>
        public Home()
        {
            InitializeComponent();

        }

        /// <summary>
        /// The playGameButton Click Action
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void playGameButton_Click(object sender, EventArgs e)
        {
            if (nameTextBox.Text == null || nameTextBox.Text == "")
            {
                nameEnterCheck.Text = "Please Enter Name First";
            }
            else
            {
                name = nameTextBox.Text;
                Game f2 = new Game();
                f2.ShowDialog();
            }


        }
        /// <summary>
        /// The timeSelectComboBox select action
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timeSelectComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (timeSelectComboBox.SelectedItem != null)
            {
                string? selected = timeSelectComboBox.SelectedItem.ToString();
                if (selected != null)
                {
                    comboboxSelected = Int32.Parse(selected);
                }
            }

        }
        /// <summary>
        /// The exitButton Click action
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void exitButton_Click(object sender, EventArgs e)
        {
            Close();
        }
        /// <summary>
        /// The highScoreButton click action
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void highScoreButton_Click(object sender, EventArgs e)
        {
            var filePath =
                @"C:\Users\joshu\Downloads\JoshuaBrandonProject2\JoshuaBrandonProject2\Data\highscore.json";
            StreamReader r = new StreamReader(filePath);
            string json = r.ReadToEnd();
            List<Highscore.Highscore>? highscoreList = JsonSerializer.Deserialize<List<Highscore.Highscore>>(json) ??
                                                       new List<Highscore.Highscore>();
            if (highscoreList.Count == 0)
            {
                highscoreCheckLabel.Text = "No Highscores, Play A Round First.";
            }
            else
            {
                Highscores f4 = new Highscores();
                f4.ShowDialog();

            }

            r.Close();

        }
        /// <summary>
        /// the resetHighScoreButton click action
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void resetHighScoreButton_Click(object sender, EventArgs e)
        {

            var filePath =
                @"C:\Users\joshu\Downloads\JoshuaBrandonProject2\JoshuaBrandonProject2\Data\highscore.json";
            StreamReader r = new StreamReader(filePath);
            string json = r.ReadToEnd();
            r.Close();
            List<Highscore.Highscore> highscoreList = JsonSerializer.Deserialize<List<Highscore.Highscore>>(json) ??
                                                      new List<Highscore.Highscore>();
            highscoreList.Clear();
            string jsonData = JsonSerializer.Serialize(highscoreList);
            File.WriteAllText(filePath, jsonData);


        }
        /// <summary>
        /// the exportButton click action
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void exportButton_Click(object sender, EventArgs e)
        {
            string path = @"C:\Users\joshu\Downloads\JoshuaBrandonProject2\JoshuaBrandonProject2\Data\Export.json";
            if (RoundList.Count == 0)
            {
                roundCheck.Text = "No Rounds Saved";
            }
            else
            {
                string jsonString = JsonSerializer.Serialize(RoundList);
                if (!File.Exists(path))
                {
                    File.WriteAllText(path, jsonString);
                }

                File.WriteAllText(path, jsonString);

            }
        }
        /// <summary>
        /// the continue button click action
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void continueButton_Click(object sender, EventArgs e)
        {
            string fileName;
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                InitialDirectory = @"D:\",
                Title = "Select a File",

                CheckFileExists = true,
                CheckPathExists = true,

                DefaultExt = "json",
                Filter = "json files (*.json)|*.json",
                FilterIndex = 2,
                RestoreDirectory = true,

                ReadOnlyChecked = true,
                ShowReadOnly = true
            };
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                fileName = openFileDialog1.FileName;

                using (StreamReader r = new StreamReader(fileName))
                {
                    string? json = r.ReadToEnd();
                    List<Round>? rounds = JsonSerializer.Deserialize<List<Round>>(json);
                    if (rounds != null && rounds.Count != 0)
                    {
                        name = rounds[rounds.Count - 1].Name;
                        comboboxSelected = rounds[rounds.Count - 1].Time;
                        Game newGame = new Game();
                        newGame.ShowDialog();
                    }
                }
            }
        }
    }
}
