using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IMC
{
    public partial class Form_IMC : Form
    {
        public Form_IMC()
        {
            InitializeComponent();
        }

        private void lblIMC_Click(object sender, EventArgs e)
        {
            double altura, peso, imc;
            altura = double.Parse(textBox_altura.Text);
            peso = double.Parse(textBox_peso.Text);
            imc = Math.Round( peso / Math.Pow(altura,2),2);

            label_resultado_imc.Text = imc.ToString();
            if(imc < 20) { label_resultado_situacao.Text = "Abaixo do Peso"; }
            else if(imc <= 25) {label_resultado_situacao.Text = "Peso Normal";}
            else if(imc <= 30) { label_resultado_situacao.Text = "Sobrepeso"; }
            else if(imc <= 40) { label_resultado_situacao.Text = "Obeso"; }
            else { label_resultado_situacao.Text = "Obeso Mórbido"; }


        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            textBox_altura.Clear();
            textBox_peso.Clear();
            label_resultado_imc.Text = " ";
            label_resultado_situacao.Text = " ";
            textBox_peso.Focus();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form_IMC_Load(object sender, EventArgs e)
        {

        }
    }
}
