
namespace Login_e_Senha
{
    partial class Form_Principal
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Principal));
            this.label_nome = new System.Windows.Forms.Label();
            this.label_senha = new System.Windows.Forms.Label();
            this.txt_nome = new System.Windows.Forms.TextBox();
            this.txt_senha = new System.Windows.Forms.TextBox();
            this.btn_login = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btn_fechar = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.lbl_email = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label_nome
            // 
            this.label_nome.AutoSize = true;
            this.label_nome.Location = new System.Drawing.Point(42, 30);
            this.label_nome.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_nome.Name = "label_nome";
            this.label_nome.Size = new System.Drawing.Size(52, 17);
            this.label_nome.TabIndex = 0;
            this.label_nome.Text = "Nome:";
            // 
            // label_senha
            // 
            this.label_senha.AutoSize = true;
            this.label_senha.Location = new System.Drawing.Point(45, 91);
            this.label_senha.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_senha.Name = "label_senha";
            this.label_senha.Size = new System.Drawing.Size(52, 17);
            this.label_senha.TabIndex = 1;
            this.label_senha.Text = "Senha:";
            // 
            // txt_nome
            // 
            this.txt_nome.Location = new System.Drawing.Point(45, 51);
            this.txt_nome.Margin = new System.Windows.Forms.Padding(4);
            this.txt_nome.Name = "txt_nome";
            this.txt_nome.Size = new System.Drawing.Size(318, 25);
            this.txt_nome.TabIndex = 0;
            this.txt_nome.TextChanged += new System.EventHandler(this.txt_nome_TextChanged);
            this.txt_nome.Validating += new System.ComponentModel.CancelEventHandler(this.txt_nome_Validating);
            // 
            // txt_senha
            // 
            this.txt_senha.Location = new System.Drawing.Point(45, 112);
            this.txt_senha.Margin = new System.Windows.Forms.Padding(4);
            this.txt_senha.Name = "txt_senha";
            this.txt_senha.PasswordChar = '*';
            this.txt_senha.Size = new System.Drawing.Size(318, 25);
            this.txt_senha.TabIndex = 1;
            this.txt_senha.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_senha_KeyPress);
            // 
            // btn_login
            // 
            this.btn_login.Location = new System.Drawing.Point(54, 226);
            this.btn_login.Margin = new System.Windows.Forms.Padding(4);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(163, 49);
            this.btn_login.TabIndex = 4;
            this.btn_login.Text = "&Login";
            this.btn_login.UseVisualStyleBackColor = true;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // btn_fechar
            // 
            this.btn_fechar.CausesValidation = false;
            this.btn_fechar.Location = new System.Drawing.Point(233, 226);
            this.btn_fechar.Name = "btn_fechar";
            this.btn_fechar.Size = new System.Drawing.Size(108, 49);
            this.btn_fechar.TabIndex = 5;
            this.btn_fechar.Text = "Fechar";
            this.btn_fechar.UseVisualStyleBackColor = true;
            this.btn_fechar.Click += new System.EventHandler(this.btn_fechar_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // lbl_email
            // 
            this.lbl_email.AutoSize = true;
            this.lbl_email.Location = new System.Drawing.Point(45, 147);
            this.lbl_email.Name = "lbl_email";
            this.lbl_email.Size = new System.Drawing.Size(50, 17);
            this.lbl_email.TabIndex = 6;
            this.lbl_email.Text = "Email:";
            // 
            // txtEmail
            // 
            this.txtEmail.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.txtEmail.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.AllUrl;
            this.txtEmail.Location = new System.Drawing.Point(45, 167);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(315, 25);
            this.txtEmail.TabIndex = 2;
            this.txtEmail.Validating += new System.ComponentModel.CancelEventHandler(this.textBox1_Validating);
            // 
            // Form_Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(408, 302);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lbl_email);
            this.Controls.Add(this.btn_fechar);
            this.Controls.Add(this.btn_login);
            this.Controls.Add(this.txt_senha);
            this.Controls.Add(this.txt_nome);
            this.Controls.Add(this.label_senha);
            this.Controls.Add(this.label_nome);
            this.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form_Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Principal";
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form_Principal_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_nome;
        private System.Windows.Forms.Label label_senha;
        private System.Windows.Forms.TextBox txt_nome;
        private System.Windows.Forms.TextBox txt_senha;
        private System.Windows.Forms.Button btn_login;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btn_fechar;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lbl_email;
    }
}

