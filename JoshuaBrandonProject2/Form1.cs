using JoshuaBrandonProject2.Random_Letters;

namespace JoshuaBrandonProject2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        private void playGameButton_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.ShowDialog();
            
        }
    }
}
