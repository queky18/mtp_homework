using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculare_Factorial_Adrian_Gheorghe
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            this.textBox1.Text += "0";
        }

        private void btnClk1(object sender, EventArgs e)
        {
            this.textBox1.Text += "1";
        }

        private void btnClk7(object sender, EventArgs e)
        {
            this.textBox1.Text += "2";
        }

        private void btnClk6(object sender, EventArgs e)
        {
            this.textBox1.Text += "3";
        }

        private void btnClk4(object sender, EventArgs e)
        {
            this.textBox1.Text += "4";
        }

        private void btnClk3(object sender, EventArgs e)
        {
            this.textBox1.Text += "5";
        }

        private void btnClk5(object sender, EventArgs e)
        {
            this.textBox1.Text += "6";
        }

        private void btnClk2(object sender, EventArgs e)
        {
            this.textBox1.Text += "7";
        }

        private void btnClk8(object sender, EventArgs e)
        {
            this.textBox1.Text += "8";
        }

        private void btnClk9(object sender, EventArgs e)
        {
            this.textBox1.Text += "9";
        }

        private void btnClk11(object sender, EventArgs e)
        {
            string textExpus = textBox1.Text;
            // avoid ArgumentOutOfRangeException
            if ((textExpus.Length - 1) > -1)  textExpus = textExpus.Remove(textExpus.Length - 1);

            this.textBox1.Text = textExpus;
        }

        private void btnClk12(object sender, EventArgs e)
        {
            int i = 0;
            string str = this.textBox1.Text;
            string st = "";

            this.textBox1.Clear();
            try
            {
                i = Int32.Parse(str);
            } // Format Exception thrown by Int32.Parse
            catch (FormatException)
            {
                Console.WriteLine("Format Exception!");
            }
            
            // Check if > 169
            if (i > 169) st = "Less than 169"; else
            {
                double d = factorial(i);
                st = Convert.ToString(d);
            }

            this.textBox2.Text = st; 
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private double factorial(int nr)
        {
            double rezultat = 1;
            for (int i = 1; i <= nr; i++) rezultat = rezultat * i;

            return rezultat;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void splitContainer1_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }
    }
}
