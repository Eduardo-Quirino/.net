using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Relógio
{
    public partial class FormRelogio : Form
    {
        public FormRelogio()
        {
            InitializeComponent();
        }

        private void FormRelogio_Load(object sender, EventArgs e)
        {
            lbl_data.Text = DateTime.Now.ToLongDateString();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbl_relogio.Text = DateTime.Now.ToLongTimeString();
        }
    }
}
