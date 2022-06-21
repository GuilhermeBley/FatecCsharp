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
    public partial class frmExercicio3 : Form
    {
        public frmExercicio3()
        {
            InitializeComponent();
        }

        private void btnRemoveOcorrencias_Click(object sender, EventArgs e)
        {
            txtPalavra1.Text = txtPalavra1.Text.ToUpper();
            txtPalavra2.Text = txtPalavra2.Text.ToUpper();

            int posicao = txtPalavra2.Text.IndexOf(txtPalavra1.Text);

            while (posicao >= 0)
            {
                txtPalavra2.Text = txtPalavra2.Text.Substring(0, posicao) + 
                   txtPalavra2.Text.Substring(posicao+txtPalavra1.Text.Length, 
                   txtPalavra2.Text.Length - posicao - txtPalavra1.Text.Length);

                posicao = txtPalavra2.Text.IndexOf(txtPalavra1.Text);
            }
        }

        private void btnRemoveOcorrenciasReplace_Click(object sender, EventArgs e)
        {
            txtPalavra2.Text = txtPalavra2.Text.Replace(txtPalavra1.Text, "");
        }

        private void btnInverse_Click(object sender, EventArgs e)
        {
            string s = txtPalavra1.Text;
            char[] array = s.ToCharArray(); //Joga a string para um array
            Array.Reverse(array);
            
            s = "";

            foreach( char c in array)
            {
                s = s + c.ToString();
            }

            txtPalavra2.Text = s;
        }
    }
}
