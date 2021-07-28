
namespace Formulário_MDI
{
    partial class frmPai
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPai));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnuFormulario = new System.Windows.Forms.ToolStripMenuItem();
            this.abrirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.novoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.janelasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.emCascataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.horizontalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tileVerticalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.arranjarIconesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.opçõesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fecharTodosOsFormuláriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.minimizaTodosOsFormuláriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.AllowMerge = false;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFormulario,
            this.janelasToolStripMenuItem,
            this.opçõesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.MdiWindowListItem = this.mnuFormulario;
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(543, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnuFormulario
            // 
            this.mnuFormulario.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.abrirToolStripMenuItem,
            this.novoToolStripMenuItem,
            this.sairToolStripMenuItem});
            this.mnuFormulario.Image = ((System.Drawing.Image)(resources.GetObject("mnuFormulario.Image")));
            this.mnuFormulario.Name = "mnuFormulario";
            this.mnuFormulario.Size = new System.Drawing.Size(109, 24);
            this.mnuFormulario.Text = "Formulário";
            // 
            // abrirToolStripMenuItem
            // 
            this.abrirToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("abrirToolStripMenuItem.Image")));
            this.abrirToolStripMenuItem.Name = "abrirToolStripMenuItem";
            this.abrirToolStripMenuItem.Size = new System.Drawing.Size(225, 24);
            this.abrirToolStripMenuItem.Text = "Abrir Formulário Filho";
            this.abrirToolStripMenuItem.Click += new System.EventHandler(this.abrirToolStripMenuItem_Click);
            // 
            // novoToolStripMenuItem
            // 
            this.novoToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("novoToolStripMenuItem.Image")));
            this.novoToolStripMenuItem.Name = "novoToolStripMenuItem";
            this.novoToolStripMenuItem.Size = new System.Drawing.Size(225, 24);
            this.novoToolStripMenuItem.Text = "Criar Novo Formulário";
            this.novoToolStripMenuItem.Click += new System.EventHandler(this.novoToolStripMenuItem_Click);
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(225, 24);
            this.sairToolStripMenuItem.Text = "Sair";
            // 
            // janelasToolStripMenuItem
            // 
            this.janelasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.emCascataToolStripMenuItem,
            this.horizontalToolStripMenuItem,
            this.tileVerticalToolStripMenuItem,
            this.arranjarIconesToolStripMenuItem});
            this.janelasToolStripMenuItem.Name = "janelasToolStripMenuItem";
            this.janelasToolStripMenuItem.Size = new System.Drawing.Size(68, 24);
            this.janelasToolStripMenuItem.Text = "Janelas";
            // 
            // emCascataToolStripMenuItem
            // 
            this.emCascataToolStripMenuItem.Name = "emCascataToolStripMenuItem";
            this.emCascataToolStripMenuItem.Size = new System.Drawing.Size(180, 24);
            this.emCascataToolStripMenuItem.Text = "Em Cascata";
            this.emCascataToolStripMenuItem.Click += new System.EventHandler(this.emCascataToolStripMenuItem_Click);
            // 
            // horizontalToolStripMenuItem
            // 
            this.horizontalToolStripMenuItem.Name = "horizontalToolStripMenuItem";
            this.horizontalToolStripMenuItem.Size = new System.Drawing.Size(180, 24);
            this.horizontalToolStripMenuItem.Text = "Tile Horizontal";
            this.horizontalToolStripMenuItem.Click += new System.EventHandler(this.horizontalToolStripMenuItem_Click);
            // 
            // tileVerticalToolStripMenuItem
            // 
            this.tileVerticalToolStripMenuItem.Name = "tileVerticalToolStripMenuItem";
            this.tileVerticalToolStripMenuItem.Size = new System.Drawing.Size(180, 24);
            this.tileVerticalToolStripMenuItem.Text = "Tile Vertical";
            this.tileVerticalToolStripMenuItem.Click += new System.EventHandler(this.tileVerticalToolStripMenuItem_Click);
            // 
            // arranjarIconesToolStripMenuItem
            // 
            this.arranjarIconesToolStripMenuItem.Name = "arranjarIconesToolStripMenuItem";
            this.arranjarIconesToolStripMenuItem.Size = new System.Drawing.Size(180, 24);
            this.arranjarIconesToolStripMenuItem.Text = "Arranjar Ícones";
            this.arranjarIconesToolStripMenuItem.Click += new System.EventHandler(this.arranjarIconesToolStripMenuItem_Click);
            // 
            // opçõesToolStripMenuItem
            // 
            this.opçõesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fecharTodosOsFormuláriosToolStripMenuItem,
            this.minimizaTodosOsFormuláriosToolStripMenuItem});
            this.opçõesToolStripMenuItem.Name = "opçõesToolStripMenuItem";
            this.opçõesToolStripMenuItem.Size = new System.Drawing.Size(71, 24);
            this.opçõesToolStripMenuItem.Text = "Opções";
            // 
            // fecharTodosOsFormuláriosToolStripMenuItem
            // 
            this.fecharTodosOsFormuláriosToolStripMenuItem.Name = "fecharTodosOsFormuláriosToolStripMenuItem";
            this.fecharTodosOsFormuláriosToolStripMenuItem.Size = new System.Drawing.Size(264, 24);
            this.fecharTodosOsFormuláriosToolStripMenuItem.Text = "Fechar todos os Formulários";
            this.fecharTodosOsFormuláriosToolStripMenuItem.Click += new System.EventHandler(this.fecharTodosOsFormuláriosToolStripMenuItem_Click);
            // 
            // minimizaTodosOsFormuláriosToolStripMenuItem
            // 
            this.minimizaTodosOsFormuláriosToolStripMenuItem.Name = "minimizaTodosOsFormuláriosToolStripMenuItem";
            this.minimizaTodosOsFormuláriosToolStripMenuItem.Size = new System.Drawing.Size(284, 24);
            this.minimizaTodosOsFormuláriosToolStripMenuItem.Text = "Minimiza Todos os Formulários";
            this.minimizaTodosOsFormuláriosToolStripMenuItem.Click += new System.EventHandler(this.minimizaTodosOsFormuláriosToolStripMenuItem_Click);
            // 
            // frmPai
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(543, 450);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmPai";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MDI";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuFormulario;
        private System.Windows.Forms.ToolStripMenuItem abrirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem novoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem janelasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem emCascataToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem horizontalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tileVerticalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem arranjarIconesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem opçõesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fecharTodosOsFormuláriosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem minimizaTodosOsFormuláriosToolStripMenuItem;
    }
}

