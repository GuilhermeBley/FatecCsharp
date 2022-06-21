using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class FormCalculadora : Form
    {
        public FormCalculadora()
        {
            InitializeComponent();
            this.Text = "Calculadora";
        }

        private void button1Sair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1Limpar_Click(object sender, EventArgs e)
        {
            txtNumero1.Text = "";
            txtNumero2.Clear();
            txtResultado.Text = String.Empty;
        }

        private void button1Soma_Click(object sender, EventArgs e)
        {
            double numero1, numero2;

            if (double.TryParse(txtNumero1.Text, out numero1) && double.TryParse(txtNumero2.Text, out numero2))
            {
                double resultado;
                resultado = numero1 + numero2;
                txtResultado.Text = resultado.ToString();
            }
            else
                MessageBox.Show("Números inválidos");
        }

        private void button2Sub_Click(object sender, EventArgs e)
        {

            double numero1, numero2;

            if (double.TryParse(txtNumero1.Text, out numero1) && double.TryParse(txtNumero2.Text, out numero2))
            {
                double resultado;
                resultado = numero1 - numero2;
                txtResultado.Text = resultado.ToString();
            }
            else
                MessageBox.Show("Números inválidos");

        }

        private void button3Div_Click(object sender, EventArgs e)
        {
            double numero1, numero2;

            if (double.TryParse(txtNumero1.Text, out numero1) && double.TryParse(txtNumero2.Text, out numero2))
                if (numero2 == 0)
                {
                    MessageBox.Show("Não é possível dividir um numero por zero");
                }

                else
                {
                    double resultado;
                    resultado = numero1 / numero2;
                    txtResultado.Text = resultado.ToString();
                }
            else
                MessageBox.Show("Números inválidos");
        }

        private void button4Mul_Click(object sender, EventArgs e)
        {
            double numero1, numero2;

            if (double.TryParse(txtNumero1.Text, out numero1) && double.TryParse(txtNumero2.Text, out numero2))
            {
                double resultado;
                resultado = numero1 * numero2;
                txtResultado.Text = resultado.ToString();
            }
            else
                MessageBox.Show("Números inválidos");
        }

    }
}
