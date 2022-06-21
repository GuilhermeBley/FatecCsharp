using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Funcionario
{
    public partial class FormFuncionario : Form
    {
        public FormFuncionario()
        {
            InitializeComponent();
        }

        private void btnOff_Click(object sender, EventArgs e)
        {
            Close();
        }



        private void btnVerificarDesconto_Click(object sender, EventArgs e)
        {
            //Declaração de variaveis
            double salarioBruto, valorINSS, valorIRPF, salarioFamilia = 0;
            byte numeroFilhos;


            //Calculos
            void CalculoINSS(double salBruto)
            {
                double aliquotaInss = 0, descontoInss;

                if (salarioBruto <= 800.47)
                    aliquotaInss = 7.65;
                else if (salarioBruto <= 1050)
                    aliquotaInss = 8.65;
                else if (salarioBruto <= 1400.77)
                    aliquotaInss = 9;
                else if (salarioBruto <= 2801.56)
                    aliquotaInss = 11;


                if (aliquotaInss == 0)
                    descontoInss = 308.17;
                else
                    descontoInss = aliquotaInss / 100 * salarioBruto;
                valorINSS = descontoInss;

                mskbxAliquotaINSS.Text = aliquotaInss.ToString("N2") + " %";
                mskbxDescontoINSS.Text = descontoInss.ToString("N2");
            }

            void CalculoIRPF(double salBruto)
            {
                double aliquotaIRPF = 0;

                if (salarioBruto <= 2512.08 && salarioBruto >= 1257.12)
                    aliquotaIRPF = 15;
                else if (salarioBruto > 2512.08)
                    aliquotaIRPF = 27.5;


                mskbxAliquotaIRPF.Text = aliquotaIRPF.ToString("N2") + " %";
                if (aliquotaIRPF == 0)
                    mskbxDescontoIRPF.Text = "Isento";
                else
                    mskbxDescontoIRPF.Text = (aliquotaIRPF / 100 * salarioBruto).ToString("N2");

                valorIRPF = aliquotaIRPF / 100 * salarioBruto;

            }

            void CalculoSalarioFamilia(double salBruto, byte numFilhos)
            {
                if (salBruto <= 435.52)
                    salarioFamilia = 22.33 * numFilhos;
                else if (salBruto <= 654.61)
                    salarioFamilia = 15.74 * numFilhos;

                mskbxSalarioFamilia.Text = salarioFamilia.ToString("N2");
            }

            //Verifica se os valores passados são corretos
            if (double.TryParse(mskbxSalarioBruto.Text, out salarioBruto) && byte.TryParse(mskbxNumFilhos.Text, out numeroFilhos))
            {
                //Calculo INSS
                CalculoINSS(salarioBruto);

                //Calculo IRPF
                CalculoIRPF(salarioBruto);

                //Salario Familia
                if (numeroFilhos > 0 && salarioBruto <= 654.61)
                    CalculoSalarioFamilia(salarioBruto, numeroFilhos);

                mskbxSalarioLiquido.Text = (salarioBruto - valorINSS - valorIRPF + salarioFamilia).ToString();

                //Modificando Resultado
                string sexo = "do senhor ", status = "solteiro";
                if (rbtnFem.Checked)
                    sexo = "da senhora ";
                if (ckbxCasado.Checked)
                    status = "casado";

                lblResultado.Text = "Os descontos do salário " + sexo + mskbxNomeFuncionario.Text + " que é " + status + ".\nE que tem " + numeroFilhos + " filho(s).";
            }
            else
                MessageBox.Show("Valores inválidos");

        }
    }
}
