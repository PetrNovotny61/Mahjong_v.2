using DocumentFormat.OpenXml.Office.CustomXsn;
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Mahjong
{
    public partial class Form1 : Form
    {

        public static Form1 instance;
        public Form1()
        {
            InitializeComponent();
            instance= this;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Close();
        }

        virtual public string Get_Name()
        {
            string jmeno = textBox1.Text;
            return jmeno;
        }
        

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text.Length ==0)
            {
                MessageBox.Show("Zadej jméno!");
            }
            else
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

        virtual public int Load_game(out int n)
        {
            n = this.pocet;
            return this.score;
        }


        int score = 0;
        int pocet = 0;
        private void button6_Click(object sender, EventArgs e)
        {
            string path = "..\\..\\..\\data.txt";
            StreamReader sr = new StreamReader(path);
            score = Convert.ToInt32(sr.ReadLine());
            pocet = Convert.ToInt32(sr.ReadLine());
            sr.Close();

            Form2 game = new Form2();
            game.ShowDialog();
            this.Close();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form4 score = new Form4();
            score.ShowDialog();
            this.Close();

        }
    }
}
