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
            SuspendLayout();
            // 
            // playGameButton
            // 
            playGameButton.Location = new Point(235, 176);
            playGameButton.Name = "playGameButton";
            playGameButton.Size = new Size(313, 50);
            playGameButton.TabIndex = 0;
            playGameButton.Text = "Play Game";
            playGameButton.UseVisualStyleBackColor = true;
            playGameButton.Click += playGameButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(playGameButton);
            Name = "Form1";
            Text = "Text Twist By Brandon";
            ResumeLayout(false);
        }

        #endregion

        private Button playGameButton;
    }
}
