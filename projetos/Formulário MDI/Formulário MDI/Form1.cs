using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Formulário_MDI
{
    public partial class frmPai : Form
    {
        public frmPai()
        {
            InitializeComponent();
        }

        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmFilho frm2 = new frmFilho();//cria uma constante para abrir o formulário filho
            frm2.MdiParent = this;//informa qual o formulário pai
            frm2.Show();//tipo de exibição
        }

        private void novoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frmAzul = new Form();//cria instâncias formulário
            frmAzul.Text = "Formulário Azul";//determina o formulário como Azul
            frmAzul.BackColor = System.Drawing.Color.Blue;
            frmAzul.WindowState = FormWindowState.Normal;
            frmAzul.MdiParent = this;//informa qual o formulário pai
            //frmAzul.Show();//tipo de exibição
            abreFormFilho(frmAzul);
        }

        private void emCascataToolStripMenuItem_Click(object sender, EventArgs e)//abrir em Cascade
        {
            this.LayoutMdi(MdiLayout.Cascade);
        }

        private void horizontalToolStripMenuItem_Click(object sender, EventArgs e)//abrir em Horizontal
        {
            this.LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void tileVerticalToolStripMenuItem_Click(object sender, EventArgs e)//abrir em Vertical
        {                                                                           
            this.LayoutMdi(MdiLayout.TileVertical);
        }

        private void arranjarIconesToolStripMenuItem_Click(object sender, EventArgs e)//abrir em ArrangeIcons
        {
            this.LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void fecharTodosOsFormuláriosToolStripMenuItem_Click(object sender, EventArgs e)//fechar todos formulários
        {
            foreach (Form formularioFilho in MdiChildren)//para cada formulário
             {
                formularioFilho.Close();
             } 
        }

        private void minimizaTodosOsFormuláriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form[] formularios = this.MdiChildren;//criado arrey de formulários
            foreach (Form formFilho in formularios)//percore a coleção
                formFilho.WindowState = FormWindowState.Minimized;//minimiza formulário
        }

        private void abreFormFilho(Form form)//instância que navega entre os formulários abertos 
        {
            foreach(Form formFilho in this.MdiChildren)
            {
                if(formFilho.GetType() == form.GetType())//permite criar um formulário e depois sempre navegar quando já estiver aberto
                {
                    formFilho.Focus();
                    return;
                }
            }
            form.MdiParent = this;
            form.Show();
        }

    }
}



