using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Loops
{
    public partial class FormLoop2 : Form
    {
        public FormLoop2()
        {
            InitializeComponent();
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            int numeroN;

            //Verifica se N é um número
            if (int.TryParse(txtNumeroN.Text, out numeroN))
            {

                //Verifica se N é maior que 0
                if (numeroN > 0)
                {
                    double sum = 1, division = 1;

                    //Vai somar e divir os números
                    for (int index = 1; index < numeroN; index++)
                    {
                        division++;
                        sum = sum + 1 / division;
                    }


                    MessageBox.Show("O valor de H é: " + sum);

                }
                else
                    MessageBox.Show("Digite um número inteiro positivo.");


            }
            else
                MessageBox.Show("Digite um número inteiro positivo.");
        }
    }
}
