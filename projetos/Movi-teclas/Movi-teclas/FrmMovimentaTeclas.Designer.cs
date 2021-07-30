
namespace Movi_teclas
{
    partial class FrmMovimentaTeclas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMovimentaTeclas));
            this.ImgLogo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ImgLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // ImgLogo
            // 
            this.ImgLogo.Image = ((System.Drawing.Image)(resources.GetObject("ImgLogo.Image")));
            this.ImgLogo.Location = new System.Drawing.Point(162, 171);
            this.ImgLogo.Name = "ImgLogo";
            this.ImgLogo.Size = new System.Drawing.Size(284, 103);
            this.ImgLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ImgLogo.TabIndex = 0;
            this.ImgLogo.TabStop = false;
            // 
            // FrmMovimentaTeclas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(605, 503);
            this.Controls.Add(this.ImgLogo);
            this.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "FrmMovimentaTeclas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Movimento de Imagem";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmMovimentaTeclas_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.ImgLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox ImgLogo;
    }
}

