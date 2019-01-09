using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zad2
{
    
    public partial class Form1 : Form
    {
        string pojam;
        public Form1()
        {
            InitializeComponent();
        }

        public void Form1_Shown(object sender, EventArgs e)
        {
            string[] pojmovi = System.IO.File.ReadAllLines(@"D:\STVARI\AaaFAX\3. SEMESTAR\OOP\Programi\Analize labosa\LV-6\Zad2\Zad2\pojmovi.txt");
            Random rnd = new Random((int)DateTime.Now.Ticks);
            int num = rnd.Next(21);
            pojam = pojmovi[num];
            Console.Write(pojam.Length);
            Console.Write(", ");
            Console.WriteLine(pojam);

            foreach (char c in pojam)
            {
                pojam_lbl.Text += ".";
            }
            
        }




        public void provjera_btn_Click(object sender, EventArgs e)
        {
            string ch = char_tb.Text;
            char cha = ch[0];
            int ind = 20; //, count = 0;
            string expresion = pojam_lbl.ToString();
            StringBuilder sb = new StringBuilder(expresion);
            int m = int.Parse(counter_lbl.Text);
            bool istina = false;
            
            for (int i = 0; i < pojam.Length; i++)
            {
                if (cha == pojam[i])
                {
                    istina = true;
                    ind = i + 34;
                    sb.Replace(".", cha.ToString(), ind, 1);
                }

                pojam_lbl.Text = "";

                for (int j = 34; j < 34+pojam.Length; j++)
                {
                    pojam_lbl.Text += sb[j];
                }
		// imao sam problema s stringBuilderom. Nije se ispravno prikazivalo na Label-u
            }

            if (istina == false)
            {
                if (m > 0)
                    counter_lbl.Text = (m - 1).ToString();
                if (m == 1)
                {
                    MessageBox.Show("Izgubili ste!", "Poraz!");
                    sljedeci_btn_Click(sender, e);
                }
            }

            if (pojam_lbl.Text == pojam)
            {
                MessageBox.Show("Čestitam! Pogodili ste.", "Poruka");
                sljedeci_btn_Click(sender, e);
            }
                


        }

        private void prijedlog_btn_Click(object sender, EventArgs e)
        {
            int m = int.Parse(counter_lbl.Text);
            if (cijeli_tb.Text == pojam)
            {
                pojam_lbl.Text = pojam.ToString();
                MessageBox.Show("Čestitam! Pojam je točan.", "Poruka");
                sljedeci_btn_Click(sender, e);
            }
            else
            {
                if (m > 0)
                    counter_lbl.Text = (m - 1).ToString();
                if (m == 1)
                    MessageBox.Show("Izgubili ste!", "Poraz!");
            }
            
        }

        private void sljedeci_btn_Click(object sender, EventArgs e)
        {
            string[] pojmovi = System.IO.File.ReadAllLines(@"D:\STVARI\AaaFAX\3. SEMESTAR\OOP\Programi\Analize labosa\LV-6\Zad2\Zad2\pojmovi.txt");
            Random rnd = new Random((int)DateTime.Now.Ticks);
            int num = rnd.Next(22);
            pojam = pojmovi[num];
            Console.Write(pojam.Length);
            Console.Write(", ");
            Console.WriteLine(pojam);
            pojam_lbl.Text = "";
            foreach (char c in pojam)
            {
                pojam_lbl.Text += ".";
            }
            cijeli_tb.Clear();
            char_tb.Clear();
            counter_lbl.Text = "6";
        }
    }
}
