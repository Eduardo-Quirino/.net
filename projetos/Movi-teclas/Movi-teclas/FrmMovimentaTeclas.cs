using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Movi_teclas
{
    public partial class FrmMovimentaTeclas : Form
    {
        public FrmMovimentaTeclas()
        {
            InitializeComponent();
        }

        private void FrmMovimentaTeclas_KeyDown(object sender, KeyEventArgs e)
        {
            #region Mover para a esquerda
            if(e.KeyCode == Keys.Left)
            {
                if(ImgLogo.Location.X > -99) { ImgLogo.Left -= 10; }
                else { ImgLogo.Left = 615; }
            }          
            #endregion

            #region Mover para cima
            if (e.KeyCode == Keys.Up)
            {
                if (ImgLogo.Location.Y > -94) { ImgLogo.Top -= 10; }
                else { ImgLogo.Top = 514; }//Keys.<Nome da tecla>
            }           
            #endregion

            #region Mover para a direita
            if (e.KeyCode == Keys.Right)
            {
                if (ImgLogo.Location.X < 615) { ImgLogo.Left += 10; }
                else { ImgLogo.Left = -99; }
            }           
            #endregion

            #region Mover para baixo
            if (e.KeyCode == Keys.Down)
            {
                if (ImgLogo.Location.Y < 514) { ImgLogo.Top += 10; }
                else { ImgLogo.Top = -94; }//Keys.<Nome da tecla>
            }           
            #endregion

        }
    }
}
