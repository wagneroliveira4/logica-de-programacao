using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace media_aluno
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            pictureBox2.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double n1 = Convert.ToDouble(tbxNota1.Text);
            double n2 = Convert.ToDouble(tbxNota2.Text);
            double n3 = Convert.ToDouble(tbxNota3.Text);

            double media = (n1 + n2 + n3) / 3;

            if (media >= 7)
            {
                lblResultado.ForeColor = Color.Green;
                lblResultado.Text = "O aluno está Aprovado! Média: " + media.ToString("f1");
                pictureBox2.Image = Properties.Resources.aprovado;
                pictureBox2.Visible = true;
            }
            else
            {
                lblResultado.ForeColor = Color.Red;
                lblResultado.Text = "O aluno está Reprovado. Média: " + media.ToString("f1");
                pictureBox2.Image = Properties.Resources.reprovado;
                pictureBox2.Visible = true;
                
                
            }

        }

        

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
