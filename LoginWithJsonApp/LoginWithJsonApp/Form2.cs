using System;
using System.Windows.Forms;

namespace LoginWithJsonApp
{
    public partial class Form2 : Form
    {
        private int seconds = 0;

        public Form2()
        {
            InitializeComponent();
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            seconds++;
            lblTimer.Text = "Timer: " + seconds + " seconds";
            if (seconds == 20)
            {
                Close();
            }
        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            seconds = 0;
            lblTimer.Text = "Timer: 0 seconds";

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }



}
