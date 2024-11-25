namespace JoshuaBrandonProject2
{
    partial class Home
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            playGameButton = new Button();
            timeSelectComboBox = new ComboBox();
            nameTextBox = new TextBox();
            exitButton = new Button();
            highScoreButton = new Button();
            nameEnterCheck = new Label();
            enterNameLabel = new Label();
            highscoreCheckLabel = new Label();
            resetHighScoreButton = new Button();
            SuspendLayout();
            // 
            // playGameButton
            // 
            playGameButton.Location = new Point(227, 274);
            playGameButton.Name = "playGameButton";
            playGameButton.Size = new Size(313, 50);
            playGameButton.TabIndex = 0;
            playGameButton.Text = "Play Game";
            playGameButton.UseVisualStyleBackColor = true;
            playGameButton.Click += playGameButton_Click;
            // 
            // timeSelectComboBox
            // 
            timeSelectComboBox.FormattingEnabled = true;
            timeSelectComboBox.Items.AddRange(new object[] { "60", "120", "180" });
            timeSelectComboBox.Location = new Point(255, 155);
            timeSelectComboBox.Name = "timeSelectComboBox";
            timeSelectComboBox.Size = new Size(271, 28);
            timeSelectComboBox.TabIndex = 1;
            timeSelectComboBox.Text = "Select Time in Seconds (Default 120)";
            timeSelectComboBox.SelectedIndexChanged += timeSelectComboBox_SelectedIndexChanged;
            // 
            // nameTextBox
            // 
            nameTextBox.Location = new Point(269, 223);
            nameTextBox.Name = "nameTextBox";
            nameTextBox.Size = new Size(241, 27);
            nameTextBox.TabIndex = 2;
            // 
            // exitButton
            // 
            exitButton.Location = new Point(582, 350);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(188, 55);
            exitButton.TabIndex = 3;
            exitButton.Text = "Exit";
            exitButton.UseVisualStyleBackColor = true;
            exitButton.Click += exitButton_Click;
            // 
            // highScoreButton
            // 
            highScoreButton.Location = new Point(24, 350);
            highScoreButton.Name = "highScoreButton";
            highScoreButton.Size = new Size(187, 55);
            highScoreButton.TabIndex = 4;
            highScoreButton.Text = "High Scores";
            highScoreButton.UseVisualStyleBackColor = true;
            highScoreButton.Click += highScoreButton_Click;
            // 
            // nameEnterCheck
            // 
            nameEnterCheck.AutoSize = true;
            nameEnterCheck.Location = new Point(287, 251);
            nameEnterCheck.Name = "nameEnterCheck";
            nameEnterCheck.RightToLeft = RightToLeft.No;
            nameEnterCheck.Size = new Size(0, 20);
            nameEnterCheck.TabIndex = 5;
            // 
            // enterNameLabel
            // 
            enterNameLabel.AutoSize = true;
            enterNameLabel.Location = new Point(333, 200);
            enterNameLabel.Name = "enterNameLabel";
            enterNameLabel.Size = new Size(87, 20);
            enterNameLabel.TabIndex = 6;
            enterNameLabel.Text = "Enter Name";
            // 
            // highscoreCheckLabel
            // 
            highscoreCheckLabel.AutoSize = true;
            highscoreCheckLabel.Location = new Point(167, 418);
            highscoreCheckLabel.Name = "highscoreCheckLabel";
            highscoreCheckLabel.Size = new Size(0, 20);
            highscoreCheckLabel.TabIndex = 7;
            // 
            // resetHighScoreButton
            // 
            resetHighScoreButton.Location = new Point(287, 350);
            resetHighScoreButton.Name = "resetHighScoreButton";
            resetHighScoreButton.Size = new Size(212, 55);
            resetHighScoreButton.TabIndex = 8;
            resetHighScoreButton.Text = "Reset Highscore";
            resetHighScoreButton.UseVisualStyleBackColor = true;
            resetHighScoreButton.Click += resetHighScoreButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(resetHighScoreButton);
            Controls.Add(highscoreCheckLabel);
            Controls.Add(enterNameLabel);
            Controls.Add(nameEnterCheck);
            Controls.Add(highScoreButton);
            Controls.Add(exitButton);
            Controls.Add(nameTextBox);
            Controls.Add(timeSelectComboBox);
            Controls.Add(playGameButton);
            Name = "Form1";
            Text = "Text Twist By Brandon";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button playGameButton;
        private ComboBox timeSelectComboBox;
        private TextBox nameTextBox;
        private Button exitButton;
        private Button highScoreButton;
        private Label nameEnterCheck;
        private Label enterNameLabel;
        private Label highscoreCheckLabel;
        private Button resetHighScoreButton;
    }
}
