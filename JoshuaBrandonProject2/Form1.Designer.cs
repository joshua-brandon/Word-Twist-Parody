namespace JoshuaBrandonProject2
{
    partial class Form1
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
            timeSelectComboBox.Location = new Point(255, 153);
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
            nameTextBox.Text = "Enter Name";
            // 
            // exitButton
            // 
            exitButton.Location = new Point(295, 351);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(181, 53);
            exitButton.TabIndex = 3;
            exitButton.Text = "Exit";
            exitButton.UseVisualStyleBackColor = true;
            exitButton.Click += exitButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
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
    }
}
