using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lista_de_Nomes
{
    public partial class FrmListadeNomes : Form
    {
        public FrmListadeNomes()
        {
            InitializeComponent();
        }

        private void btnAdiciona_Click(object sender, EventArgs e)
        {
            string nome = txtNome.Text;
            lstNome.Items.Add(nome.ToUpper());
            txtNome.Clear();
            txtNome.Focus();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            int valor = lstNome.SelectedIndex;
            if(valor == -1)
            {
                MessageBox.Show("Para excluir um item da lista\n é necessário primeiro selecioná-lo, OK?","** Excluindo item da lista **",MessageBoxButtons.OK,MessageBoxIcon.Error);
                btnRemove.Enabled = false;
                txtNome.Focus();
            }
            else { lstNome.Items.RemoveAt(valor); }
        }

        private void btnRemoveTudo_Click(object sender, EventArgs e)
        {
            if(lstNome.Items.Count == 0){
                MessageBox.Show("A lista está vazia!!!\nAdicione primeiro um item\nedepois selecione para removê-lo","** Excluindo intem da lista **", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNome.Focus();
            }
            else{
                btnRemove.Enabled = false;
                lstNome.Items.Clear();
                txtNome.Focus();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            txtNome.Clear();
            txtNome.Focus();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Deseja sair do programa?","** Finalizando o Programa **",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {
                txtNome.Clear();
                txtNome.Focus();
            }
        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {
            btnRemove.Enabled = true;
        }

        private void FrmListadeNomes_Load(object sender, EventArgs e)
        {
            btnRemove.Enabled = false;
        }

        private void lstNome_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnRemove.Enabled = true;
        }
    }
}
