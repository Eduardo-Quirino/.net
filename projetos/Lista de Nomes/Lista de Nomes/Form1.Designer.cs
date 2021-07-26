
namespace Lista_de_Nomes
{
    partial class FrmListadeNomes
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lstNome = new System.Windows.Forms.ListBox();
            this.btnAdiciona = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnRemoveTudo = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Item para a Lista";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(146, 28);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(100, 23);
            this.txtNome.TabIndex = 1;
            this.txtNome.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtNome.TextChanged += new System.EventHandler(this.txtNome_TextChanged);
            // 
            // lstNome
            // 
            this.lstNome.FormattingEnabled = true;
            this.lstNome.ItemHeight = 16;
            this.lstNome.Location = new System.Drawing.Point(28, 73);
            this.lstNome.Name = "lstNome";
            this.lstNome.Size = new System.Drawing.Size(213, 276);
            this.lstNome.Sorted = true;
            this.lstNome.TabIndex = 2;
            this.lstNome.SelectedIndexChanged += new System.EventHandler(this.lstNome_SelectedIndexChanged);
            // 
            // btnAdiciona
            // 
            this.btnAdiciona.Location = new System.Drawing.Point(251, 74);
            this.btnAdiciona.Name = "btnAdiciona";
            this.btnAdiciona.Size = new System.Drawing.Size(131, 32);
            this.btnAdiciona.TabIndex = 3;
            this.btnAdiciona.Text = "&Adicionar Item";
            this.btnAdiciona.UseVisualStyleBackColor = true;
            this.btnAdiciona.Click += new System.EventHandler(this.btnAdiciona_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(251, 133);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(131, 32);
            this.btnRemove.TabIndex = 4;
            this.btnRemove.Text = "&Remover Item";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnRemoveTudo
            // 
            this.btnRemoveTudo.Location = new System.Drawing.Point(251, 194);
            this.btnRemoveTudo.Name = "btnRemoveTudo";
            this.btnRemoveTudo.Size = new System.Drawing.Size(131, 32);
            this.btnRemoveTudo.TabIndex = 5;
            this.btnRemoveTudo.Text = "Remover &Tudo";
            this.btnRemoveTudo.UseVisualStyleBackColor = true;
            this.btnRemoveTudo.Click += new System.EventHandler(this.btnRemoveTudo_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(251, 255);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(131, 32);
            this.btnCancelar.TabIndex = 6;
            this.btnCancelar.Text = "&Cancela";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(251, 316);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(131, 32);
            this.btnSair.TabIndex = 7;
            this.btnSair.Text = "&Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // FrmListadeNomes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 411);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnRemoveTudo);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnAdiciona);
            this.Controls.Add(this.lstNome);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "FrmListadeNomes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lista de Nomes";
            this.Load += new System.EventHandler(this.FrmListadeNomes_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.ListBox lstNome;
        private System.Windows.Forms.Button btnAdiciona;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnRemoveTudo;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnSair;
    }
}

