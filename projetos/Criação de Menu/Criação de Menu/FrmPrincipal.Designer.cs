
namespace Criação_de_Menu
{
    partial class FrmPrincipal
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.opçõesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.calculo_da_media_toolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lista_de_nomes_toolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.movimentar_imagem_toolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.relogio_toolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.visualizar_imagem_toolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.sair_do_programa_toolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.opçõesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1200, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // opçõesToolStripMenuItem
            // 
            this.opçõesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.calculo_da_media_toolStripMenuItem,
            this.lista_de_nomes_toolStripMenuItem,
            this.movimentar_imagem_toolStripMenuItem,
            this.relogio_toolStripMenuItem,
            this.visualizar_imagem_toolStripMenuItem,
            this.toolStripSeparator1,
            this.sair_do_programa_toolStripMenuItem});
            this.opçõesToolStripMenuItem.Name = "opçõesToolStripMenuItem";
            this.opçõesToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.opçõesToolStripMenuItem.Text = "&Opções";
            // 
            // calculo_da_media_toolStripMenuItem
            // 
            this.calculo_da_media_toolStripMenuItem.Name = "calculo_da_media_toolStripMenuItem";
            this.calculo_da_media_toolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.calculo_da_media_toolStripMenuItem.Size = new System.Drawing.Size(231, 22);
            this.calculo_da_media_toolStripMenuItem.Text = "Cálculo da Média";
            this.calculo_da_media_toolStripMenuItem.Click += new System.EventHandler(this.calculo_da_media_toolStripMenuItem_Click);
            // 
            // lista_de_nomes_toolStripMenuItem
            // 
            this.lista_de_nomes_toolStripMenuItem.Name = "lista_de_nomes_toolStripMenuItem";
            this.lista_de_nomes_toolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.L)));
            this.lista_de_nomes_toolStripMenuItem.Size = new System.Drawing.Size(231, 22);
            this.lista_de_nomes_toolStripMenuItem.Text = "Lista de Nomes";
            this.lista_de_nomes_toolStripMenuItem.Click += new System.EventHandler(this.lista_de_nomes_toolStripMenuItem_Click);
            // 
            // movimentar_imagem_toolStripMenuItem
            // 
            this.movimentar_imagem_toolStripMenuItem.Name = "movimentar_imagem_toolStripMenuItem";
            this.movimentar_imagem_toolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.M)));
            this.movimentar_imagem_toolStripMenuItem.Size = new System.Drawing.Size(231, 22);
            this.movimentar_imagem_toolStripMenuItem.Text = "Movimentar Imagem";
            this.movimentar_imagem_toolStripMenuItem.Click += new System.EventHandler(this.movimentar_imagem_toolStripMenuItem_Click);
            // 
            // relogio_toolStripMenuItem
            // 
            this.relogio_toolStripMenuItem.Name = "relogio_toolStripMenuItem";
            this.relogio_toolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.R)));
            this.relogio_toolStripMenuItem.Size = new System.Drawing.Size(231, 22);
            this.relogio_toolStripMenuItem.Text = "Relógio";
            this.relogio_toolStripMenuItem.Click += new System.EventHandler(this.relogio_toolStripMenuItem_Click);
            // 
            // visualizar_imagem_toolStripMenuItem
            // 
            this.visualizar_imagem_toolStripMenuItem.Name = "visualizar_imagem_toolStripMenuItem";
            this.visualizar_imagem_toolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.visualizar_imagem_toolStripMenuItem.Size = new System.Drawing.Size(231, 22);
            this.visualizar_imagem_toolStripMenuItem.Text = "Visualizar Imagem";
            this.visualizar_imagem_toolStripMenuItem.Click += new System.EventHandler(this.visualizar_imagem_toolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(228, 6);
            // 
            // sair_do_programa_toolStripMenuItem
            // 
            this.sair_do_programa_toolStripMenuItem.Name = "sair_do_programa_toolStripMenuItem";
            this.sair_do_programa_toolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.S)));
            this.sair_do_programa_toolStripMenuItem.Size = new System.Drawing.Size(231, 22);
            this.sair_do_programa_toolStripMenuItem.Text = "Sair";
            this.sair_do_programa_toolStripMenuItem.Click += new System.EventHandler(this.sair_do_programa_toolStripMenuItem_Click);
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 588);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FrmPrincipal";
            this.Text = "Menus C#";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem opçõesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem calculo_da_media_toolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lista_de_nomes_toolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem movimentar_imagem_toolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem relogio_toolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem visualizar_imagem_toolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem sair_do_programa_toolStripMenuItem;
    }
}

