namespace JoshuaBrandonProject2
{
    partial class Highscores
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            highScoreListBox = new ListBox();
            scoreSortButton = new Button();
            timeAndScoreSortButton = new Button();
            exitButton = new Button();
            SuspendLayout();
            // 
            // highScoreListBox
            // 
            highScoreListBox.FormattingEnabled = true;
            highScoreListBox.Location = new Point(235, 84);
            highScoreListBox.Name = "highScoreListBox";
            highScoreListBox.Size = new Size(351, 264);
            highScoreListBox.TabIndex = 0;
            // 
            // scoreSortButton
            // 
            scoreSortButton.Location = new Point(140, 365);
            scoreSortButton.Name = "scoreSortButton";
            scoreSortButton.Size = new Size(128, 61);
            scoreSortButton.TabIndex = 1;
            scoreSortButton.Text = "Sort By Score";
            scoreSortButton.UseVisualStyleBackColor = true;
            scoreSortButton.Click += scoreSortButton_Click;
            // 
            // timeAndScoreSortButton
            // 
            timeAndScoreSortButton.Location = new Point(333, 365);
            timeAndScoreSortButton.Name = "timeAndScoreSortButton";
            timeAndScoreSortButton.Size = new Size(128, 61);
            timeAndScoreSortButton.TabIndex = 2;
            timeAndScoreSortButton.Text = "Sort By Time And Score";
            timeAndScoreSortButton.UseVisualStyleBackColor = true;
            timeAndScoreSortButton.Click += timeAndScoreSortButton_Click;
            // 
            // exitButton
            // 
            exitButton.Location = new Point(518, 365);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(128, 61);
            exitButton.TabIndex = 3;
            exitButton.Text = "Home";
            exitButton.UseVisualStyleBackColor = true;
            exitButton.Click += exitButton_Click;
            // 
            // Highscores
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(exitButton);
            Controls.Add(timeAndScoreSortButton);
            Controls.Add(scoreSortButton);
            Controls.Add(highScoreListBox);
            Name = "Highscores";
            Text = "Text Twist By Brandon";
            ResumeLayout(false);
        }

        #endregion

        private ListBox highScoreListBox;
        private Button scoreSortButton;
        private Button timeAndScoreSortButton;
        private Button exitButton;
    }
}