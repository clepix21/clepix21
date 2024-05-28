using System;
using System.Windows.Forms;

namespace WinFormsApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonOpenForm_Click(object sender, EventArgs e)
        {
            Random random = new Random();

            for (int i = 0; i < 25; i++)
            {
                Form2 form2 = new Form2();
                form2.StartPosition = FormStartPosition.Manual;
                form2.Location = new Point(random.Next(Screen.PrimaryScreen.Bounds.Width - form2.Width), random.Next(Screen.PrimaryScreen.Bounds.Height - form2.Height));
                form2.Show();
            }
        }
        private void buttonOpenForm2_Click_1(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();

        }
    }
}
