using System;
using System.Drawing;
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
            var screenWidth = Screen.PrimaryScreen.Bounds.Width;
            var screenHeight = Screen.PrimaryScreen.Bounds.Height;

            this.Hide();
            Form2 game = new Form2();
            game.Size = new Size(screenWidth, screenHeight);
            game.ShowDialog();
            this.Close();
        }

  
    }
}
