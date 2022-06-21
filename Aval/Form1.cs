using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aval
{
    public partial class FormAval : Form
    {
        public FormAval()
        {
            InitializeComponent();
        }

        private void btnExecutar_Click(object sender, EventArgs e)
        {
            char[] value = mskbxRa.Text.ToCharArray();
            string aux = "";
            int[] contCaracters = new int[value.Length];

            lstbxResults.Items.Clear();

            if (!(value.Length == 13))
            {
                lstbxResults.Items.Add("ERROR");

                MessageBox.Show("O RA deve conter 13 números, escreva novamente");

            }
            else
            {
                //Pega o valor de N
                short n;
                Int16.TryParse(value[12].ToString(), out n);
                if (n == 0)
                    n = 10;

                double[,] matriz = new double[n, 4];

                //Percorre pelos meses, INPUTBOX
                for (int indexMonth = 0; indexMonth < n; indexMonth++)
                {
                    //Percorre a semana
                    for (int indexWeek = 0; indexWeek < 4; indexWeek++)
                    {
                        aux = Interaction.InputBox("Insira o valor no formato R$0,00 da semana: " + (indexWeek + 1), "Mês " + (indexMonth + 1));
                        //Verifica se é um número válido
                        if (!(double.TryParse(aux, out matriz[indexMonth, indexWeek])))
                        {
                            MessageBox.Show("Valor inválido! Tente novamente.");
                            indexWeek--;
                        }
                    }
                }

                //METODO DE IMPRESSÃO

                double sumValueMonth = 0;
                for (int indexMonth = 0; indexMonth < n; indexMonth++)
                {
                    double sumValueWeek = 0;
                    lstbxResults.Items.Add("Mês " + (indexMonth + 1));

                    //Percorre a semana
                    for (int indexWeek = 0; indexWeek < 4; indexWeek++)
                    {
                        lstbxResults.Items.Add("Total do mês: " + (indexMonth + 1)
                            + " Semana " + (indexWeek + 1)
                            + " Valor de:    " + matriz[indexMonth, indexWeek].ToString("C"));

                        sumValueWeek += matriz[indexMonth, indexWeek];
                    }

                    sumValueMonth += sumValueWeek;
                    lstbxResults.Items.Add(">>> Total mês: " + sumValueWeek.ToString("C"));
                    lstbxResults.Items.Add("----------------\n");
                }

                lstbxResults.Items.Add("\n>>>> Total dos meses: " + sumValueMonth.ToString("C"));
            }

        }

    }
}
