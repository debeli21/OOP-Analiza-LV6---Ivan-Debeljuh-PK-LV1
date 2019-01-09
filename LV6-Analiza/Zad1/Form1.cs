using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LV_6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_plus_Click(object sender, EventArgs e)
        {
            double op1 = double.Parse(operand1.Text);
            double op2 = double.Parse(operand2.Text);

            rezultat_lbl.Text = (op1 + op2).ToString();
           
        }

        private void btn_minus_Click(object sender, EventArgs e)
        {
            double op1 = double.Parse(operand1.Text);
            double op2 = double.Parse(operand2.Text);

            rezultat_lbl.Text = (op1 - op2).ToString();
        }

        private void btn_puta_Click(object sender, EventArgs e)
        {
            double op1 = double.Parse(operand1.Text);
            double op2 = double.Parse(operand2.Text);

            rezultat_lbl.Text = (op1 * op2).ToString();
        }

        private void btn_div_Click(object sender, EventArgs e)
        { 
            double op1 = double.Parse(operand1.Text);
            double op2 = double.Parse(operand2.Text);

            if(op2>0)
            rezultat_lbl.Text = (op1 / op2).ToString();
            if (op2 == 0)
                rezultat_lbl.Text = ("Operand 2 mora biti veci od 0!");
        }

        private void btn_sin_Click(object sender, EventArgs e)
        {
            double op1 = double.Parse(operand1.Text);
            
            rezultat_lbl.Text = (Math.Sin(op1).ToString());
        }

        private void btn_cos_Click(object sender, EventArgs e)
        {
            double op1 = double.Parse(operand1.Text);
            
            rezultat_lbl.Text = (Math.Cos(op1).ToString());
        }

        private void btn_log_Click(object sender, EventArgs e)
        { 
            double op1 = double.Parse(operand1.Text);
            if(op1>0)
                rezultat_lbl.Text = (Math.Log10(op1).ToString());
            if (op1 <= 0)
                rezultat_lbl.Text = ("Operand 1 mora biti veci od 0!");
        }

        private void btn_sqrt_Click(object sender, EventArgs e)
        {
            double op1 = double.Parse(operand1.Text);
            if (op1 > 0)
                rezultat_lbl.Text = (Math.Sqrt(op1).ToString());
            if (op1 <= 0)
                rezultat_lbl.Text = ("Operand 1 mora biti veci od 0!");
        }

        private void btn_pow_Click(object sender, EventArgs e)
        {
            double op1 = double.Parse(operand1.Text);
            double op2 = double.Parse(operand2.Text);
            rezultat_lbl.Text = (Math.Pow(op1,op2).ToString());
        }
    }
}
