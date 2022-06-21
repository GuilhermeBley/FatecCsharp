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
    public partial class FormMetodos : Form
    {
        public FormMetodos()
        {
            InitializeComponent();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void copiarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Mensagem Copiada");
        }

        private void colarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Mensagem Colada");
        }

        private void exercício2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form fc = Application.OpenForms["frmExerício2"];
            if (fc != null)
                fc.Close();
            
            frmExercicio2 Exercicio2 = new frmExercicio2();
            Exercicio2.MdiParent = this;
            Exercicio2.WindowState = FormWindowState.Maximized;
            Exercicio2.Show();
        }

        private void exercício3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form fc = Application.OpenForms["frmExerício3"];
            if (fc != null)
                fc.Close();

            frmExercicio3 Exercicio3 = new frmExercicio3();
            Exercicio3.MdiParent = this;
            Exercicio3.WindowState = FormWindowState.Maximized;
            Exercicio3.Show();
        }

        private void exercício4ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form fc = Application.OpenForms["frmExerício4"];
            if (fc != null)
                fc.Close();

            frmExercicio4 Exercicio4 = new frmExercicio4();
            Exercicio4.MdiParent = this;
            Exercicio4.WindowState = FormWindowState.Maximized;
            Exercicio4.Show();
        }

        private void exercício5ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form fc = Application.OpenForms["frmExerício5"];
            if (fc != null)
                fc.Close();

            frmExercicio5 Exercicio5 = new frmExercicio5();
            Exercicio5.MdiParent = this;
            Exercicio5.WindowState = FormWindowState.Maximized;
            Exercicio5.Show();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
