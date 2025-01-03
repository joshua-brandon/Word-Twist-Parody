﻿using JoshuaBrandonProject2.Random_Letters;
using System.Text.Json;
using JoshuaBrandonProject2.Guesses;
using JoshuaBrandonProject2.Previous_Rounds;
using JoshuaBrandonProject2.ReadDictionary;
using Timer = System.Windows.Forms.Timer;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace JoshuaBrandonProject2
{
    /// <summary>
    /// The Game Form
    /// </summary>
    public partial class Game : Form
    {
        /// <summary>
        /// The wordGuess List
        /// </summary>
        public List<char> wordGuess = new();
        /// <summary>
        /// The guessedWords List
        /// </summary>
        public List<string> guessedWords = new();
        /// <summary>
        /// The highscoreList List
        /// </summary>
        public List<Highscore.Highscore> highscoreList = new();
        /// <summary>
        /// The AllValidGuessesList List
        /// </summary>
        public static List<Guesses.ValidGuesses> AllValidGuessesList = new List<ValidGuesses>();
        /// <summary>
        /// The AllInvalidGuessesList List
        /// </summary>
        public List<Guesses.InvalidGuesses> AllInvalidGuessesList = new List<InvalidGuesses>();
        /// <summary>
        /// The AllGuessesList List
        /// </summary>
        public static List<Guesses.Guesses> AllGuessesList = new List<Guesses.Guesses>();
        /// <summary>
        /// The RandomLetters
        /// </summary>
        public RandomLetters randomLetters = new RandomLetters();
        /// <summary>
        /// The submitedGuess string
        /// </summary>
        public string submitedGuess = "";
        /// <summary>
        /// the lettersChosen string
        /// </summary>
        public string lettersChosen = "";
        /// <summary>
        /// the points int
        /// </summary>
        public int points = 0;
        /// <summary>
        /// the pointTotal int
        /// </summary>
        public static int pointTotal = 0;
        /// <summary>
        /// the Timer
        /// </summary>
        private readonly Timer AppTimer;
        /// <summary>
        /// The currentTime int
        /// </summary>
        private int CurrentTime;
        /// <summary>
        /// the Random rng
        /// </summary>
        private static Random rng = new Random();
        /// <summary>
        /// the default constructor
        /// </summary>
        public Game()
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
            CurrentTime = (int)Home.comboboxSelected;
            timeRemainingLabel.Text = CurrentTime.ToString();
            pointTotal = 0;
            totalPointsLabel.Text = "Total Points: " + pointTotal;
            AppTimer = new Timer();
            AppTimer.Interval = 1000;
            AppTimer.Tick += TimerOnTick;
            AppTimer.Start();
        }
        /// <summary>
        /// The Timer
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TimerOnTick(object? sender, EventArgs e)
        {
            CurrentTime--;
            timeRemainingLabel.Text = CurrentTime.ToString();

            if (CurrentTime <= 0)
            {
                AppTimer.Stop();
                button1.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
                button5.Enabled = false;
                button6.Enabled = false;
                button7.Enabled = false;
                Round round = new Round(Home.RoundList.Count + 1, Home.name, Home.comboboxSelected, AllGuessesList);
                Home.RoundList.Add(round);
                Score f3 = new Score();
                f3.ShowDialog();
                var filePath =
                    @"C:\Users\joshu\Downloads\JoshuaBrandonProject2\JoshuaBrandonProject2\Data\highscore.json";
                StreamReader r = new StreamReader(filePath);
                string json = r.ReadToEnd();
                highscoreList = JsonSerializer.Deserialize<List<Highscore.Highscore>>(json)?? new List<Highscore.Highscore>();
                Highscore.Highscore highscore = new Highscore.Highscore(Home.name, Home.comboboxSelected, pointTotal);
                if (highscore != null)
                {
                    highscoreList.Add(highscore);
                }
                r.Close();
                string jsonData = JsonSerializer.Serialize(highscoreList);
                File.WriteAllText(filePath,jsonData);
                AllGuessesList.Clear();
                AllInvalidGuessesList.Clear();
                AllValidGuessesList.Clear();
                Close();
            }
        }
        /// <summary>
        /// The button1 click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            wordGuess.Add(randomLetters.Drawn[0]);
            lettersChosen = lettersChosen + randomLetters.Drawn[0];
            label1.Text = lettersChosen;
            button1.Enabled = false;
            twistButton.Enabled = false;
        }
        /// <summary>
        /// The button2 click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            wordGuess.Add(randomLetters.Drawn[1]);
            lettersChosen = lettersChosen + randomLetters.Drawn[1];
            label1.Text = lettersChosen;
            button2.Enabled = false;
            twistButton.Enabled = false;
        }
        /// <summary>
        /// the button3 click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button3_Click(object sender, EventArgs e)
        {
            wordGuess.Add(randomLetters.Drawn[2]);
            lettersChosen = lettersChosen + randomLetters.Drawn[2];
            label1.Text = lettersChosen;
            button3.Enabled = false;
            twistButton.Enabled = false;
        }
        /// <summary>
        /// the button4 click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button4_Click(object sender, EventArgs e)
        {
            wordGuess.Add(randomLetters.Drawn[3]);
            lettersChosen = lettersChosen + randomLetters.Drawn[3];
            label1.Text = lettersChosen;
            button4.Enabled = false;
            twistButton.Enabled = false;
        }
        /// <summary>
        /// the button5 click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button5_Click(object sender, EventArgs e)
        {
            wordGuess.Add(randomLetters.Drawn[4]);
            lettersChosen = lettersChosen + randomLetters.Drawn[4];
            label1.Text = lettersChosen;
            button5.Enabled = false;
            twistButton.Enabled = false;
        }
        /// <summary>
        /// the button6 click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button6_Click(object sender, EventArgs e)
        {
            wordGuess.Add(randomLetters.Drawn[5]);
            lettersChosen = lettersChosen + randomLetters.Drawn[5];
            label1.Text = lettersChosen;
            button6.Enabled = false;
            twistButton.Enabled = false;
        }
        /// <summary>
        /// the button7 click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button7_Click(object sender, EventArgs e)
        {
            wordGuess.Add(randomLetters.Drawn[6]);
            lettersChosen = lettersChosen + randomLetters.Drawn[6];
            label1.Text = lettersChosen;
            button7.Enabled = false;
            twistButton.Enabled = false;
        }
        /// <summary>
        /// the enterButton click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void enterButton_Click(object sender, EventArgs e)
        {
            submitedGuess = "";
            foreach (var letter in wordGuess)
            {
                submitedGuess = submitedGuess + letter;
            }
            List<DictionaryReader>? wordsList = new List<DictionaryReader>();
            StreamReader r = new StreamReader(@"C:\Users\joshu\Downloads\JoshuaBrandonProject2\JoshuaBrandonProject2\Data\dictionary.json");
            string json = r.ReadToEnd();
            wordsList = JsonSerializer.Deserialize<List<DictionaryReader>>(json);
            bool valid = false;
            bool repeated = false;

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
                twistButton.Enabled = true;
                InvalidGuesses invalidGuess = new Guesses.InvalidGuesses(submitedGuess, CurrentTime, "Guess wasn't long enough");
                AllInvalidGuessesList.Add(invalidGuess);
                AllGuessesList.Add(invalidGuess);
                lettersChosen = "";
                submitedGuess = "";
                wordGuess.Clear();
                label1.Text = "";
            }
            else
            {
                if (wordsList != null)
                {
                    foreach (var letter in wordsList)
                    {
                        char letters = letter.letter;
                        foreach (var word in letter.words)
                        {
                            if (submitedGuess == word)
                            {
                                valid = true;
                            }
                        }

                    }

                    if (valid == true)
                    {
                        foreach (var word in guessedWords)
                        {
                            if (submitedGuess == word)
                            {
                                repeated = true;
                            }
                        }

                        if (repeated == false)
                        {
                            if (submitedGuess.Length == 3)
                            {
                                points = 90;
                                messageLabel.Text = "Guess submitted for 90 points";
                                button1.Enabled = true;
                                button2.Enabled = true;
                                button3.Enabled = true;
                                button4.Enabled = true;
                                button5.Enabled = true;
                                button6.Enabled = true;
                                button7.Enabled = true;
                                twistButton.Enabled = true;
                                pointTotal = pointTotal + points;
                                totalPointsLabel.Text = "Total Points: " + pointTotal.ToString();
                                guessedWords.Add(submitedGuess);
                                ValidGuesses validGuess = new ValidGuesses(submitedGuess, CurrentTime, points);
                                AllValidGuessesList.Add(validGuess);
                                AllGuessesList.Add(validGuess);
                                lettersChosen = "";
                                submitedGuess = "";
                                wordGuess.Clear();
                                label1.Text = "";
                            }

                            if (submitedGuess.Length == 4)
                            {
                                points = 160;
                                messageLabel.Text = "Guess submitted for 160 points";
                                button1.Enabled = true;
                                button2.Enabled = true;
                                button3.Enabled = true;
                                button4.Enabled = true;
                                button5.Enabled = true;
                                button6.Enabled = true;
                                button7.Enabled = true;
                                twistButton.Enabled = true;
                                pointTotal += points;
                                totalPointsLabel.Text = "Total Points: " + pointTotal.ToString();
                                guessedWords.Add(submitedGuess);
                                ValidGuesses validGuess = new ValidGuesses(submitedGuess, CurrentTime, points);
                                AllValidGuessesList.Add(validGuess);
                                AllGuessesList.Add(validGuess);
                                lettersChosen = "";
                                submitedGuess = "";
                                wordGuess.Clear();
                                label1.Text = "";
                            }

                            if (submitedGuess.Length == 5)
                            {
                                points = 250;
                                messageLabel.Text = "Guess submitted for 250 points";
                                button1.Enabled = true;
                                button2.Enabled = true;
                                button3.Enabled = true;
                                button4.Enabled = true;
                                button5.Enabled = true;
                                button6.Enabled = true;
                                button7.Enabled = true;
                                twistButton.Enabled = true;
                                pointTotal = pointTotal + points;
                                totalPointsLabel.Text = "Total Points: " + pointTotal.ToString();
                                guessedWords.Add(submitedGuess);
                                ValidGuesses validGuess = new ValidGuesses(submitedGuess, CurrentTime, points);
                                AllValidGuessesList.Add(validGuess);
                                AllGuessesList.Add(validGuess);
                                lettersChosen = "";
                                submitedGuess = "";
                                wordGuess.Clear();
                                label1.Text = "";
                            }

                            if (submitedGuess.Length == 6)
                            {
                                points = 360;
                                messageLabel.Text = "Guess submitted for 360 points";
                                button1.Enabled = true;
                                button2.Enabled = true;
                                button3.Enabled = true;
                                button4.Enabled = true;
                                button5.Enabled = true;
                                button6.Enabled = true;
                                button7.Enabled = true;
                                twistButton.Enabled = true;
                                pointTotal += points;
                                totalPointsLabel.Text = "Total Points: " + pointTotal.ToString();
                                guessedWords.Add(submitedGuess);
                                ValidGuesses validGuess = new ValidGuesses(submitedGuess, CurrentTime, points);
                                AllValidGuessesList.Add(validGuess);
                                AllGuessesList.Add(validGuess);
                                lettersChosen = "";
                                submitedGuess = "";
                                wordGuess.Clear();
                                label1.Text = "";
                            }

                            if (submitedGuess.Length == 7)
                            {
                                points = 490;
                                messageLabel.Text = "Guess submitted for 490 points";
                                button1.Enabled = true;
                                button2.Enabled = true;
                                button3.Enabled = true;
                                button4.Enabled = true;
                                button5.Enabled = true;
                                button6.Enabled = true;
                                button7.Enabled = true;
                                twistButton.Enabled = true;
                                pointTotal += points;
                                totalPointsLabel.Text = "Total Points: " + pointTotal.ToString();
                                guessedWords.Add(submitedGuess);
                                ValidGuesses validGuess = new ValidGuesses(submitedGuess, CurrentTime, points);
                                AllValidGuessesList.Add(validGuess);
                                AllGuessesList.Add(validGuess);
                                lettersChosen = "";
                                submitedGuess = "";
                                wordGuess.Clear();
                                label1.Text = "";
                            }
                        }
                        if (repeated == true)
                        {
                            messageLabel.Text = "Guess already submitted";
                            button1.Enabled = true;
                            button2.Enabled = true;
                            button3.Enabled = true;
                            button4.Enabled = true;
                            button5.Enabled = true;
                            button6.Enabled = true;
                            button7.Enabled = true;
                            twistButton.Enabled = true;
                            InvalidGuesses invalidGuess = new Guesses.InvalidGuesses(submitedGuess, CurrentTime, "Word was already submitted");
                            AllInvalidGuessesList.Add(invalidGuess);
                            AllGuessesList.Add(invalidGuess);
                            lettersChosen = "";
                            submitedGuess = "";
                            wordGuess.Clear();
                            label1.Text = "";
                        }


                    }
                    if (valid == false)
                    {
                        messageLabel.Text = "Word Not In Dictionary";
                        button1.Enabled = true;
                        button2.Enabled = true;
                        button3.Enabled = true;
                        button4.Enabled = true;
                        button5.Enabled = true;
                        button6.Enabled = true;
                        button7.Enabled = true;
                        twistButton.Enabled = true;
                        InvalidGuesses invalidGuess = new Guesses.InvalidGuesses(submitedGuess, CurrentTime, "Word wasn't in dictionary");
                        AllInvalidGuessesList.Add(invalidGuess);
                        AllGuessesList.Add(invalidGuess);
                        lettersChosen = "";
                        submitedGuess = "";
                        wordGuess.Clear();
                        label1.Text = "";
                    }
                }


            }


        }
        /// <summary>
        /// the twistButton click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void twistButton_Click(object sender, EventArgs e)
        {
            var shuffledcards = randomLetters.Drawn.OrderBy(_ => rng.Next()).ToList();
            randomLetters.Drawn.Clear();
            foreach (var letter in shuffledcards)
            {
                randomLetters.Drawn.Add(letter);
            }
            button1.Text = randomLetters.Drawn[0].ToString();
            button2.Text = randomLetters.Drawn[1].ToString();
            button3.Text = randomLetters.Drawn[2].ToString();
            button4.Text = randomLetters.Drawn[3].ToString();
            button5.Text = randomLetters.Drawn[4].ToString();
            button6.Text = randomLetters.Drawn[5].ToString();
            button7.Text = randomLetters.Drawn[6].ToString();
        }
    }
}
