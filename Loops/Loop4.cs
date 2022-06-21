using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Loops
{
    public partial class FormLoop4 : Form
    {
        public FormLoop4()
        {
            InitializeComponent();
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            double.TryParse(mskdtxtSalario.Text, out double salarioLiqui);
            double.TryParse(mskdtxtgratificacoes.Text, out double gratificacoes);


            //PRODUÇÃO
            Int32.TryParse(mskdtxtProdução.Text, out int producao);
            int b = 0, c = 0, d = 0;
            if (producao >= 100)
                b = 1;
            if (producao >= 120)
                c = 1;
            if (producao >= 150)
                d = 1;

            double salarioBruto = salarioLiqui + (salarioLiqui * (0.05 * b + 0.1 * c + 0.1 * d)) + gratificacoes;


            if (salarioBruto > 7000 & producao < 150 & !(gratificacoes > 0))
                MessageBox.Show("Salarios brutos acima de 7000 só são valídos com produção maior ou igual a 150 e funcionários que tenham gratificações");
            else
                MessageBox.Show("O salário Bruto é de: " + salarioBruto);
        }
    }
}
