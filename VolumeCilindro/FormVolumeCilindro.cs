using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VolumeCilindro
{
    public partial class FormVolumeCilindro : Form
    {
        public FormVolumeCilindro()
        {
            InitializeComponent();
            //Altera o Título do Form1
            this.Text = "Calculador volume do cilindro";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Encerra o programa ao clicar no botão "Fechar"
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        { 
            //Limpa os dados dos tres TextBox
            txtAltura.Clear();
            txtRaio.Text = "";
            txtResult.Clear();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Criar variavel altura e raio
            double altura, raio;

            if (double.TryParse(txtAltura.Text, out altura) && double.TryParse(txtRaio.Text, out raio))
            {
                //Cria a variavel do resultado volume
                double volume;
                // Pega a variavel do resultado e calcula 
                volume = Math.Pow(raio, 2) * altura;
                txtResult.Text = volume.ToString("N2");

            }
            else
                MessageBox.Show("Valor Inálido");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }
    }
}
