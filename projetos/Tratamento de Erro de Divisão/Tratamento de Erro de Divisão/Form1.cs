using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tratamento_de_Erro_de_Divisão
{
    public partial class Frm_Excecao : Form
    {
        public Frm_Excecao()
        {
            InitializeComponent();
        }

        private void Frm_Excecao_Load(object sender, EventArgs e)
        {

        }

        private void btn_sair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_limpar_Click(object sender, EventArgs e)
        {
            textBox_valor1.Clear();
            textBox_valor2.Clear();
            textBox_resultado.Clear();
            textBox_valor1.Focus();
        }

        private void btn_dividir_Click(object sender, EventArgs e)
        {
            try
            {
                decimal valor1, valor2, resultado;
                valor1 = decimal.Parse(textBox_valor1.Text);
                valor2 = decimal.Parse(textBox_valor2.Text);
                resultado = valor1 / valor2;
                textBox_resultado.Text = Convert.ToString(resultado);
            }
            /* 
             catch(Exception ex)//1° exemplo de erro
             {
                 MessageBox.Show(ex.Message,"Erro genérico!!!");
             }
            */
            catch (DivideByZeroException)//2° exemplo de erro
            {
                MessageBox.Show("Não existe divisão por ZERO tente novamente!!!");
            }
            catch (OverflowException)//erro de estouro
            {
                MessageBox.Show("Erro de tamanho, a calculadora não suporta esses valores!");
            }
            catch (FormatException)
            {
                MessageBox.Show("Formato invalido de dados!");
            }
           /* finally
            {//finaliza o programa depois de click DIVIDIR
                MessageBox.Show("Isto acontece sempre, dando erro ou não!!!");
                this.Close();
            }
           */
        }
    }
}
