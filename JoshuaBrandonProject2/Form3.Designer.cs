namespace JoshuaBrandonProject2
{
    partial class Form3
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
            scorringWordsListBox = new ListBox();
            totalPointsLabel = new Label();
            SuspendLayout();
            // 
            // scorringWordsListBox
            // 
            scorringWordsListBox.FormattingEnabled = true;
            scorringWordsListBox.Location = new Point(201, 51);
            scorringWordsListBox.Name = "scorringWordsListBox";
            scorringWordsListBox.Size = new Size(389, 284);
            scorringWordsListBox.TabIndex = 0;
            // 
            // totalPointsLabel
            // 
            totalPointsLabel.AutoSize = true;
            totalPointsLabel.Location = new Point(299, 357);
            totalPointsLabel.Name = "totalPointsLabel";
            totalPointsLabel.Size = new Size(88, 20);
            totalPointsLabel.TabIndex = 1;
            totalPointsLabel.Text = "Total Points:";
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(totalPointsLabel);
            Controls.Add(scorringWordsListBox);
            Name = "Form3";
            Text = "Text Twist By Brandon";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox scorringWordsListBox;
        private Label totalPointsLabel;
    }
}