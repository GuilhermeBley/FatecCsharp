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
    public partial class frmExercicio4 : Form
    {
        public frmExercicio4()
        {
            InitializeComponent();
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            string[] Alunos = {"Viviane", "André", "Hélio", "Denise", "Junior","Leonardo", "Jose", "Nelma", "Tobby"};
            char result = '\0';

            Int32 I, Total = 0;
            Int32 N = Alunos.Length;
            for (I = 0; I < N - 1; I++)
            {
                Total += Alunos[I].Length;
            }

            if (Total == 51)
                result = 'A';
            else if (Total == 50)
                result = 'B';
            else if (Total == 46)
                result = 'C';
            else if (Total == 48)
                result = 'D';

            if (result != '\0')
                MessageBox.Show("O valor é de: " + Total + "\nA letra correta é a '" + result + "'");
            else
                MessageBox.Show("Resultado do 'Total' não contido nas respostas");
        }
    }
}
