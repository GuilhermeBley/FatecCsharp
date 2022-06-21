using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Loops
{
    public partial class FormLoops : Form
    {
        public FormLoops()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnForm1_Click(object sender, EventArgs e)
        {
            var Loop1 = new FormLoop1();
            Loop1.Show();
        }

        private void btnForm2_Click(object sender, EventArgs e)
        {
            var Loop2 = new FormLoop2();
            Loop2.Show();
        }

        private void btnForm3_Click(object sender, EventArgs e)
        {
            var Loop3 = new FormLoop3();
            Loop3.Show();
        }

        private void btnForm4_Click(object sender, EventArgs e)
        {
            var Loop4 = new FormLoop4();
            Loop4.Show();
        }
    }
}
