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
    public partial class frmExercicio6 : Form
    {
        public frmExercicio6()
        {
            InitializeComponent();
        }

        private void btnAluno_Click(object sender, EventArgs e)
        {
            int totalNotas = 3, totalAlunos = 20;
            int[,] aluno = new int[totalAlunos, totalNotas];
            string aux = "", printAlunos = "";

            //Pegando as notas
            for (int indexAluno = 0; indexAluno < totalAlunos; indexAluno++)
            {
                for (int indexNota = 0; indexNota < totalNotas; indexNota++)
                {
                    aux = Interaction.InputBox("Insira a nota: " + (indexNota + 1), "Aluno " + (indexAluno + 1));

                    if (!int.TryParse(aux, out aluno[indexAluno, indexNota]))
                    {
                        MessageBox.Show("Número inválido");
                        indexNota--;
                    }

                }
                int media = (aluno[indexAluno, 0] + aluno[indexAluno, 1] + aluno[indexAluno, 2]) / 3;
                printAlunos += "\nAluno " + (indexAluno + 1) + ": Média: " + media;
            }

            //Imprimindo notas
            MessageBox.Show(printAlunos);
        }
    }
}
