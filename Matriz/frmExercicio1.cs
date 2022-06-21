using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Matriz
{
    public partial class frmExercicio1 : Form
    {
        public frmExercicio1()
        {
            InitializeComponent();
        }

        private int[] numbers ()
        {
            int[] vetor = new int[20];
            string aux = "";

            for (int index = 0; index < vetor.Length; index++)
            {
                aux = Interaction.InputBox("Entre com o valor na posição: " + (index + 1), "Entrada de dados: ");

                if (!int.TryParse(aux, out vetor[index]))
                {
                    MessageBox.Show("Número inválido");
                    index--;
                }
            }

            aux = "";

            for (int index = vetor.Length - 1; index >= 0; index--)
                aux += "\n" + vetor[index].ToString();

            return vetor;
        } 

        private void btnExecute_Click(object sender, EventArgs e)
        {
            string aux = "";
            int[] vetor = numbers();
            

            for (int index = vetor.Length - 1; index >= 0; index--)
                aux += "\n" + vetor[index].ToString();

            MessageBox.Show(aux);
        }

        private void btnEx2_Click(object sender, EventArgs e)
        {
            string aux = "";
            int[] vetor = numbers();

            vetor = vetor.Reverse().ToArray();

            for (int index = vetor.Length - 1; index >= 0; index--)
                aux += "\n" + vetor[index].ToString();

            MessageBox.Show(aux);
        }
    }
}
