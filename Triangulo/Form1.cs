using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Triangulo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double a = 0, b = 0, c = 0;

            //Verifica se todos os valores sao numeros
            if (double.TryParse(txtTamanho1.Text, out a) && double.TryParse(txtTamanho2.Text, out b) && double.TryParse(txtTamanho3.Text, out c))
            {

                //Verifica se todos os valores foram postos
                if (a == 0 || b == 0 || c == 0)
                {
                    MessageBox.Show("Preencha todos os tamanhos");
                }
                else
                {
                    //Verifica se é um triangulo
                    if (b - c < a && b + c > a && a - c < b && a + c > b && a - b < c && a + b > c)
                    {
                        if (a == b && b == c)
                            MessageBox.Show("O triângulo é equilátero");
                        else if (a == b || b == c || c == a)
                            MessageBox.Show("O triângulo é isósceles");
                        else if (a != b && a != c && b != a && b != c)
                            MessageBox.Show("O triângulo é escaleno");
                        else
                            MessageBox.Show("Triângulo não aplicavel.");

                    }
                    else
                        MessageBox.Show("Não é um triangulo.");
                }
            }
            else
                MessageBox.Show("Coloque somente valores numéricos nos tamanhos.");
        }
    }
}
