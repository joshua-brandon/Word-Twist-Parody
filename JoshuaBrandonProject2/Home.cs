using JoshuaBrandonProject2.Random_Letters;
using System.Text.Json;

namespace JoshuaBrandonProject2
{
    public partial class Home : Form
    {
        public static int comboboxSelected = 120;
        public static string name = "";

        public Home()
        {
            InitializeComponent();

        }

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

        private void exitButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void highScoreButton_Click(object sender, EventArgs e)
        {
            var filePath =
                @"C:\Users\joshu\Downloads\JoshuaBrandonProject2\JoshuaBrandonProject2\Data\highscore.json";
            StreamReader r = new StreamReader(filePath);
            string json = r.ReadToEnd();
            List<Highscore.Highscore>? highscoreList = JsonSerializer.Deserialize<List<Highscore.Highscore>>(json) ?? new List<Highscore.Highscore>();
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

        private void resetHighScoreButton_Click(object sender, EventArgs e)
        {
            
            var filePath =
                    @"C:\Users\joshu\Downloads\JoshuaBrandonProject2\JoshuaBrandonProject2\Data\highscore.json";
            StreamReader r = new StreamReader(filePath);
            string json = r.ReadToEnd();
            r.Close();
            List <Highscore.Highscore> highscoreList = JsonSerializer.Deserialize<List<Highscore.Highscore>>(json) ?? new List<Highscore.Highscore>();
            highscoreList.Clear();
            string jsonData = JsonSerializer.Serialize(highscoreList);
            File.WriteAllText(filePath, jsonData);

            
        }
    }
}
