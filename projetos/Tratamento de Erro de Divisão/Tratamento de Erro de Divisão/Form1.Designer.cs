
namespace Tratamento_de_Erro_de_Divisão
{
    partial class Frm_Excecao
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Excecao));
            this.lbl_primeri = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_valor1 = new System.Windows.Forms.TextBox();
            this.textBox_valor2 = new System.Windows.Forms.TextBox();
            this.textBox_resultado = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_dividir = new System.Windows.Forms.Button();
            this.btn_limpar = new System.Windows.Forms.Button();
            this.btn_sair = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_primeri
            // 
            this.lbl_primeri.AutoSize = true;
            this.lbl_primeri.Location = new System.Drawing.Point(33, 34);
            this.lbl_primeri.Name = "lbl_primeri";
            this.lbl_primeri.Size = new System.Drawing.Size(115, 19);
            this.lbl_primeri.TabIndex = 0;
            this.lbl_primeri.Text = "Primeiro Valor :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Segundo Valor :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Resultado :";
            // 
            // textBox_valor1
            // 
            this.textBox_valor1.Location = new System.Drawing.Point(154, 31);
            this.textBox_valor1.Name = "textBox_valor1";
            this.textBox_valor1.Size = new System.Drawing.Size(137, 26);
            this.textBox_valor1.TabIndex = 3;
            // 
            // textBox_valor2
            // 
            this.textBox_valor2.Location = new System.Drawing.Point(154, 75);
            this.textBox_valor2.Name = "textBox_valor2";
            this.textBox_valor2.Size = new System.Drawing.Size(137, 26);
            this.textBox_valor2.TabIndex = 4;
            // 
            // textBox_resultado
            // 
            this.textBox_resultado.Location = new System.Drawing.Point(154, 143);
            this.textBox_resultado.Name = "textBox_resultado";
            this.textBox_resultado.Size = new System.Drawing.Size(137, 26);
            this.textBox_resultado.TabIndex = 5;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(313, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(256, 235);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // btn_dividir
            // 
            this.btn_dividir.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btn_dividir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_dividir.Location = new System.Drawing.Point(25, 212);
            this.btn_dividir.Name = "btn_dividir";
            this.btn_dividir.Size = new System.Drawing.Size(82, 35);
            this.btn_dividir.TabIndex = 7;
            this.btn_dividir.Text = "&Dividir";
            this.btn_dividir.UseVisualStyleBackColor = false;
            this.btn_dividir.Click += new System.EventHandler(this.btn_dividir_Click);
            // 
            // btn_limpar
            // 
            this.btn_limpar.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btn_limpar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_limpar.Location = new System.Drawing.Point(113, 212);
            this.btn_limpar.Name = "btn_limpar";
            this.btn_limpar.Size = new System.Drawing.Size(96, 35);
            this.btn_limpar.TabIndex = 8;
            this.btn_limpar.Text = "&Limpar";
            this.btn_limpar.UseVisualStyleBackColor = false;
            this.btn_limpar.Click += new System.EventHandler(this.btn_limpar_Click);
            // 
            // btn_sair
            // 
            this.btn_sair.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btn_sair.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_sair.Location = new System.Drawing.Point(215, 212);
            this.btn_sair.Name = "btn_sair";
            this.btn_sair.Size = new System.Drawing.Size(92, 35);
            this.btn_sair.TabIndex = 9;
            this.btn_sair.Text = "&Sair";
            this.btn_sair.UseVisualStyleBackColor = false;
            this.btn_sair.Click += new System.EventHandler(this.btn_sair_Click);
            // 
            // Frm_Excecao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(581, 272);
            this.Controls.Add(this.btn_sair);
            this.Controls.Add(this.btn_limpar);
            this.Controls.Add(this.btn_dividir);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.textBox_resultado);
            this.Controls.Add(this.textBox_valor2);
            this.Controls.Add(this.textBox_valor1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbl_primeri);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Frm_Excecao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Exceção Matemática";
            this.Load += new System.EventHandler(this.Frm_Excecao_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_primeri;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_valor1;
        private System.Windows.Forms.TextBox textBox_valor2;
        private System.Windows.Forms.TextBox textBox_resultado;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_dividir;
        private System.Windows.Forms.Button btn_limpar;
        private System.Windows.Forms.Button btn_sair;
    }
}

