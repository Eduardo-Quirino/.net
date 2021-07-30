using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Visualizador_de_imagem
{
    public partial class FrmImagem : Form
    {
        public FrmImagem()
        {
            InitializeComponent();
        }

        private void btn_sair_Click(object sender, EventArgs e)
        {
            string texto = "Deseja Sair do Programa?";
            string titulo = "++++ FINALIZANDO ++++";
            if (MessageBox.Show(texto, titulo, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                this.Close();
            }

            private void btn_abrir_Click(object sender, EventArgs e)
        {
            try 
            {
                dlg_Abrir.ShowDialog();
                if(dlg_Abrir.FileName != "") { picImagem.Load(dlg_Abrir.FileName); }
            }
            catch(Exception erro) 
            {
                MessageBox.Show(erro.Message + "|nO arquivo solicitado não é um arquivo de imagem", "*** ERRO DE ARQUIVO ***", MessageBoxButtons.OK, MessageBoxIcon.Error );
            }
        }
    }
}
