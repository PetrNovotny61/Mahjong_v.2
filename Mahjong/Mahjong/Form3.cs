using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mahjong
{
    public partial class Form3 : Form
    {
        public static Form3 instance;
        public Form3()
        {
            InitializeComponent();
            instance = this;
        }

        private void button_resume_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            Close();
            Form2.instance.f3Close = true;
        }

        private void btn_MainManu_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Close();
            Form2.instance.f3Close = true;
            Form1 mainManu = new Form1();
            mainManu.ShowDialog();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
           int score =  Form2.instance.GetData(out int pocet);

            StreamWriter sw = new StreamWriter("..\\..\\..\\data.txt", append: true);
            sw.WriteLine(score);
            sw.WriteLine(pocet/2);
            sw.Close();
            MessageBox.Show("Hra byla úspěšně uložena!");


        }
    }
}
