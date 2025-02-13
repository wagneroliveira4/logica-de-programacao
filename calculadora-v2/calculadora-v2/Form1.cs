using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace calculadora_v2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            cbxOperador.Visible = true;
            tbxN1.Visible = true;
            tbxN2.Visible = true;
            tbxResultado.Visible = false;
            label1.Visible = true;
            label2.Visible = true;
            label3.Visible = true;
            label4.Visible  = false;
            button1.Visible = true;
            button2.Visible = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String operador = cbxOperador.Text;
            double n1 = Convert.ToDouble(tbxN1.Text);
            double n2 = Convert.ToDouble(tbxN2.Text);
            double resultado = 0;

            if (operador == "soma")
                resultado = n1 + n2;
            if (operador == "subtração")
                resultado = n1 - n2;
            if (operador == "multiplicação")
                resultado = n1 * n2;
            if (operador == "divisão")
                resultado = n1 / n2;

            tbxResultado.Text = resultado.ToString();

            cbxOperador.Visible = false;
            tbxN1.Visible = false;
            tbxN2.Visible = false;

            tbxResultado.Visible = true;

            label1.Visible = false;
            label2.Visible = false;
            label3.Visible = false;

            label4.Visible = true;

            button1.Visible = false;
            button2.Visible = true;
        }

        private void cbxOperador_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tbxN1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

            cbxOperador.Visible = true;
            tbxN1.Visible = true;
            tbxN2.Visible = true;

            tbxResultado.Visible = false;

            label1.Visible = true;
            label2.Visible = true;
            label3.Visible = true;

            label4.Visible = false;

            button1.Visible = true;
            button2.Visible = false;
        }
    }
}
