using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cadastro_de_Agenda
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'cadastro_de_AgendaDataSet1.TabAgenda'. Você pode movê-la ou removê-la conforme necessário.
            this.tabAgendaTableAdapter.Fill(this.cadastro_de_AgendaDataSet1.TabAgenda);
            // TODO: esta linha de código carrega dados na tabela 'cadastro_de_AgendaDataSet1.TabAgenda'. Você pode movê-la ou removê-la conforme necessário.
            this.tabAgendaTableAdapter.Fill(this.cadastro_de_AgendaDataSet1.TabAgenda);
            // TODO: esta linha de código carrega dados na tabela 'cadastro_de_AgendaDataSet1.TabAgenda'. Você pode movê-la ou removê-la conforme necessário.
            this.tabAgendaTableAdapter.Fill(this.cadastro_de_AgendaDataSet1.TabAgenda);

        }

        private void tabAgendaBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tabAgendaBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.cadastro_de_AgendaDataSet1);

        }

        private void tabAgendaBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.tabAgendaBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.cadastro_de_AgendaDataSet1);

        }
    }
}
