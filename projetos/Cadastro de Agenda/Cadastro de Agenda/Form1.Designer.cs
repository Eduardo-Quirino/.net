
namespace Cadastro_de_Agenda
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.Label codigoLabel;
            System.Windows.Forms.Label nomeLabel;
            System.Windows.Forms.Label emailLabel;
            System.Windows.Forms.Label celularLabel;
            this.cadastro_de_AgendaDataSet1 = new Cadastro_de_Agenda.Cadastro_de_AgendaDataSet1();
            this.tabAgendaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabAgendaTableAdapter = new Cadastro_de_Agenda.Cadastro_de_AgendaDataSet1TableAdapters.TabAgendaTableAdapter();
            this.tableAdapterManager = new Cadastro_de_Agenda.Cadastro_de_AgendaDataSet1TableAdapters.TableAdapterManager();
            this.tabAgendaBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.tabAgendaBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.tabAgendaDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigoTextBox = new System.Windows.Forms.TextBox();
            this.nomeTextBox = new System.Windows.Forms.TextBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.celularTextBox = new System.Windows.Forms.TextBox();
            codigoLabel = new System.Windows.Forms.Label();
            nomeLabel = new System.Windows.Forms.Label();
            emailLabel = new System.Windows.Forms.Label();
            celularLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.cadastro_de_AgendaDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabAgendaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabAgendaBindingNavigator)).BeginInit();
            this.tabAgendaBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabAgendaDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // cadastro_de_AgendaDataSet1
            // 
            this.cadastro_de_AgendaDataSet1.DataSetName = "Cadastro_de_AgendaDataSet1";
            this.cadastro_de_AgendaDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tabAgendaBindingSource
            // 
            this.tabAgendaBindingSource.DataMember = "TabAgenda";
            this.tabAgendaBindingSource.DataSource = this.cadastro_de_AgendaDataSet1;
            // 
            // tabAgendaTableAdapter
            // 
            this.tabAgendaTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.TabAgendaTableAdapter = this.tabAgendaTableAdapter;
            this.tableAdapterManager.UpdateOrder = Cadastro_de_Agenda.Cadastro_de_AgendaDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // tabAgendaBindingNavigator
            // 
            this.tabAgendaBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.tabAgendaBindingNavigator.BindingSource = this.tabAgendaBindingSource;
            this.tabAgendaBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.tabAgendaBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.tabAgendaBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.tabAgendaBindingNavigatorSaveItem});
            this.tabAgendaBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.tabAgendaBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.tabAgendaBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.tabAgendaBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.tabAgendaBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.tabAgendaBindingNavigator.Name = "tabAgendaBindingNavigator";
            this.tabAgendaBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.tabAgendaBindingNavigator.Size = new System.Drawing.Size(729, 25);
            this.tabAgendaBindingNavigator.TabIndex = 9;
            this.tabAgendaBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Mover primeiro";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Mover anterior";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Posição";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Posição atual";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(37, 15);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Número total de itens";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveNextItem.Text = "Mover próximo";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveLastItem.Text = "Mover último";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Adicionar novo";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorDeleteItem.Text = "Excluir";
            // 
            // tabAgendaBindingNavigatorSaveItem
            // 
            this.tabAgendaBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tabAgendaBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("tabAgendaBindingNavigatorSaveItem.Image")));
            this.tabAgendaBindingNavigatorSaveItem.Name = "tabAgendaBindingNavigatorSaveItem";
            this.tabAgendaBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.tabAgendaBindingNavigatorSaveItem.Text = "Salvar Dados";
            this.tabAgendaBindingNavigatorSaveItem.Click += new System.EventHandler(this.tabAgendaBindingNavigatorSaveItem_Click_1);
            // 
            // tabAgendaDataGridView
            // 
            this.tabAgendaDataGridView.AutoGenerateColumns = false;
            this.tabAgendaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tabAgendaDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.tabAgendaDataGridView.DataSource = this.tabAgendaBindingSource;
            this.tabAgendaDataGridView.Location = new System.Drawing.Point(12, 19);
            this.tabAgendaDataGridView.Name = "tabAgendaDataGridView";
            this.tabAgendaDataGridView.Size = new System.Drawing.Size(697, 201);
            this.tabAgendaDataGridView.TabIndex = 9;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Codigo";
            this.dataGridViewTextBoxColumn1.HeaderText = "Codigo";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Nome";
            this.dataGridViewTextBoxColumn2.HeaderText = "Nome";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Email";
            this.dataGridViewTextBoxColumn3.HeaderText = "Email";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Celular";
            this.dataGridViewTextBoxColumn4.HeaderText = "Celular";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // codigoLabel
            // 
            codigoLabel.AutoSize = true;
            codigoLabel.Location = new System.Drawing.Point(12, 252);
            codigoLabel.Name = "codigoLabel";
            codigoLabel.Size = new System.Drawing.Size(69, 18);
            codigoLabel.TabIndex = 9;
            codigoLabel.Text = "Codigo:";
            // 
            // codigoTextBox
            // 
            this.codigoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tabAgendaBindingSource, "Codigo", true));
            this.codigoTextBox.Location = new System.Drawing.Point(87, 249);
            this.codigoTextBox.Name = "codigoTextBox";
            this.codigoTextBox.Size = new System.Drawing.Size(100, 26);
            this.codigoTextBox.TabIndex = 10;
            // 
            // nomeLabel
            // 
            nomeLabel.AutoSize = true;
            nomeLabel.Location = new System.Drawing.Point(12, 287);
            nomeLabel.Name = "nomeLabel";
            nomeLabel.Size = new System.Drawing.Size(62, 18);
            nomeLabel.TabIndex = 10;
            nomeLabel.Text = "Nome:";
            // 
            // nomeTextBox
            // 
            this.nomeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tabAgendaBindingSource, "Nome", true));
            this.nomeTextBox.Location = new System.Drawing.Point(87, 284);
            this.nomeTextBox.Name = "nomeTextBox";
            this.nomeTextBox.Size = new System.Drawing.Size(297, 26);
            this.nomeTextBox.TabIndex = 11;
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Location = new System.Drawing.Point(12, 324);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new System.Drawing.Size(58, 18);
            emailLabel.TabIndex = 11;
            emailLabel.Text = "Email:";
            // 
            // emailTextBox
            // 
            this.emailTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tabAgendaBindingSource, "Email", true));
            this.emailTextBox.Location = new System.Drawing.Point(87, 321);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(297, 26);
            this.emailTextBox.TabIndex = 12;
            // 
            // celularLabel
            // 
            celularLabel.AutoSize = true;
            celularLabel.Location = new System.Drawing.Point(12, 364);
            celularLabel.Name = "celularLabel";
            celularLabel.Size = new System.Drawing.Size(70, 18);
            celularLabel.TabIndex = 12;
            celularLabel.Text = "Celular:";
            // 
            // celularTextBox
            // 
            this.celularTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tabAgendaBindingSource, "Celular", true));
            this.celularTextBox.Location = new System.Drawing.Point(88, 361);
            this.celularTextBox.Name = "celularTextBox";
            this.celularTextBox.Size = new System.Drawing.Size(136, 26);
            this.celularTextBox.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(729, 414);
            this.Controls.Add(celularLabel);
            this.Controls.Add(this.celularTextBox);
            this.Controls.Add(emailLabel);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(nomeLabel);
            this.Controls.Add(this.nomeTextBox);
            this.Controls.Add(codigoLabel);
            this.Controls.Add(this.codigoTextBox);
            this.Controls.Add(this.tabAgendaDataGridView);
            this.Controls.Add(this.tabAgendaBindingNavigator);
            this.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AGENDA";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cadastro_de_AgendaDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabAgendaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabAgendaBindingNavigator)).EndInit();
            this.tabAgendaBindingNavigator.ResumeLayout(false);
            this.tabAgendaBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabAgendaDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Cadastro_de_AgendaDataSet1 cadastro_de_AgendaDataSet1;
        private System.Windows.Forms.BindingSource tabAgendaBindingSource;
        private Cadastro_de_AgendaDataSet1TableAdapters.TabAgendaTableAdapter tabAgendaTableAdapter;
        private Cadastro_de_AgendaDataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator tabAgendaBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton tabAgendaBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView tabAgendaDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.TextBox codigoTextBox;
        private System.Windows.Forms.TextBox nomeTextBox;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.TextBox celularTextBox;
    }
}

