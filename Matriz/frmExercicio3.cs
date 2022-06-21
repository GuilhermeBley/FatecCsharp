using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace Matriz
{
    public partial class frmExercicio3 : Form
    {
        public frmExercicio3()
        {
            InitializeComponent();
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            int numMercadoria = 3;
            string [] vetorQtddString = new string [10];
            string[] vetorValorString = new string [10];
            int[] vetorQtdd = new int[10];
            double[] vetorValor = new double[10];
            double faturamentoMensal = 0;

            for (int index = 0; index < numMercadoria; index++)
            {
                
                //Passando os valores em Reais
                vetorValorString [index] = Interaction.InputBox("Entrada do valor em R$: ", "Produto " + (index + 1));

                if (!double.TryParse(vetorValorString[index], out vetorValor[index])    &&  vetorValor [index] < 0)
                {
                    MessageBox.Show("Número inválido");
                    index--;
                }

                //Passando os valores de quantidade
                vetorQtddString [index] = Interaction.InputBox("Quantidade de: ", "Produto " + (index + 1));

                if (!int.TryParse(vetorQtddString[index], out vetorQtdd[index])     &&   vetorQtdd[index] < 0)
                {
                    MessageBox.Show("Número inválido");
                    index--;
                }

            }

            //Somando os valores dos lucros
            for (int index = 0; index < numMercadoria; index++)
                faturamentoMensal += vetorValor[index] * vetorQtdd[index];
            
            MessageBox.Show("Valor do faturamento mensal de R$: " + faturamentoMensal);

        }
    }
}
