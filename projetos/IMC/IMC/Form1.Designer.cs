
namespace IMC
{
    partial class Form_IMC
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
            this.lblPeso = new System.Windows.Forms.Label();
            this.lblAltura = new System.Windows.Forms.Label();
            this.lblIMC = new System.Windows.Forms.Label();
            this.lblsituacao = new System.Windows.Forms.Label();
            this.textBox_peso = new System.Windows.Forms.TextBox();
            this.textBox_altura = new System.Windows.Forms.TextBox();
            this.label_resultado_imc = new System.Windows.Forms.Label();
            this.label_resultado_situacao = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkRed;
            this.label1.Location = new System.Drawing.Point(152, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(441, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Índice de Massa Corpórea - IMC";
            // 
            // lblPeso
            // 
            this.lblPeso.AutoSize = true;
            this.lblPeso.Location = new System.Drawing.Point(52, 69);
            this.lblPeso.Name = "lblPeso";
            this.lblPeso.Size = new System.Drawing.Size(62, 18);
            this.lblPeso.TabIndex = 1;
            this.lblPeso.Text = "Peso :";
            // 
            // lblAltura
            // 
            this.lblAltura.AutoSize = true;
            this.lblAltura.Location = new System.Drawing.Point(52, 120);
            this.lblAltura.Name = "lblAltura";
            this.lblAltura.Size = new System.Drawing.Size(72, 18);
            this.lblAltura.TabIndex = 2;
            this.lblAltura.Text = "Altura :";
            // 
            // lblIMC
            // 
            this.lblIMC.AutoSize = true;
            this.lblIMC.Location = new System.Drawing.Point(52, 230);
            this.lblIMC.Name = "lblIMC";
            this.lblIMC.Size = new System.Drawing.Size(54, 18);
            this.lblIMC.TabIndex = 3;
            this.lblIMC.Text = "IMC :";
            this.lblIMC.Click += new System.EventHandler(this.lblIMC_Click);
            // 
            // lblsituacao
            // 
            this.lblsituacao.AutoSize = true;
            this.lblsituacao.Location = new System.Drawing.Point(52, 279);
            this.lblsituacao.Name = "lblsituacao";
            this.lblsituacao.Size = new System.Drawing.Size(94, 18);
            this.lblsituacao.TabIndex = 4;
            this.lblsituacao.Text = "Situação :";
            // 
            // textBox_peso
            // 
            this.textBox_peso.Location = new System.Drawing.Point(141, 60);
            this.textBox_peso.Name = "textBox_peso";
            this.textBox_peso.Size = new System.Drawing.Size(153, 27);
            this.textBox_peso.TabIndex = 5;
            // 
            // textBox_altura
            // 
            this.textBox_altura.Location = new System.Drawing.Point(141, 111);
            this.textBox_altura.Name = "textBox_altura";
            this.textBox_altura.Size = new System.Drawing.Size(153, 27);
            this.textBox_altura.TabIndex = 6;
            // 
            // label_resultado_imc
            // 
            this.label_resultado_imc.AutoSize = true;
            this.label_resultado_imc.Location = new System.Drawing.Point(154, 230);
            this.label_resultado_imc.Name = "label_resultado_imc";
            this.label_resultado_imc.Size = new System.Drawing.Size(0, 18);
            this.label_resultado_imc.TabIndex = 7;
            // 
            // label_resultado_situacao
            // 
            this.label_resultado_situacao.AutoSize = true;
            this.label_resultado_situacao.Location = new System.Drawing.Point(154, 279);
            this.label_resultado_situacao.Name = "label_resultado_situacao";
            this.label_resultado_situacao.Size = new System.Drawing.Size(0, 18);
            this.label_resultado_situacao.TabIndex = 8;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::IMC.Properties.Resources.corpo_imc;
            this.pictureBox1.Location = new System.Drawing.Point(346, 60);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(360, 251);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnSair.Location = new System.Drawing.Point(162, 353);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(170, 41);
            this.btnSair.TabIndex = 10;
            this.btnSair.Text = "&Sair";
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnLimpar.Location = new System.Drawing.Point(387, 353);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(170, 41);
            this.btnLimpar.TabIndex = 11;
            this.btnLimpar.Text = "&Limpar";
            this.btnLimpar.UseVisualStyleBackColor = false;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // Form_IMC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Chocolate;
            this.ClientSize = new System.Drawing.Size(730, 421);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label_resultado_situacao);
            this.Controls.Add(this.label_resultado_imc);
            this.Controls.Add(this.textBox_altura);
            this.Controls.Add(this.textBox_peso);
            this.Controls.Add(this.lblsituacao);
            this.Controls.Add(this.lblIMC);
            this.Controls.Add(this.lblAltura);
            this.Controls.Add(this.lblPeso);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_IMC";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblPeso;
        private System.Windows.Forms.Label lblAltura;
        private System.Windows.Forms.Label lblIMC;
        private System.Windows.Forms.Label lblsituacao;
        private System.Windows.Forms.TextBox textBox_peso;
        private System.Windows.Forms.TextBox textBox_altura;
        private System.Windows.Forms.Label label_resultado_imc;
        private System.Windows.Forms.Label label_resultado_situacao;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnLimpar;
    }
}

