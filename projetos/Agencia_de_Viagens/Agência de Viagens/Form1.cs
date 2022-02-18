using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace Agência_de_Viagens
{
    public partial class Form_agencia : Form
    {
        public Form_agencia()
        {
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLimparDados_Click(object sender, EventArgs e)
        {
            textBox_nome.Clear();
            radioButton_aviao.Checked = false;
            radioButton_onibuns.Checked = false;
            groupBox_resultado.Visible = false;
        }

        private void btnCalculadora_Click(object sender, EventArgs e)
        {
            Process.Start(@"c:\windows\system32\calc.exe ");
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            if (textBox_nome.Text.Length == 0)
            {
                MessageBox.Show("Digite o nome do passageiro...");
                textBox_nome.Focus();
            }
            if (comboBox_destino.Text == "")
            {
                MessageBox.Show("Destino não escolhido");
                comboBox_destino.Focus();
            }
            if (radioButton_aviao.Checked == false && radioButton_onibuns.Checked == false)
            {
                MessageBox.Show("Meio de transporte não escolhido");
                radioButton_onibuns.Focus();
            }

        }

        private void Form_agencia_Load(object sender, EventArgs e)
        {
            this.ClientSize = new System.Drawing.Size (638, 626);
        }

        private void btncalcular_valor_da_viagem_Click(object sender, EventArgs e)
        {
            float gasto_destino, gasto_transporte, gasto_total;
            switch (comboBox_destino.Text.ToUpper()){
                case "SP": gasto_destino = 1000;
                    break;
                case "RJ":
                    gasto_destino = 1500;
                    break;
                case "SC":
                    gasto_destino = 2000;
                    break;
                default:
                    gasto_destino = 0;
                    break;
            }
            if(radioButton_aviao.Checked == true) {gasto_transporte = 100;}
            else {gasto_transporte = 30; }
            gasto_total = gasto_destino + gasto_transporte;
            this.ClientSize = new System.Drawing.Size(638, 626);
            groupBox_resultado.Visible = true;
            label_gasto_destino.Text = gasto_destino.ToString("C2");
            label_gasto_transporte.Text = gasto_transporte.ToString("C2");
            textBox_valor_total.Text = gasto_total.ToString("C2");
        }

        private void textBox_nome_Leave(object sender, EventArgs e)
        {
            textBox_nome.Text = textBox_nome.Text.ToUpper();
        }
    }
}

