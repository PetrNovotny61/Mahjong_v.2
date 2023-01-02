using System;
using System.Windows.Forms;

namespace Mahjong
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

  

        private void button4_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 hra = new Form2();
            this.Hide();
            hra.ShowDialog();
            this.Close();
        }

  
    }
}
