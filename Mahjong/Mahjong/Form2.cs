using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;


namespace Mahjong
{
    public partial class Form2 : Form
    {
        public static Form2 instance;
        public bool f3Close = false;

        public Form2()
        {
            InitializeComponent();
            instance = this;
            label6.Text = lvl.ToString();
        }

        private int counter;
        Timer t = new Timer();
        List<Button> buttons = new List<Button>();

        private void Form2_Load(object sender, EventArgs e)
        {
            Screen Srn = Screen.PrimaryScreen;
            this.Width = Srn.Bounds.Width;
            this.Height = Srn.Bounds.Height;
            this.WindowState = FormWindowState.Maximized;

            CreateButtons(70);
            InitializeTimer();
        }

        //**************************************************************************************************
        //**********************Generování*****************************
        private Random rnd = new Random();

        public void Shuffle(List<Button> list)
        {
            int n = list.Count;
            while (n > 1)
            {
                n--;
                int k = rnd.Next(n + 1);
                Button value = list[k];
                list[k] = list[n];
                list[n] = value;
            }
            return;
        }

        void CreateButtons(int n)
        {
            int id = 1;
            int pocet = 0;
            for (int i = 1; i <= n; i++)
            {
                if (pocet == 10)
                {
                    pocet = 0;
                    id = 1;
                }

                Button btn = new Button();
                btn.Text = id.ToString();
                btn.Click += Kliknuti;
                buttons.Add(btn);
                Button btn2 = new Button();
                btn2.Text = id.ToString();
                btn2.Click += Kliknuti;
                buttons.Add(btn2);
                pocet++;
                id++;
            }

            Shuffle(buttons);
            int a = 100, b = 40;
            int j = 0;
            foreach (Button btn in buttons)
            {
                btn.BackColor = Color.LightBlue;
                j++;
                btn.Width = 75;
                btn.Height = 65;
                btn.Location = new Point(a, b);
                Controls.Add(btn);
                panel1.Controls.Add(btn);
                a += 76;
                if (j == 14)
                {
                    j = 0;
                    b += 66;
                    a = 100;
                }
            }
        }
        //**************************************************************************************************
        //*********************************Time*****************************************************************
        private void InitializeTimer()
        {
            if(lvl==1)
            t.Interval = 4000;
            else
                t.Interval = 2000;
            t.Enabled = true;
            t.Tick += new EventHandler(timer1_Tick);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (counter < 1200)
            {
                counter++;
                progressBar1.Value--;
                int cas = progressBar1.Value;
                label3.Text = cas.ToString();
            }
            else
            {
                t.Enabled = false;
            }

            if (progressBar1.Value == 0)
            {
                timer1.Stop();   
                progressBar1.Enabled = false;
                DialogResult msg = MessageBox.Show("Čas Vypršel!");

                if (msg == DialogResult.OK)
                {
                    this.Close();
                }
            }
        }
        //**************************************************************************************************
        //**********************************Spojování******************************************
        int score = 0;

        //level--------
        int lvl = 1;
        int pocetNalezenych = 0;
        private void Form2_MouseDown(object sender, MouseEventArgs e)
        { }
        Button first;
        bool click = true;
        private void Kliknuti(object sender, EventArgs e)
        {
            click = !click;

            if (click == true)
            {
                Button second = (Button)sender;
                if (first.Text == second.Text && first != second)
                {
                    panel1.Controls.Remove(first);
                    panel1.Controls.Remove(second);

                    //podminka pro spojování obrázků pomocí tzv. spojnic


                    pocetNalezenych+=2;
                    if(lvl == 1)
                    {
                        score = score + 15;
                    }
                    else
                        score +=30;
                }
            }
            else
                first = (Button)sender;

            if (pocetNalezenych == 70)
            {
                MessageBox.Show("Další Úroveň");
                CreateButtons(70);
                lvl++;
                label6.Text = lvl.ToString();
                pocetNalezenych = 0;
            }

            label2.Text = score.ToString();
        }
        //**************************************************************************************************
        //*************************Shuffle*******************************
        private void button1_Click(object sender, EventArgs e)
        {
            int pocet = 0;
            foreach (Control ctrl in panel1.Controls)
            {
                if (ctrl is Button)
                {
                    pocet++;
                }
            }
            panel1.Controls.Clear();
            buttons.Clear();
            CreateButtons(pocet / 2);
        }
        //**************************************************************************************************
        //**************************Menu/Pause**************************************
        private void button2_Click(object sender, EventArgs e)
        {
            Hide();
            Form3 pause = new Form3();
            pause.ShowDialog();
            if(f3Close)
            {
                Close();
            }
            else
            {
                Show();
            }     
        }

    }
}