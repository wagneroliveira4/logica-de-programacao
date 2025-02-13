using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculadora
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // 1. pegar o valor do textbox tbxN1
            double n1 = Convert.ToDouble(tbxN1.Text);
            // 2. pegar o valor do textbox tbxN2
            double n2 = Convert.ToDouble(tbxN2.Text);
            // 3. Somar
            double resultado = n1 + n2;
            // 4. Inserir o resultado no tbxResultado
            tbxResultado.Text = resultado.ToString();


        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void tbxN2_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbxResultado_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbxN1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            double n1 = Convert.ToDouble(tbxN1.Text);
            double n2 = Convert.ToDouble(tbxN2.Text);
            double resultado = n1 - n2;
            tbxResultado.Text = resultado.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double n1 = Convert.ToDouble(tbxN1.Text);
            double n2 = Convert.ToDouble(tbxN2.Text);
            double resultado = n1 / n2;
            tbxResultado.Text = resultado.ToString();
        }
    }
}
