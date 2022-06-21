using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace Matriz
{
    public partial class frmExercicio5 : Form
    {
        public frmExercicio5()
        {
            InitializeComponent();
        }

        private void btnAlunos_Click(object sender, EventArgs e)
        {
            ArrayList objAlunos = new ArrayList();
            string[] vetorAlunos = { "Ana", "André", "Débora", "Fátima", "João", "Janete", "Otávio", "Marcelo", "Pedro", "Thais" };

            foreach (string aluno in vetorAlunos)
                objAlunos.Add(aluno);


            objAlunos.Remove("Otávio");


            string printValues = "";
            foreach (string aluno in objAlunos)
                printValues += "\n" + aluno;

            MessageBox.Show("Os nomes são: " + printValues);

        }
    }
}
