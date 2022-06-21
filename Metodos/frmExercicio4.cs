using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Metodos
{
    public partial class frmExercicio4 : Form
    {
        public frmExercicio4()
        {
            InitializeComponent();
        }

        private void btnNumerico_Click(object sender, EventArgs e)
        {
            int numeros = 0;

            for (int contador = 0; contador < richtxtTexto.Text.Length; contador++)
            {
                if (Char.IsNumber(richtxtTexto.Text[contador]))
                {
                    numeros += 1;
                }
            }
            MessageBox.Show("A quantia de números é de: " + numeros);
        }

        private void btnEspacoBranco_Click(object sender, EventArgs e)
        {
            int posicaoBranco = 0, contador = 0;

            while (contador < richtxtTexto.Text.Length)
            {
                if (Char.IsWhiteSpace(richtxtTexto.Text[contador]))
                {
                    posicaoBranco = contador + 1;
                    break;
                }
                contador++;
            }
            MessageBox.Show("O primeiro caracter em branco fica na posição: " + posicaoBranco);
        }

        private void btnAlfabeticos_Click(object sender, EventArgs e)
        {
            int contador = 0;

            foreach(char chara in richtxtTexto.Text)
            {
                if (Char.IsLetter(chara))
                {
                    contador += 1;
                }
            }
            MessageBox.Show("O texto tem " + contador.ToString() + " caracteres alfabéticos");
        }
    }
}
