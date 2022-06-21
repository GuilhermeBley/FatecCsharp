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
    public partial class frmExercicio7 : Form
    {
        public frmExercicio7()
        {
            InitializeComponent();
        }


        private void btnExecutar_Click(object sender, EventArgs e)
        {
            char[] value = mskdtxtboxRa.Text.ToCharArray();
            string aux = "";
            int[] contCaracters = new int[value.Length];

            lstboxResults.Items.Clear();            


            if (!(value.Length == 13))
            {                             
                lstboxResults.Items.Add("ERROR");

                MessageBox.Show("O RA deve conter 13 números, escreva novamente");
                
            }
            else
            {
                //Pega o valor de N
                short n;
                Int16.TryParse(value[12].ToString(), out n);
                if (n == 0)
                    n = 10;
                 
                //Pega os nomes e conta seus caracteres
                for (int index = 0; index < n; index++)
                {
                    aux = Interaction.InputBox("Insira o nome: " + (index + 1), "Nome ");

                    contCaracters[index] = aux.ToCharArray().Length;
                    char[] auxChar = aux.ToCharArray();
                    
                    //Retirando espaços em branco
                    foreach (char caracter in auxChar)
                    {
                        if (caracter == ' ')
                            contCaracters[index]--;
                    }

                    //Colocando valor
                    lstboxResults.Items.Add("O nome: '" + aux + "' Tem " + contCaracters[index] + " caracters");
                }
            }
        }
    }
}
