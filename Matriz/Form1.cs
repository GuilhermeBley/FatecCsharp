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
    public partial class FormMatriz : Form
    {
        public FormMatriz()
        {
            InitializeComponent();
        }

        private void btnEx1_Click(object sender, EventArgs e)
        {
            frmExercicio1 ex = new frmExercicio1();
            ex.Show();
        }


        private void btnEx3_Click(object sender, EventArgs e)
        {
            frmExercicio3 ex = new frmExercicio3();
            ex.Show();
        }

        private void btnEx4_Click(object sender, EventArgs e)
        {
            frmExercicio4 ex = new frmExercicio4();
            ex.Show();
        }

        private void btnEx5_Click(object sender, EventArgs e)
        {
            frmExercicio5 ex = new frmExercicio5();
            ex.Show();
        }

        private void btnEx6_Click(object sender, EventArgs e)
        {
            frmExercicio6 ex = new frmExercicio6();
            ex.Show();
        }

        private void btnEx7_Click(object sender, EventArgs e)
        {
            frmExercicio7 ex = new frmExercicio7();
            ex.Show();
        }
    }
}
