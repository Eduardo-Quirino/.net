using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login_e_Senha
{
    public partial class Form_Principal : Form
    {
        public Form_Principal()
        {
            InitializeComponent();
        }
        public static string NomeDoUsuario = "";

        private void btn_login_Click(object sender, EventArgs e)
        {
            if (txt_nome.Text == "eduardo"&& txt_senha.Text == "1234")
            {
                Form_Boas_Vindas form_Boas_Vindas = new Form_Boas_Vindas();
                NomeDoUsuario = txt_nome.Text;
                form_Boas_Vindas.ShowDialog();
            }
            else { MessageBox.Show("Usuário / Senha inválido"); }
        }

        private void txt_senha_KeyPress(object sender, KeyPressEventArgs e)
        {
            int asc = (int)e.KeyChar;
            if(!char.IsDigit(e.KeyChar)&& asc !=08 && asc != 127)
            {
                e.Handled = true;
                MessageBox.Show("Informe somente números!");
                txt_senha.Text = "";
                txt_senha.Focus();

            }
        }

        private void txt_nome_Validating(object sender, CancelEventArgs e)
        {
            if(txt_nome.Text == string.Empty)
            {
               errorProvider1.SetError(txt_nome,"Informe o nome do usuário");
                e.Cancel = true;
            }
            else { errorProvider1.SetError(txt_nome, ""); }
        }

        private void btn_fechar_Click(object sender, EventArgs e)
        {
            AutoValidate = AutoValidate.Disable;
            this.Close();
        }

        private void txt_nome_TextChanged(object sender, EventArgs e)
        {
          
        }
    }
}
