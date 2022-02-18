
namespace Agência_de_Viagens
{
    partial class Form_agencia
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_agencia));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_nome = new System.Windows.Forms.TextBox();
            this.comboBox_destino = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton_aviao = new System.Windows.Forms.RadioButton();
            this.radioButton_onibuns = new System.Windows.Forms.RadioButton();
            this.groupBox_resultado = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label_gasto_transporte = new System.Windows.Forms.Label();
            this.label_gasto_destino = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox_valor_total = new System.Windows.Forms.TextBox();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.btnLimparDados = new System.Windows.Forms.Button();
            this.btnCalculadora = new System.Windows.Forms.Button();
            this.btncalcular_valor_da_viagem = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox_resultado.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(598, 68);
            this.label1.TabIndex = 0;
            this.label1.Text = "Reserva de Passagem";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Bright", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(36, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nome :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lucida Bright", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(36, 174);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Destino :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Lucida Bright", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(36, 220);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Data Embarque :";
            // 
            // textBox_nome
            // 
            this.textBox_nome.Font = new System.Drawing.Font("Lucida Bright", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_nome.Location = new System.Drawing.Point(150, 121);
            this.textBox_nome.Name = "textBox_nome";
            this.textBox_nome.Size = new System.Drawing.Size(311, 23);
            this.textBox_nome.TabIndex = 4;
            this.textBox_nome.Leave += new System.EventHandler(this.textBox_nome_Leave);
            // 
            // comboBox_destino
            // 
            this.comboBox_destino.Font = new System.Drawing.Font("Lucida Bright", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_destino.FormattingEnabled = true;
            this.comboBox_destino.Items.AddRange(new object[] {
            "SP",
            "RJ",
            "SC"});
            this.comboBox_destino.Location = new System.Drawing.Point(150, 171);
            this.comboBox_destino.Name = "comboBox_destino";
            this.comboBox_destino.Size = new System.Drawing.Size(309, 23);
            this.comboBox_destino.TabIndex = 5;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Lucida Bright", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(150, 214);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(311, 23);
            this.dateTimePicker1.TabIndex = 6;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton_onibuns);
            this.groupBox1.Controls.Add(this.radioButton_aviao);
            this.groupBox1.Location = new System.Drawing.Point(150, 294);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(311, 73);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Meio de Transporte";
            // 
            // radioButton_aviao
            // 
            this.radioButton_aviao.AutoSize = true;
            this.radioButton_aviao.Location = new System.Drawing.Point(62, 33);
            this.radioButton_aviao.Name = "radioButton_aviao";
            this.radioButton_aviao.Size = new System.Drawing.Size(52, 17);
            this.radioButton_aviao.TabIndex = 0;
            this.radioButton_aviao.TabStop = true;
            this.radioButton_aviao.Text = "Avião";
            this.radioButton_aviao.UseVisualStyleBackColor = true;
            // 
            // radioButton_onibuns
            // 
            this.radioButton_onibuns.AutoSize = true;
            this.radioButton_onibuns.Location = new System.Drawing.Point(191, 33);
            this.radioButton_onibuns.Name = "radioButton_onibuns";
            this.radioButton_onibuns.Size = new System.Drawing.Size(58, 17);
            this.radioButton_onibuns.TabIndex = 1;
            this.radioButton_onibuns.TabStop = true;
            this.radioButton_onibuns.Text = "Ônibus";
            this.radioButton_onibuns.UseVisualStyleBackColor = true;
            // 
            // groupBox_resultado
            // 
            this.groupBox_resultado.Controls.Add(this.textBox_valor_total);
            this.groupBox_resultado.Controls.Add(this.label9);
            this.groupBox_resultado.Controls.Add(this.label_gasto_destino);
            this.groupBox_resultado.Controls.Add(this.label_gasto_transporte);
            this.groupBox_resultado.Controls.Add(this.label6);
            this.groupBox_resultado.Controls.Add(this.label5);
            this.groupBox_resultado.Font = new System.Drawing.Font("Lucida Bright", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox_resultado.Location = new System.Drawing.Point(41, 405);
            this.groupBox_resultado.Name = "groupBox_resultado";
            this.groupBox_resultado.Size = new System.Drawing.Size(419, 135);
            this.groupBox_resultado.TabIndex = 8;
            this.groupBox_resultado.TabStop = false;
            this.groupBox_resultado.Text = "Valores do Pacote";
            this.groupBox_resultado.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(136, 15);
            this.label5.TabIndex = 0;
            this.label5.Text = "Gasto Transporte :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(22, 63);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(146, 15);
            this.label6.TabIndex = 1;
            this.label6.Text = "Gasto com Destino :";
            // 
            // label_gasto_transporte
            // 
            this.label_gasto_transporte.AutoSize = true;
            this.label_gasto_transporte.Location = new System.Drawing.Point(214, 28);
            this.label_gasto_transporte.Name = "label_gasto_transporte";
            this.label_gasto_transporte.Size = new System.Drawing.Size(0, 15);
            this.label_gasto_transporte.TabIndex = 2;
            // 
            // label_gasto_destino
            // 
            this.label_gasto_destino.AutoSize = true;
            this.label_gasto_destino.Location = new System.Drawing.Point(214, 63);
            this.label_gasto_destino.Name = "label_gasto_destino";
            this.label_gasto_destino.Size = new System.Drawing.Size(0, 15);
            this.label_gasto_destino.TabIndex = 3;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(22, 109);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(90, 15);
            this.label9.TabIndex = 4;
            this.label9.Text = "Valor Total :";
            // 
            // textBox_valor_total
            // 
            this.textBox_valor_total.Location = new System.Drawing.Point(217, 101);
            this.textBox_valor_total.Name = "textBox_valor_total";
            this.textBox_valor_total.Size = new System.Drawing.Size(167, 23);
            this.textBox_valor_total.TabIndex = 5;
            // 
            // btnSair
            // 
            this.btnSair.Font = new System.Drawing.Font("Lucida Bright", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.Location = new System.Drawing.Point(491, 121);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(119, 45);
            this.btnSair.TabIndex = 9;
            this.btnSair.Text = "&Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.Font = new System.Drawing.Font("Lucida Bright", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmar.Location = new System.Drawing.Point(491, 217);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(119, 45);
            this.btnConfirmar.TabIndex = 10;
            this.btnConfirmar.Text = "&Confirmar";
            this.btnConfirmar.UseVisualStyleBackColor = true;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // btnLimparDados
            // 
            this.btnLimparDados.Font = new System.Drawing.Font("Lucida Bright", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimparDados.Location = new System.Drawing.Point(491, 296);
            this.btnLimparDados.Name = "btnLimparDados";
            this.btnLimparDados.Size = new System.Drawing.Size(119, 45);
            this.btnLimparDados.TabIndex = 11;
            this.btnLimparDados.Text = "&Limpar Dados";
            this.btnLimparDados.UseVisualStyleBackColor = true;
            this.btnLimparDados.Click += new System.EventHandler(this.btnLimparDados_Click);
            // 
            // btnCalculadora
            // 
            this.btnCalculadora.Font = new System.Drawing.Font("Lucida Bright", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculadora.Location = new System.Drawing.Point(491, 381);
            this.btnCalculadora.Name = "btnCalculadora";
            this.btnCalculadora.Size = new System.Drawing.Size(119, 45);
            this.btnCalculadora.TabIndex = 12;
            this.btnCalculadora.Text = "C&alculadora";
            this.btnCalculadora.UseVisualStyleBackColor = true;
            this.btnCalculadora.Click += new System.EventHandler(this.btnCalculadora_Click);
            // 
            // btncalcular_valor_da_viagem
            // 
            this.btncalcular_valor_da_viagem.Font = new System.Drawing.Font("Lucida Bright", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncalcular_valor_da_viagem.Location = new System.Drawing.Point(491, 468);
            this.btncalcular_valor_da_viagem.Name = "btncalcular_valor_da_viagem";
            this.btncalcular_valor_da_viagem.Size = new System.Drawing.Size(119, 45);
            this.btncalcular_valor_da_viagem.TabIndex = 13;
            this.btncalcular_valor_da_viagem.Text = "Calcular &Valor da Viagem";
            this.btncalcular_valor_da_viagem.UseVisualStyleBackColor = true;
            this.btncalcular_valor_da_viagem.Click += new System.EventHandler(this.btncalcular_valor_da_viagem_Click);
            // 
            // Form_agencia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(622, 587);
            this.Controls.Add(this.btncalcular_valor_da_viagem);
            this.Controls.Add(this.btnCalculadora);
            this.Controls.Add(this.btnLimparDados);
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.groupBox_resultado);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.comboBox_destino);
            this.Controls.Add(this.textBox_nome);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form_agencia";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agência de Viagens";
            this.Load += new System.EventHandler(this.Form_agencia_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox_resultado.ResumeLayout(false);
            this.groupBox_resultado.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_nome;
        private System.Windows.Forms.ComboBox comboBox_destino;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton_onibuns;
        private System.Windows.Forms.RadioButton radioButton_aviao;
        private System.Windows.Forms.GroupBox groupBox_resultado;
        private System.Windows.Forms.TextBox textBox_valor_total;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label_gasto_destino;
        private System.Windows.Forms.Label label_gasto_transporte;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.Button btnLimparDados;
        private System.Windows.Forms.Button btnCalculadora;
        private System.Windows.Forms.Button btncalcular_valor_da_viagem;
    }
}

