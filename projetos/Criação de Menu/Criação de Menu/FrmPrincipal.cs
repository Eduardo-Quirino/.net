using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Criação_de_Menu
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }
        #region Item de Menu do Cálculo Média
        private void calculo_da_media_toolStripMenuItem_Click(object sender, EventArgs e)
        {
            média_de_quatro_notas.FrmCalculaMedia item1 = new média_de_quatro_notas.FrmCalculaMedia();
            item1.MdiParent = this;
            item1.Show();
        }
        #endregion

        #region Item de Menu da Lista de Nomes
        private void lista_de_nomes_toolStripMenuItem_Click(object sender, EventArgs e)
        {
            Lista_de_Nomes.FrmListadeNomes item2= new Lista_de_Nomes.FrmListadeNomes();
            item2.MdiParent = this;
            item2.Show();
        }
        #endregion

        #region Item de Menu de Visualizar Imagem
        private void visualizar_imagem_toolStripMenuItem_Click(object sender, EventArgs e)
        {
            Visualizador_de_imagem.FrmImagem item5 = new Visualizador_de_imagem.FrmImagem();
            item5.MdiParent =this;
            item5.Show();
        }
        #endregion

        #region Item de Menu de Movimentar Imagem
        private void movimentar_imagem_toolStripMenuItem_Click(object sender, EventArgs e)
        {
            Movi_teclas.FrmMovimentaTeclas item3 = new Movi_teclas.FrmMovimentaTeclas();
            item3.MdiParent = this;
            item3.Show();
        }
        #endregion

        #region Item de Menu de Movimentar Imagem
        private void relogio_toolStripMenuItem_Click(object sender, EventArgs e)
        {
            Relógio.FormRelogio item4 = new Relógio.FormRelogio();
            item4.MdiParent = this;
            item4.Show();
        }
        #endregion

        private void sair_do_programa_toolStripMenuItem_Click(object sender, EventArgs e)
        {
            string texto = "Deseja Sair do Programa";
            string titulo = "+++++ FINALIZANDO +++++";
            if(MessageBox.Show(texto, titulo, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)== DialogResult.Yes)
            {
                this.Close();//fechar formulário
            }
        }
    }
}
