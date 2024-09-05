using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace avaliacao1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonCalcular_Click(object sender, EventArgs e)
        {
            String nome = Convert.ToString
                (textBoxNome.Text);
            double peso = Convert.ToDouble
                (textBoxPeso.Text);
            double altura = Convert.ToDouble
                (textBoxAltura.Text);

            double imc = peso / (altura * altura);
            labelResultado.Text = imc.ToString();

            if (imc <= 18.5)
            {
                labelSituacao.Text = nome + ", você está abaixo do peso";
            }
            else if (imc <= 24.9)
            {
                labelSituacao.Text = nome + ", você está com peso ideal";
            }
            else if (imc <= 29.9)
            {
                labelSituacao.Text = nome + ", você está sobrepeso";
            }
            else if (imc <= 34.9)
            {
                labelSituacao.Text = nome + ", você está com ob grau 1";
            }
            else if (imc <= 39.9)
            {
                labelSituacao.Text = nome + ", você está com ob grau 2";
            }
            else
            {
                labelSituacao.Text = nome + ", você está com ob grau 3";
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void buttonBoletim_Click(object sender, EventArgs e)
        {
            telaBoletim tela = new telaBoletim();
            tela.Show();
            this.Visible = false;
        }
    }
}
