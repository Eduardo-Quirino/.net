using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace média_de_quatro_notas
{
    public partial class FrmCalculaMedia : Form
    {
        public FrmCalculaMedia()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double n1, n2, n3, n4, media;
            n1 = double.Parse(txtn1.Text);
            n2 = double.Parse(txtn2.Text);
            n3 = double.Parse(txtn3.Text);
            n4 = double.Parse(txtn4.Text);
            media = (n1 + n2 + n3 + n4) / 4;

            if(media >= 7) { MessageBox.Show("Média = " + Math.Round(media, 2) + " -APROVADO!"); }
            else if (media >= 5) { MessageBox.Show("Média = "+ Math.Round(media,2)+" -EXAME"); }
                else { MessageBox.Show("Média = " + Math.Round(media, 2) + "- REPROVADO"); }

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtn1.Clear();
            txtn2.Clear();
            txtn3.Clear();
            txtn4.Clear();
            txtn1.Focus();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            string texto = "Deseja Sair do Programa?";
            string titulo = "++++ FINALIZANDO ++++";
            if (MessageBox.Show(texto, titulo, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
