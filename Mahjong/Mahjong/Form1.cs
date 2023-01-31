using DocumentFormat.OpenXml.Office.CustomXsn;
using System;
using System.Drawing;
using System.IO;
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
            //Form2.instance.name = textBox1.Text;
            var screenWidth = Screen.PrimaryScreen.Bounds.Width;
            var screenHeight = Screen.PrimaryScreen.Bounds.Height;

            this.Hide();
            Form2 game = new Form2();
            game.Size = new Size(screenWidth, screenHeight);
            game.ShowDialog();
            this.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            StreamReader sw = new StreamReader("..\\..\\..\\data.txt");
            int score = Convert.ToInt32(sw.ReadLine());
            int pocet = Convert.ToInt32(sw.ReadLine());

            Form2 game = new Form2();
            Close();



        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form4 score = new Form4();
            score.ShowDialog();
            this.Close();

        }
    }
}
