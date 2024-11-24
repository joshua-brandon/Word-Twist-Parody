using JoshuaBrandonProject2.Random_Letters;

namespace JoshuaBrandonProject2
{
    public partial class Form1 : Form
    {
        public static int comboboxSelected = 120;

        public Form1()
        {
            InitializeComponent();

        }

        private void playGameButton_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.ShowDialog();

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
    }
}
