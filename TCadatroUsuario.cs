using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JobStack
{
    public partial class TCadatroUsuario : Form
    {
        public TCadatroUsuario()
        {
            InitializeComponent();
        }

        private void botaoFechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void botaoMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void TCadatroUsuario_Load(object sender, EventArgs e)
        {

        }

        private void campoEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void botaoVoltar_Click(object sender, EventArgs e)
        {

        }
    }
}
