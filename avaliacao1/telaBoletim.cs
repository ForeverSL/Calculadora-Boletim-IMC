using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace avaliacao1
{
    public partial class telaBoletim : Form
    {
        public telaBoletim()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void buttonCalcular_Click(object sender, EventArgs e)
        {
            String nome = Convert.ToString
                (textBoxNome.Text);
            double nota1 = Convert.ToDouble
                (textBoxNota1.Text);
            double nota2 = Convert.ToDouble
                (textBoxNota2.Text);
            double nota3 = Convert.ToDouble
                (textBoxNota3.Text);
            double nota4 = Convert.ToDouble
                (textBoxNota4.Text);

            double media = (nota1 + nota2 + nota3 + nota4) / 4;
            labelResultado.Text = media.ToString();

            if (media >= 7)
            {
                labelResultado.Text = nome + ", você foi aprovado com media: " + media + " 🥳";
            }
            else
            {
                labelResultado.Text = nome + ", você foi reprovado com media: " + media + " 😢";
            }


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buttonIMC_Click(object sender, EventArgs e)
        {
            Form1 tela1 = new Form1();
            tela1.Show();
            this.Visible = false;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBoxNome_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
