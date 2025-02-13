using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace media2
{
    public partial class Form1 : Form
    {
        public int cont = 0;
        public Form1()
        {
            InitializeComponent();
            lblRecuperacao.Visible = false;
            tbxRecuperacao.Visible = false;
            btnRecuperacao.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double n1 = Convert.ToDouble(tbxNota1.Text);
            double n2 = Convert.ToDouble(tbxNota2.Text);
            double n3 = Convert.ToDouble(tbxNota3.Text);

            double media = (n1 + n2 + n3) / 3;
            tbxMedia.Text = Math.Round(media).ToString();

            //reprovado 
            if (media < 4)
            {
                lblResultado.ForeColor = Color.Red;
                lblResultado.Text = "Aluno reprovado, sem chance de recuperação ";
            }
            if (media >= 7)
            {
                lblResultado.ForeColor = Color.Blue;
                lblResultado.Text = "Aluno aprovado. ";

            }
            if ((media >= 4) && (media < 7))
            {
                tbxMedia.Text = media.ToString(); 
                lblResultado.ForeColor = Color.Yellow;
                lblResultado.Text = "Recuperação ";

                lblRecuperacao.Visible = true;
                tbxRecuperacao.Visible = true;
                btnRecuperacao.Visible = true;

            }
        }

        private void btnRecuperacao_Click(object sender, EventArgs e)
        {
            //media + notaRecuperacao >= 10
            double media = Convert.ToDouble(tbxMedia.Text);
            double notaR = Convert.ToDouble(tbxRecuperacao.Text);

            double total = media + notaR;
            tbxRecuperacao.Text = total.ToString("f1");

            if (cont == 0)
            {
                cont++;
                if (total >= 10)
                {
                    lblResultado.Text = "APROVADO.";
                }
                else
                {
                    lblResultado.Text = "REPROVADO.";
                }
            }
        }
    }
}
