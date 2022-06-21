using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Loops
{
    public partial class FormLoop3 : Form
    {
        public FormLoop3()
        {
            InitializeComponent();
        }

        private void btnPalindromo_Click(object sender, EventArgs e)
        {
            //Tirando espaços
            string phrase = "";
            foreach (char item in txtFrase.Text)
            {
                if (item != ' ')
                    phrase += item.ToString();
            }

            //Deixando em maiúsculo
            phrase = phrase.ToUpper();

            //Invertendo a String
            String phraseReverse = new String(phrase.Reverse().ToArray());

            if (phrase == phraseReverse)
                MessageBox.Show("A frase: " + phrase + " é um palíndromo");
            else
                MessageBox.Show("A frase: " + phrase + " NÃO é um palíndromo");

        }
    }
}
