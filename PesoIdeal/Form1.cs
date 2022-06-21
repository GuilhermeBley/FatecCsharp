using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PesoIdeal
{
    public partial class FormPesoIdeal : Form
    {
        public FormPesoIdeal()
        {
            InitializeComponent();
        }

        private void button2Fechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1Calcular_Click(object sender, EventArgs e)
        {
            double result = 0;

            //HOMEM
            if (radioButton1Masc.Checked)
            {
                result = 72.7 * Convert.ToDouble(mskbxAltura.Text) - 58;
            }
            //MULHER
            else
            {
                result = 62.1 * Convert.ToDouble(mskbxAltura.Text) - 44.7;
            }

            if (Convert.ToDouble(mskbxPeso.Text) > result)
            {
                MessageBox.Show("Regime obrigatório!");
            }
            else if (Convert.ToDouble(mskbxPeso.Text) < result)
            {
                MessageBox.Show("Coma bastante doce");
            }
            else
            {
                MessageBox.Show("Você esta com o peso ideal");
            }
        }

    }
}
