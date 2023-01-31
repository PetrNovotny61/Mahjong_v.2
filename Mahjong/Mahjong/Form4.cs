using Microsoft.Win32;
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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        string[] pole= null;
        private void Form4_Load(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            StreamReader sr = new StreamReader("..\\..\\..\\score.txt");
            int radky = File.ReadAllLines("..\\..\\..\\score.txt").Count();
            pole = new string[radky];

            while (!sr.EndOfStream)
            {
                for (int i = 0; i < pole.Length; i++)
                {
                    string radek = sr.ReadLine();
                    pole[i] = radek;
                    listBox1.Items.Add(radek);
                }
            }
            sr.Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            Array.Sort(pole);
            for(int i = 0; i< pole.Length; i++)
            {
                listBox1.Items.Add(pole[i]);
            }
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            Array.Sort(pole);
            for (int i = 0; i < pole.Length; i++)
            {
                listBox1.Items.Add(pole[i]);
            }

        }
    }
}
