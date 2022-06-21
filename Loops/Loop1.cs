using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Loops
{
    public partial class FormLoop1 : Form
    {
        public FormLoop1()
        {
            InitializeComponent();
        }

        private void btnFor_Click(object sender, EventArgs e)
        {
            // Espaços em branco

            int whiteSpaces = 0;

            for (int index = 0; index < rchtxtEntrada.Text.Length; index++)
            {
                if (Char.IsWhiteSpace(rchtxtEntrada.Text[index]))
                    whiteSpaces++;
            }

            MessageBox.Show("O número de espaços em branco é : " + whiteSpaces);
        }

        private void btnWhile_Click(object sender, EventArgs e)
        {
            //Letras repetidas (par de letras)
            int index = 1, repetition = 0;

            while (index < rchtxtEntrada.Text.Length)
            {
                char priorChar = rchtxtEntrada.Text[index - 1];

                if (rchtxtEntrada.Text[index] == priorChar)
                    repetition++;

                index++;
            }
            MessageBox.Show("A quantia de pares iguais é de: " + repetition);

        }

        private void btnForeach_Click(object sender, EventArgs e)
        {
            int contR = 0;

            foreach (char elements in rchtxtEntrada.Text)
            {
                if (elements == 'r')
                    contR++;
            }

            MessageBox.Show("A quantia de R na frase é de: " + contR);
        }
    }
}
