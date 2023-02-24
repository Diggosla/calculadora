using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculadora
{
    public partial class Form1 : Form
    {
            decimal valor1 = 0, valor2 = 0;
            string operacao = "";

        public Form1()
        {
            ;
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            TextBoxResultado.Text += "8";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
            if ( TextBoxResultado.Text != "")
            {
                valor1 = decimal.Parse(TextBoxResultado.Text,CultureInfo.InvariantCulture);
               TextBoxResultado.Text = "";
                operacao = "SOMA";
                labeloperacao.Text = "+";
            }
            else
            {
                MessageBox.Show("Informe um valor para efetuar a soma");
                   }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            TextBoxResultado.Text += "9";
        }

        private void button18_Click(object sender, EventArgs e)
        {
            TextBoxResultado.Text = "/";
        }

        private void button17_Click(object sender, EventArgs e)
        {
            TextBoxResultado.Text = ".";
        }

        private void button16_Click(object sender, EventArgs e)
        {
            TextBoxResultado.Text += "0";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            
        }

        private void button14_Click(object sender, EventArgs e)
        {
            TextBoxResultado.Text = "*";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            TextBoxResultado.Text += "3";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            TextBoxResultado.Text += "2";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            TextBoxResultado.Text += "1";
        }

        private void button10_Click(object sender, EventArgs e)
        {
           
        }

        private void button9_Click(object sender, EventArgs e)
        {
            TextBoxResultado.Text += "-";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            TextBoxResultado.Text += "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            TextBoxResultado.Text += "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            TextBoxResultado.Text += "4";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TextBoxResultado.Text += "7";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelopercao_Click(object sender, EventArgs e)
        {

        }
    }
}
