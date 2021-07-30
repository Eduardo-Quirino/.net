
namespace Visualizador_de_imagem
{
    partial class FrmImagem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmImagem));
            this.picImagem = new System.Windows.Forms.PictureBox();
            this.btn_abrir = new System.Windows.Forms.Button();
            this.btn_sair = new System.Windows.Forms.Button();
            this.dlg_Abrir = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.picImagem)).BeginInit();
            this.SuspendLayout();
            // 
            // picImagem
            // 
            this.picImagem.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picImagem.Location = new System.Drawing.Point(12, 12);
            this.picImagem.Name = "picImagem";
            this.picImagem.Size = new System.Drawing.Size(526, 391);
            this.picImagem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picImagem.TabIndex = 0;
            this.picImagem.TabStop = false;
            // 
            // btn_abrir
            // 
            this.btn_abrir.Location = new System.Drawing.Point(382, 409);
            this.btn_abrir.Name = "btn_abrir";
            this.btn_abrir.Size = new System.Drawing.Size(75, 47);
            this.btn_abrir.TabIndex = 1;
            this.btn_abrir.Text = "&Abrir";
            this.btn_abrir.UseVisualStyleBackColor = true;
            // btn_sair
            // 
            this.btn_sair.Location = new System.Drawing.Point(463, 409);
            this.btn_sair.Name = "btn_sair";
            this.btn_sair.Size = new System.Drawing.Size(75, 47);
            this.btn_sair.TabIndex = 2;
            this.btn_sair.Text = "&Sair";
            this.btn_sair.UseVisualStyleBackColor = true;
            this.btn_sair.Click += new System.EventHandler(this.btn_sair_Click);
            // 
            // dlg_Abrir
            // 
            this.dlg_Abrir.FileName = "openFileDialog1";
            this.dlg_Abrir.Filter = "Arquivos de Imagens | *.*";
            this.dlg_Abrir.InitialDirectory = "C:\\Users\\edu35\\Documents\\Senac\\.net\\projetos\\Visualizador de imagem\\img";
            this.dlg_Abrir.Title = "Abertura de Imagens";
            // 
            // FrmImagem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(540, 517);
            this.Controls.Add(this.btn_sair);
            this.Controls.Add(this.btn_abrir);
            this.Controls.Add(this.picImagem);
            this.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "FrmImagem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Visualizador de Imagem";
            ((System.ComponentModel.ISupportInitialize)(this.picImagem)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picImagem;
        private System.Windows.Forms.Button btn_abrir;
        private System.Windows.Forms.Button btn_sair;
        private System.Windows.Forms.OpenFileDialog dlg_Abrir;
    }
}

