using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pontos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            double vitorias = Convert.ToDouble(tbxVitorias.Text);
            double empates = Convert.ToDouble(tbxEmpates.Text);
            double derrotas = Convert.ToDouble(tbxDerrotas.Text);
            double resultado = vitorias * 3 + empates;
            lblResultado.Text = "Pontuação: " + resultado.ToString();
        }
    }
}
