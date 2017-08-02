using System;
using System.Drawing;
using System.Windows.Forms;

namespace Flat_Load
{
    public partial class Form1 : Form
    {
        private int percent = 0;

        public Form1()
        {
            InitializeComponent();
        }
        
        private void timer1_Tick(object sender, EventArgs e)
        {
            this.percent++;
            string percentString = this.percent.ToString();

            label2.Text = percentString + "%";

            if (this.percent == 100)
            {
                label1.Text = "Flat Load - Done";
                label2.ForeColor = Color.FromArgb(100, 200, 100);
                timer1.Enabled = false;
            }
        }
    }
}